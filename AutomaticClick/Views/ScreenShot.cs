using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using AutomaticClick.Utils;
using Timer = System.Timers.Timer;

namespace AutomaticClick.Views
{
    public partial class ScreenShot : BaseForm
    {
        [DllImport("user32")]
        private extern static IntPtr GetDC(IntPtr hWnd);

        public ScreenShot()
        {
            InitializeComponent();
            Load += (_, _) => { startX.Focus(); };
            var timer = new Timer(50);
            timer.Elapsed += (_, _) =>
            {
                try
                {
                    Invoke(new Action(() =>
                    {
                        currentX.Text = MousePosition.X.ToString();
                        currentY.Text = MousePosition.Y.ToString();
                    }));
                }
                catch
                {
                    // ignored
                }
            };
            timer.Start();
        }

        /// <summary>
        /// 获取屏幕
        /// </summary>
        private readonly Graphics _graphics = Graphics.FromHdc(GetDC(IntPtr.Zero));

        /// <summary>
        /// 正在选取
        /// </summary>
        private bool _shoting;

        /// <summary>
        /// 按键按下 开始选取
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startX_KeyDown(object sender, KeyEventArgs e)
        {
            if (!e.Alt) return;
            if (!_shoting)
            {
                //设置开始位置
                startX.IntValue = MousePosition.X;
                startY.IntValue = MousePosition.Y;
                //开始选取
                _shoting = true;
            }
            else
            {
                //设置结束位置
                endX.IntValue = MousePosition.X;
                endY.IntValue = MousePosition.Y;

                //刷新绘图
                Refresh();
                var x = startX.IntValue;
                var y = startY.IntValue;
                _graphics.DrawRectangle(new Pen(Color.Red),
                    new Rectangle(x, y, MousePosition.X - x, MousePosition.Y - y));
            }
        }

        /// <summary>
        /// 按键松开 结束选取
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startX_KeyUp(object sender, KeyEventArgs e)
        {
            if (!_shoting) return;
            _shoting = false;

            //保存区域
            Shared.StartX = startX.IntValue;
            Shared.StartY = startY.IntValue;
            Shared.EndX = endX.IntValue;
            Shared.EndY = endY.IntValue;

            if (Shared.StartX >= Shared.EndX || Shared.StartY >= Shared.EndY) return;

            //退出
            DialogResult = DialogResult.OK;
            Close();
            Dispose();
        }
    }
}