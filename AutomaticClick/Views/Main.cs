using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using AutomaticClick.Utils;
using Microsoft.Azure.CognitiveServices.Vision.ComputerVision;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Sunny.UI;
using static AutomaticClick.Utils.MouseOperation;
using Timer = System.Timers.Timer;

namespace AutomaticClick.Views
{
    public partial class Main : BaseForm
    {
        [DllImport("user32")]
        private extern static IntPtr GetDC(IntPtr hWnd);

        private const string FilePath = @"images";
        private const string FileName = @"images\screen.png";
        private const string AnalyzeFileName = @"images\screen_analyze.png";

        /// <summary>
        /// 视觉客户端
        /// </summary>
        private ComputerVisionClient _client =
            new(new ApiKeyServiceClientCredentials(Program.Configuration["System:ComputerVisionSubscriptionKey"]))
                {Endpoint = Program.Configuration["System:ComputerVisionEndpoint"]};

        /// <summary>
        /// 默认高度
        /// </summary>
        private readonly int _defaultHeight;

        /// <summary>
        /// 默认容器距离
        /// </summary>
        private readonly int _defaultDistance;

        public Main()
        {
            InitializeComponent();
            _defaultHeight = Height;
            _defaultDistance = mainContainer.SplitterDistance;
            SetArea();

            //Ocr线程
            var ocrThread = new Thread(OcrTask) {IsBackground = true};
            ocrThread.Start();

            //Analyze线程
            var analyzeThread = new Thread(AnalyzeTask) {IsBackground = true};
            analyzeThread.Start();

            //定时截屏
            var timer = new Timer(screenInterval.IntValue);
            timer.Elapsed += TimerOnElapsed;
            timer.Start();
            screenInterval.TextChanged += (_, _) =>
            {
                if (screenInterval.IntValue < screenInterval.Minimum) return;
                timer.Interval = screenInterval.IntValue;
            };
        }

        /// <summary>
        /// 设置显示
        /// </summary>
        private void SetArea()
        {
            startX.Text = Shared.StartX.ToString();
            startY.Text = Shared.StartY.ToString();
            endX.Text = Shared.EndX.ToString();
            endY.Text = Shared.EndY.ToString();
        }

        /// <summary>
        /// Mini模式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MiniBox_CheckedChanged(object sender, EventArgs e)
        {
            var mini = ((UICheckBox) sender).Checked;
            Height = mini ? controlPanel.Height + TitleHeight : _defaultHeight;
            mainContainer.Panel2Collapsed = mini;
            mainContainer.SplitterDistance = _defaultDistance;
        }

        /// <summary>
        /// 重新选择区域
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void screen_Click(object sender, EventArgs e)
        {
            if (!MiniBox.Checked) MiniBox.Checked = true;
            if (Program.ServiceProvider.GetRequiredService<ScreenShot>().ShowDialog() != DialogResult.OK) return;
            MiniBox.Checked = false;
            SetArea();
        }

        /// <summary>
        /// Ocr线程
        /// </summary>
        private async void OcrTask()
        {
            while (true)
            {
                Thread.Sleep(1);
                if (!ocrBox.Checked) continue;
                try
                {
                    //Ocr识别
                    var items = await Ocr.AnalyzeStream(_client, new FileStream(FileName, FileMode.Open));
                    Invoke(new Action(() =>
                    {
                        ocrItems.DataSource = items;
                        //自动点击中心
                        if (!clickBox.Checked) return;
                        //匹配字符串
                        var match = false;
                        foreach (var matchString in Program.Configuration.GetSection("System:MatchString")
                            .AsEnumerable()
                            .Where(x => x.Value != null).Select(x => x.Value))
                        {
                            foreach (var item in items.Select(x => x.Item))
                                if (item.Contains(matchString))
                                    match = true;
                        }

                        if (!match) return;
                        //移动 点击
                        var centerX = (Shared.EndX - Shared.StartX) / 2 + Shared.StartX;
                        var centerY = (Shared.EndY - Shared.StartY) / 2 + Shared.StartY;
                        mouse_event(MOUSEEVENTF_MOVE, centerX - MousePosition.X, centerY - MousePosition.Y, 0, 0);
                        mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                    }));

                    Thread.Sleep((analyzeInterval.IntValue < analyzeInterval.Minimum
                        ? Convert.ToInt32(analyzeInterval.Minimum)
                        : analyzeInterval.IntValue) * 1000);
                }
                catch
                {
                    // ignored
                }
            }
        }

        /// <summary>
        /// 分析图片
        /// </summary>
        private Image _analyzeImage;

        /// <summary>
        /// Analyze线程
        /// </summary>
        private async void AnalyzeTask()
        {
            while (true)
            {
                Thread.Sleep(1);
                if (!analyzeBox.Checked) continue;
                try
                {
                    //复制图片
                    _analyzeImage?.Dispose();
                    File.Copy(FileName, AnalyzeFileName, true);
                    //分析图像
                    var result = await Analyze.AnalyzeStream(_client,
                        new FileStream(AnalyzeFileName, FileMode.Open));
                    //翻译内容
                    var resultTranslation = await Translation.Translate(result);
                    //获取复制的图片
                    _analyzeImage = Image.FromFile(AnalyzeFileName);
                    var graphics = Graphics.FromHdc(GetDC(IntPtr.Zero));
                    //绘图
                    var font = new Font("JetBrains Mono", 12, FontStyle.Bold);
                    var color = Color.Red;
                    //遍历品牌
                    foreach (var obj in result.Brands)
                    {
                        graphics.DrawRectangle(new Pen(color),
                            new Rectangle(obj.Rectangle.X + Shared.StartX, obj.Rectangle.Y + Shared.StartY,
                                obj.Rectangle.W, obj.Rectangle.H));
                        var trans = resultTranslation.Where(x => x.Group == 0).ToList()
                            [result.Brands.IndexOf(obj)].translations[0].Text;
                        graphics.DrawString($"{obj.Name}\n{trans}", font, color, obj.Rectangle.X + Shared.StartX,
                            obj.Rectangle.Y + Shared.StartY);
                    }

                    //遍历物体
                    foreach (var obj in result.Objects)
                    {
                        graphics.DrawRectangle(new Pen(color),
                            new Rectangle(obj.Rectangle.X + Shared.StartX, obj.Rectangle.Y + Shared.StartY,
                                obj.Rectangle.W, obj.Rectangle.H));
                        var trans = resultTranslation.Where(x => x.Group == 1).ToList()
                            [result.Objects.IndexOf(obj)].translations[0].Text;
                        graphics.DrawString($"{obj.ObjectProperty}\n{trans}", font, color, obj.Rectangle.X + Shared.StartX,
                            obj.Rectangle.Y + Shared.StartY);
                    }

                    //遍历人脸
                    foreach (var obj in result.Faces)
                    {
                        graphics.DrawRectangle(new Pen(color),
                            new Rectangle(obj.FaceRectangle.Left + Shared.StartX, obj.FaceRectangle.Top + Shared.StartY,
                                obj.FaceRectangle.Width, obj.FaceRectangle.Height));
                        var trans = resultTranslation.Where(x => x.Group == 2).ToList()
                            [result.Faces.IndexOf(obj)].translations[0].Text;
                        graphics.DrawString($"{obj.Gender}-{obj.Age}\n{trans}", font, color,
                            obj.FaceRectangle.Left + Shared.StartX, obj.FaceRectangle.Top + Shared.StartY);
                        
                        //自动点击中心
                        if (!clickBox.Checked) return;
                        //移动 点击
                        var centerX = obj.FaceRectangle.Left + Shared.StartX + obj.FaceRectangle.Width / 2;
                        var centerY = obj.FaceRectangle.Top + Shared.StartY + obj.FaceRectangle.Height / 2;
                        mouse_event(MOUSEEVENTF_MOVE, centerX - MousePosition.X, centerY - MousePosition.Y, 0, 0);
                        mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                    }

                    graphics.Dispose();

                    Thread.Sleep((analyzeInterval.IntValue < analyzeInterval.Minimum
                        ? Convert.ToInt32(analyzeInterval.Minimum)
                        : analyzeInterval.IntValue) * 1000);
                }
                catch
                {
                    // ignored
                }
            }
        }

        private bool _runFinish = true;
        private Image _lastImage;
        private Image _image;

        /// <summary>
        /// 定时器操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void TimerOnElapsed(object sender, ElapsedEventArgs e)
        {
            if (!_runFinish) return;
            _runFinish = false;

            var size = new Size(Shared.EndX - Shared.StartX, Shared.EndY - Shared.StartY);
            //保存截取的图象
            _image = new Bitmap(size.Width, size.Height);
            var imgGraphics = Graphics.FromImage(_image);
            //设置截屏区域
            imgGraphics.CopyFromScreen(Shared.StartX, Shared.StartY, 0, 0, size);
            imgGraphics.Dispose();
            try
            {
                //释放上一张图片
                _lastImage?.Dispose();
                // 创建目录 保存
                if (!Directory.Exists(FilePath)) Directory.CreateDirectory(FilePath);
                _image.Save(FileName, ImageFormat.Png);
                Invoke(new Action(() => rawPicture.ImageLocation = FileName)); //显示
                _lastImage = _image; //记录当前图片
            }
            catch
            {
                // ignored
            }

            _runFinish = true;
        }
    }
}