
namespace AutomaticClick.Views
{
    partial class ScreenShot
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
            this.controlPanel = new System.Windows.Forms.TableLayoutPanel();
            this.currentPos = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.mainContainer = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.currentY = new Sunny.UI.UILedLabel();
            this.uiLedLabel1 = new Sunny.UI.UILedLabel();
            this.uiLedLabel5 = new Sunny.UI.UILedLabel();
            this.uiLedLabel4 = new Sunny.UI.UILedLabel();
            this.uiLedLabel3 = new Sunny.UI.UILedLabel();
            this.uiLedLabel2 = new Sunny.UI.UILedLabel();
            this.uiLedLabel6 = new Sunny.UI.UILedLabel();
            this.startY = new Sunny.UI.UITextBox();
            this.currentX = new Sunny.UI.UILedLabel();
            this.endY = new Sunny.UI.UITextBox();
            this.endX = new Sunny.UI.UITextBox();
            this.startX = new Sunny.UI.UITextBox();
            this.uiLedLabel7 = new Sunny.UI.UILedLabel();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).BeginInit();
            this.mainContainer.Panel1.SuspendLayout();
            this.mainContainer.Panel2.SuspendLayout();
            this.mainContainer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlPanel
            // 
            this.controlPanel.ColumnCount = 6;
            this.controlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.controlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.controlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.controlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.controlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.controlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.controlPanel.Controls.Add(this.currentPos, 0, 1);
            this.controlPanel.Location = new System.Drawing.Point(0, 0);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.RowCount = 2;
            this.controlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.controlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.controlPanel.Size = new System.Drawing.Size(200, 100);
            this.controlPanel.TabIndex = 0;
            // 
            // currentPos
            // 
            this.currentPos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.currentPos.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currentPos.Location = new System.Drawing.Point(3, 48);
            this.currentPos.Name = "currentPos";
            this.currentPos.Size = new System.Drawing.Size(27, 23);
            this.currentPos.Style = Sunny.UI.UIStyle.Custom;
            this.currentPos.TabIndex = 2;
            this.currentPos.Text = "Position";
            this.currentPos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel1.Location = new System.Drawing.Point(3, 0);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(79, 23);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 3;
            this.uiLabel1.Text = "当前位置";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mainContainer
            // 
            this.mainContainer.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(0, 0);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mainContainer.Panel1
            // 
            this.mainContainer.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.mainContainer.Panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            // 
            // mainContainer.Panel2
            // 
            this.mainContainer.Panel2.Controls.Add(this.uiLedLabel7);
            this.mainContainer.Panel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.mainContainer.Size = new System.Drawing.Size(800, 450);
            this.mainContainer.SplitterDistance = 82;
            this.mainContainer.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28482F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28483F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28483F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28483F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28483F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28769F));
            this.tableLayoutPanel1.Controls.Add(this.currentY, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.uiLedLabel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.uiLedLabel5, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.uiLedLabel4, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.uiLedLabel3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.uiLedLabel2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.uiLedLabel6, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.startY, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.currentX, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.endY, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.endX, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.startX, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 82);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // currentY
            // 
            this.currentY.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.currentY.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currentY.ForeColor = System.Drawing.Color.Red;
            this.currentY.Location = new System.Drawing.Point(145, 44);
            this.currentY.MinimumSize = new System.Drawing.Size(1, 1);
            this.currentY.Name = "currentY";
            this.currentY.Size = new System.Drawing.Size(108, 35);
            this.currentY.Style = Sunny.UI.UIStyle.Custom;
            this.currentY.TabIndex = 30;
            // 
            // uiLedLabel1
            // 
            this.uiLedLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uiLedLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLedLabel1.ForeColor = System.Drawing.Color.Red;
            this.uiLedLabel1.Location = new System.Drawing.Point(12, 3);
            this.uiLedLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLedLabel1.Name = "uiLedLabel1";
            this.uiLedLabel1.Size = new System.Drawing.Size(108, 35);
            this.uiLedLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLedLabel1.TabIndex = 12;
            this.uiLedLabel1.Text = "X";
            // 
            // uiLedLabel5
            // 
            this.uiLedLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uiLedLabel5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLedLabel5.ForeColor = System.Drawing.Color.Red;
            this.uiLedLabel5.Location = new System.Drawing.Point(678, 3);
            this.uiLedLabel5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLedLabel5.Name = "uiLedLabel5";
            this.uiLedLabel5.Size = new System.Drawing.Size(108, 35);
            this.uiLedLabel5.Style = Sunny.UI.UIStyle.Custom;
            this.uiLedLabel5.TabIndex = 16;
            this.uiLedLabel5.Text = "EndY";
            // 
            // uiLedLabel4
            // 
            this.uiLedLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uiLedLabel4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLedLabel4.ForeColor = System.Drawing.Color.Red;
            this.uiLedLabel4.Location = new System.Drawing.Point(544, 3);
            this.uiLedLabel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLedLabel4.Name = "uiLedLabel4";
            this.uiLedLabel4.Size = new System.Drawing.Size(108, 35);
            this.uiLedLabel4.Style = Sunny.UI.UIStyle.Custom;
            this.uiLedLabel4.TabIndex = 15;
            this.uiLedLabel4.Text = "EndX";
            // 
            // uiLedLabel3
            // 
            this.uiLedLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uiLedLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLedLabel3.ForeColor = System.Drawing.Color.Red;
            this.uiLedLabel3.Location = new System.Drawing.Point(411, 3);
            this.uiLedLabel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLedLabel3.Name = "uiLedLabel3";
            this.uiLedLabel3.Size = new System.Drawing.Size(108, 35);
            this.uiLedLabel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiLedLabel3.TabIndex = 14;
            this.uiLedLabel3.Text = "StartY";
            // 
            // uiLedLabel2
            // 
            this.uiLedLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uiLedLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLedLabel2.ForeColor = System.Drawing.Color.Red;
            this.uiLedLabel2.Location = new System.Drawing.Point(278, 3);
            this.uiLedLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLedLabel2.Name = "uiLedLabel2";
            this.uiLedLabel2.Size = new System.Drawing.Size(108, 35);
            this.uiLedLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLedLabel2.TabIndex = 13;
            this.uiLedLabel2.Text = "StartX";
            // 
            // uiLedLabel6
            // 
            this.uiLedLabel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uiLedLabel6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLedLabel6.ForeColor = System.Drawing.Color.Red;
            this.uiLedLabel6.Location = new System.Drawing.Point(145, 3);
            this.uiLedLabel6.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLedLabel6.Name = "uiLedLabel6";
            this.uiLedLabel6.Size = new System.Drawing.Size(108, 35);
            this.uiLedLabel6.Style = Sunny.UI.UIStyle.Custom;
            this.uiLedLabel6.TabIndex = 22;
            this.uiLedLabel6.Text = "Y";
            // 
            // startY
            // 
            this.startY.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startY.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.startY.FillColor = System.Drawing.Color.White;
            this.startY.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startY.Location = new System.Drawing.Point(412, 47);
            this.startY.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.startY.Maximum = 2147483647D;
            this.startY.Minimum = -2147483648D;
            this.startY.MinimumSize = new System.Drawing.Size(1, 1);
            this.startY.Name = "startY";
            this.startY.Size = new System.Drawing.Size(106, 29);
            this.startY.TabIndex = 26;
            this.startY.Text = "0";
            this.startY.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.startY.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            // 
            // currentX
            // 
            this.currentX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.currentX.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currentX.ForeColor = System.Drawing.Color.Red;
            this.currentX.Location = new System.Drawing.Point(12, 44);
            this.currentX.MinimumSize = new System.Drawing.Size(1, 1);
            this.currentX.Name = "currentX";
            this.currentX.Size = new System.Drawing.Size(108, 35);
            this.currentX.Style = Sunny.UI.UIStyle.Custom;
            this.currentX.TabIndex = 21;
            // 
            // endY
            // 
            this.endY.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.endY.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.endY.FillColor = System.Drawing.Color.White;
            this.endY.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.endY.Location = new System.Drawing.Point(679, 47);
            this.endY.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.endY.Maximum = 2147483647D;
            this.endY.Minimum = -2147483648D;
            this.endY.MinimumSize = new System.Drawing.Size(1, 1);
            this.endY.Name = "endY";
            this.endY.Size = new System.Drawing.Size(106, 29);
            this.endY.Style = Sunny.UI.UIStyle.Custom;
            this.endY.TabIndex = 28;
            this.endY.Text = "0";
            this.endY.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.endY.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            // 
            // endX
            // 
            this.endX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.endX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.endX.FillColor = System.Drawing.Color.White;
            this.endX.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.endX.Location = new System.Drawing.Point(545, 47);
            this.endX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.endX.Maximum = 2147483647D;
            this.endX.Minimum = -2147483648D;
            this.endX.MinimumSize = new System.Drawing.Size(1, 1);
            this.endX.Name = "endX";
            this.endX.Size = new System.Drawing.Size(106, 29);
            this.endX.TabIndex = 29;
            this.endX.Text = "0";
            this.endX.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.endX.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            // 
            // startX
            // 
            this.startX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.startX.FillColor = System.Drawing.Color.White;
            this.startX.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startX.Location = new System.Drawing.Point(279, 47);
            this.startX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.startX.Maximum = 2147483647D;
            this.startX.Minimum = -2147483648D;
            this.startX.MinimumSize = new System.Drawing.Size(1, 1);
            this.startX.Name = "startX";
            this.startX.Size = new System.Drawing.Size(106, 29);
            this.startX.TabIndex = 25;
            this.startX.Text = "0";
            this.startX.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.startX.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            this.startX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.startX_KeyDown);
            this.startX.KeyUp += new System.Windows.Forms.KeyEventHandler(this.startX_KeyUp);
            // 
            // uiLedLabel7
            // 
            this.uiLedLabel7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLedLabel7.ForeColor = System.Drawing.Color.Red;
            this.uiLedLabel7.Location = new System.Drawing.Point(12, 3);
            this.uiLedLabel7.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLedLabel7.Name = "uiLedLabel7";
            this.uiLedLabel7.Size = new System.Drawing.Size(357, 35);
            this.uiLedLabel7.Style = Sunny.UI.UIStyle.Custom;
            this.uiLedLabel7.TabIndex = 14;
            this.uiLedLabel7.Text = "Hold Alt to capture";
            // 
            // ScreenShot
            // 
            this.AllowShowTitle = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainContainer);
            this.Name = "ScreenShot";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.ShowTitle = false;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "Screen";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.controlPanel.ResumeLayout(false);
            this.mainContainer.Panel1.ResumeLayout(false);
            this.mainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).EndInit();
            this.mainContainer.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel controlPanel;
        private Sunny.UI.UILabel currentPos;
        private Sunny.UI.UILabel uiLabel1;
        private System.Windows.Forms.SplitContainer mainContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Sunny.UI.UILedLabel uiLedLabel5;
        private Sunny.UI.UILedLabel uiLedLabel4;
        private Sunny.UI.UILedLabel uiLedLabel3;
        private Sunny.UI.UILedLabel uiLedLabel2;
        private Sunny.UI.UILedLabel uiLedLabel1;
        private Sunny.UI.UILedLabel uiLedLabel6;
        private Sunny.UI.UITextBox startX;
        private Sunny.UI.UITextBox startY;
        private Sunny.UI.UITextBox endY;
        private Sunny.UI.UITextBox endX;
        private Sunny.UI.UILedLabel currentY;
        private Sunny.UI.UILedLabel currentX;
        private Sunny.UI.UILedLabel uiLedLabel7;
    }
}