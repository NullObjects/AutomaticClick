
namespace AutomaticClick.Views
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainContainer = new System.Windows.Forms.SplitContainer();
            this.controlPanel = new System.Windows.Forms.TableLayoutPanel();
            this.uiLedLabel4 = new Sunny.UI.UILedLabel();
            this.uiLedLabel3 = new Sunny.UI.UILedLabel();
            this.uiLedLabel2 = new Sunny.UI.UILedLabel();
            this.uiLedLabel1 = new Sunny.UI.UILedLabel();
            this.screenInterval = new Sunny.UI.UITextBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.analyzeInterval = new Sunny.UI.UITextBox();
            this.startX = new Sunny.UI.UILedLabel();
            this.startY = new Sunny.UI.UILedLabel();
            this.endX = new Sunny.UI.UILedLabel();
            this.endY = new Sunny.UI.UILedLabel();
            this.screen = new Sunny.UI.UIButton();
            this.MiniBox = new Sunny.UI.UICheckBox();
            this.ocrBox = new Sunny.UI.UICheckBox();
            this.analyzeBox = new Sunny.UI.UICheckBox();
            this.clickBox = new Sunny.UI.UICheckBox();
            this.mainTabControl = new Sunny.UI.UITabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rawPicture = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ocrItems = new Sunny.UI.UIDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).BeginInit();
            this.mainContainer.Panel1.SuspendLayout();
            this.mainContainer.Panel2.SuspendLayout();
            this.mainContainer.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rawPicture)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ocrItems)).BeginInit();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(0, 35);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mainContainer.Panel1
            // 
            this.mainContainer.Panel1.Controls.Add(this.controlPanel);
            this.mainContainer.Panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            // 
            // mainContainer.Panel2
            // 
            this.mainContainer.Panel2.Controls.Add(this.mainTabControl);
            this.mainContainer.Size = new System.Drawing.Size(800, 415);
            this.mainContainer.SplitterDistance = 75;
            this.mainContainer.TabIndex = 1;
            // 
            // controlPanel
            // 
            this.controlPanel.ColumnCount = 9;
            this.controlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.61933F));
            this.controlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.61933F));
            this.controlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.61933F));
            this.controlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.61933F));
            this.controlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.103429F));
            this.controlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.103429F));
            this.controlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.105247F));
            this.controlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.103165F));
            this.controlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.107438F));
            this.controlPanel.Controls.Add(this.uiLedLabel4, 3, 0);
            this.controlPanel.Controls.Add(this.uiLedLabel3, 2, 0);
            this.controlPanel.Controls.Add(this.uiLedLabel2, 1, 0);
            this.controlPanel.Controls.Add(this.uiLedLabel1, 0, 0);
            this.controlPanel.Controls.Add(this.screenInterval, 4, 1);
            this.controlPanel.Controls.Add(this.uiLabel1, 4, 0);
            this.controlPanel.Controls.Add(this.uiLabel2, 5, 0);
            this.controlPanel.Controls.Add(this.analyzeInterval, 5, 1);
            this.controlPanel.Controls.Add(this.startX, 0, 1);
            this.controlPanel.Controls.Add(this.startY, 1, 1);
            this.controlPanel.Controls.Add(this.endX, 2, 1);
            this.controlPanel.Controls.Add(this.endY, 3, 1);
            this.controlPanel.Controls.Add(this.screen, 8, 0);
            this.controlPanel.Controls.Add(this.MiniBox, 8, 1);
            this.controlPanel.Controls.Add(this.ocrBox, 6, 0);
            this.controlPanel.Controls.Add(this.analyzeBox, 6, 1);
            this.controlPanel.Controls.Add(this.clickBox, 7, 1);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlPanel.Location = new System.Drawing.Point(0, 0);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.RowCount = 2;
            this.controlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.controlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.controlPanel.Size = new System.Drawing.Size(800, 75);
            this.controlPanel.TabIndex = 0;
            // 
            // uiLedLabel4
            // 
            this.uiLedLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uiLedLabel4.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLedLabel4.ForeColor = System.Drawing.Color.Red;
            this.uiLedLabel4.Location = new System.Drawing.Point(327, 6);
            this.uiLedLabel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLedLabel4.Name = "uiLedLabel4";
            this.uiLedLabel4.Size = new System.Drawing.Size(102, 24);
            this.uiLedLabel4.Style = Sunny.UI.UIStyle.Custom;
            this.uiLedLabel4.TabIndex = 42;
            this.uiLedLabel4.Text = "EndY";
            // 
            // uiLedLabel3
            // 
            this.uiLedLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uiLedLabel3.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLedLabel3.ForeColor = System.Drawing.Color.Red;
            this.uiLedLabel3.Location = new System.Drawing.Point(219, 6);
            this.uiLedLabel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLedLabel3.Name = "uiLedLabel3";
            this.uiLedLabel3.Size = new System.Drawing.Size(102, 24);
            this.uiLedLabel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiLedLabel3.TabIndex = 41;
            this.uiLedLabel3.Text = "EndX";
            // 
            // uiLedLabel2
            // 
            this.uiLedLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uiLedLabel2.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLedLabel2.ForeColor = System.Drawing.Color.Red;
            this.uiLedLabel2.Location = new System.Drawing.Point(111, 6);
            this.uiLedLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLedLabel2.Name = "uiLedLabel2";
            this.uiLedLabel2.Size = new System.Drawing.Size(102, 24);
            this.uiLedLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLedLabel2.TabIndex = 40;
            this.uiLedLabel2.Text = "StartY";
            // 
            // uiLedLabel1
            // 
            this.uiLedLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uiLedLabel1.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLedLabel1.ForeColor = System.Drawing.Color.Red;
            this.uiLedLabel1.Location = new System.Drawing.Point(3, 6);
            this.uiLedLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLedLabel1.Name = "uiLedLabel1";
            this.uiLedLabel1.Size = new System.Drawing.Size(102, 24);
            this.uiLedLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLedLabel1.TabIndex = 39;
            this.uiLedLabel1.Text = "StartX";
            // 
            // screenInterval
            // 
            this.screenInterval.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.screenInterval.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.screenInterval.DoubleValue = 200D;
            this.screenInterval.FillColor = System.Drawing.Color.White;
            this.screenInterval.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.screenInterval.IntValue = 200;
            this.screenInterval.Location = new System.Drawing.Point(436, 42);
            this.screenInterval.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.screenInterval.Maximum = 2147483647D;
            this.screenInterval.Minimum = 200D;
            this.screenInterval.MinimumSize = new System.Drawing.Size(1, 1);
            this.screenInterval.Name = "screenInterval";
            this.screenInterval.Size = new System.Drawing.Size(64, 29);
            this.screenInterval.TabIndex = 26;
            this.screenInterval.Text = "200";
            this.screenInterval.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.screenInterval.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel1.Location = new System.Drawing.Point(435, 7);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(66, 23);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 2;
            this.uiLabel1.Text = "截屏(ms)";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel2.Location = new System.Drawing.Point(507, 7);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(66, 23);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel2.TabIndex = 36;
            this.uiLabel2.Text = "Azure(s)";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // analyzeInterval
            // 
            this.analyzeInterval.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.analyzeInterval.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.analyzeInterval.DoubleValue = 10D;
            this.analyzeInterval.FillColor = System.Drawing.Color.White;
            this.analyzeInterval.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.analyzeInterval.IntValue = 10;
            this.analyzeInterval.Location = new System.Drawing.Point(508, 42);
            this.analyzeInterval.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.analyzeInterval.Maximum = 2147483647D;
            this.analyzeInterval.Minimum = 5D;
            this.analyzeInterval.MinimumSize = new System.Drawing.Size(1, 1);
            this.analyzeInterval.Name = "analyzeInterval";
            this.analyzeInterval.Size = new System.Drawing.Size(64, 29);
            this.analyzeInterval.TabIndex = 37;
            this.analyzeInterval.Text = "10";
            this.analyzeInterval.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.analyzeInterval.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            // 
            // startX
            // 
            this.startX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startX.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startX.ForeColor = System.Drawing.Color.Red;
            this.startX.Location = new System.Drawing.Point(3, 44);
            this.startX.MinimumSize = new System.Drawing.Size(1, 1);
            this.startX.Name = "startX";
            this.startX.Size = new System.Drawing.Size(102, 24);
            this.startX.Style = Sunny.UI.UIStyle.Custom;
            this.startX.TabIndex = 31;
            this.startX.Text = "0";
            // 
            // startY
            // 
            this.startY.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startY.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startY.ForeColor = System.Drawing.Color.Red;
            this.startY.Location = new System.Drawing.Point(111, 44);
            this.startY.MinimumSize = new System.Drawing.Size(1, 1);
            this.startY.Name = "startY";
            this.startY.Size = new System.Drawing.Size(102, 24);
            this.startY.Style = Sunny.UI.UIStyle.Custom;
            this.startY.TabIndex = 32;
            this.startY.Text = "0";
            // 
            // endX
            // 
            this.endX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.endX.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.endX.ForeColor = System.Drawing.Color.Red;
            this.endX.Location = new System.Drawing.Point(219, 44);
            this.endX.MinimumSize = new System.Drawing.Size(1, 1);
            this.endX.Name = "endX";
            this.endX.Size = new System.Drawing.Size(102, 24);
            this.endX.Style = Sunny.UI.UIStyle.Custom;
            this.endX.TabIndex = 33;
            this.endX.Text = "0";
            // 
            // endY
            // 
            this.endY.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.endY.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.endY.ForeColor = System.Drawing.Color.Red;
            this.endY.Location = new System.Drawing.Point(327, 44);
            this.endY.MinimumSize = new System.Drawing.Size(1, 1);
            this.endY.Name = "endY";
            this.endY.Size = new System.Drawing.Size(102, 24);
            this.endY.Style = Sunny.UI.UIStyle.Custom;
            this.endY.TabIndex = 34;
            this.endY.Text = "0";
            // 
            // screen
            // 
            this.screen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.screen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.screen.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.screen.Location = new System.Drawing.Point(723, 3);
            this.screen.MinimumSize = new System.Drawing.Size(1, 1);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(74, 31);
            this.screen.TabIndex = 44;
            this.screen.Text = "重新选择";
            this.screen.Click += new System.EventHandler(this.screen_Click);
            // 
            // MiniBox
            // 
            this.MiniBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MiniBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MiniBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MiniBox.Location = new System.Drawing.Point(723, 44);
            this.MiniBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.MiniBox.Name = "MiniBox";
            this.MiniBox.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.MiniBox.Size = new System.Drawing.Size(74, 24);
            this.MiniBox.TabIndex = 43;
            this.MiniBox.Text = "Mini";
            this.MiniBox.CheckedChanged += new System.EventHandler(this.MiniBox_CheckedChanged);
            // 
            // ocrBox
            // 
            this.ocrBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ocrBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ocrBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ocrBox.Location = new System.Drawing.Point(579, 6);
            this.ocrBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.ocrBox.Name = "ocrBox";
            this.ocrBox.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.ocrBox.Size = new System.Drawing.Size(66, 24);
            this.ocrBox.TabIndex = 35;
            this.ocrBox.Text = "OCR";
            // 
            // analyzeBox
            // 
            this.analyzeBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.analyzeBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.analyzeBox.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.analyzeBox.Location = new System.Drawing.Point(579, 44);
            this.analyzeBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.analyzeBox.Name = "analyzeBox";
            this.analyzeBox.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.analyzeBox.Size = new System.Drawing.Size(66, 24);
            this.analyzeBox.TabIndex = 45;
            this.analyzeBox.Text = "Analyze";
            // 
            // clickBox
            // 
            this.clickBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clickBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clickBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clickBox.Location = new System.Drawing.Point(651, 44);
            this.clickBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.clickBox.Name = "clickBox";
            this.clickBox.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.clickBox.Size = new System.Drawing.Size(66, 24);
            this.clickBox.TabIndex = 38;
            this.clickBox.Text = "Click";
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.tabPage1);
            this.mainTabControl.Controls.Add(this.tabPage2);
            this.mainTabControl.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.mainTabControl.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mainTabControl.ItemSize = new System.Drawing.Size(150, 40);
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.MainPage = "";
            this.mainTabControl.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(800, 336);
            this.mainTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.mainTabControl.Style = Sunny.UI.UIStyle.Custom;
            this.mainTabControl.TabIndex = 3;
            this.mainTabControl.TabUnSelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rawPicture);
            this.tabPage1.Location = new System.Drawing.Point(0, 40);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(800, 296);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Image";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rawPicture
            // 
            this.rawPicture.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rawPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rawPicture.Location = new System.Drawing.Point(0, 0);
            this.rawPicture.Name = "rawPicture";
            this.rawPicture.Size = new System.Drawing.Size(800, 296);
            this.rawPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rawPicture.TabIndex = 0;
            this.rawPicture.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ocrItems);
            this.tabPage2.Location = new System.Drawing.Point(0, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(800, 296);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ocr";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ocrItems
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ocrItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ocrItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ocrItems.BackgroundColor = System.Drawing.Color.White;
            this.ocrItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ocrItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ocrItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ocrItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ocrItems.EnableHeadersVisualStyles = false;
            this.ocrItems.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ocrItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.ocrItems.Location = new System.Drawing.Point(0, 0);
            this.ocrItems.Name = "ocrItems";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ocrItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ocrItems.RowHeight = 25;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.ocrItems.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ocrItems.RowTemplate.Height = 25;
            this.ocrItems.SelectedIndex = -1;
            this.ocrItems.ShowGridLine = true;
            this.ocrItems.Size = new System.Drawing.Size(800, 296);
            this.ocrItems.Style = Sunny.UI.UIStyle.Custom;
            this.ocrItems.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainContainer);
            this.Name = "Main";
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "Main";
            this.mainContainer.Panel1.ResumeLayout(false);
            this.mainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).EndInit();
            this.mainContainer.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            this.mainTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rawPicture)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ocrItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer mainContainer;
        private System.Windows.Forms.PictureBox rawPicture;
        private System.Windows.Forms.TableLayoutPanel controlPanel;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox screenInterval;
        private Sunny.UI.UILedLabel startY;
        private Sunny.UI.UILedLabel startX;
        private Sunny.UI.UILedLabel endY;
        private Sunny.UI.UILedLabel endX;
        private Sunny.UI.UICheckBox ocrBox;
        private Sunny.UI.UITabControl mainTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Sunny.UI.UIDataGridView ocrItems;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox analyzeInterval;
        private Sunny.UI.UICheckBox clickBox;
        private Sunny.UI.UILedLabel uiLedLabel4;
        private Sunny.UI.UILedLabel uiLedLabel3;
        private Sunny.UI.UILedLabel uiLedLabel2;
        private Sunny.UI.UILedLabel uiLedLabel1;
        private Sunny.UI.UICheckBox MiniBox;
        private Sunny.UI.UIButton screen;
        private Sunny.UI.UICheckBox analyzeBox;
    }
}