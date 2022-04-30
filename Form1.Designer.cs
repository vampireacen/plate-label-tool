
namespace License_Plate
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PlatePathButton = new System.Windows.Forms.Button();
            this.PlatePathText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.JumpButton = new System.Windows.Forms.Button();
            this.NumberText = new System.Windows.Forms.TextBox();
            this.FilePathButton = new System.Windows.Forms.Button();
            this.ImagePathButton = new System.Windows.Forms.Button();
            this.ResultButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.FilePathText = new System.Windows.Forms.TextBox();
            this.ImagePathText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.LabelRegion = new System.Windows.Forms.GroupBox();
            this.UnclearButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.CopyButton = new System.Windows.Forms.Button();
            this.LeastPlateText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.NextPlateButton = new System.Windows.Forms.Button();
            this.PrePlateButton = new System.Windows.Forms.Button();
            this.PlateText = new System.Windows.Forms.TextBox();
            this.PlatePictrueBox = new System.Windows.Forms.PictureBox();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.NextImageButton = new System.Windows.Forms.Button();
            this.PreImgaeButton = new System.Windows.Forms.Button();
            this.图片区 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.LabelRegion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlatePictrueBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.图片区.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PlatePathButton);
            this.groupBox1.Controls.Add(this.PlatePathText);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.JumpButton);
            this.groupBox1.Controls.Add(this.NumberText);
            this.groupBox1.Controls.Add(this.FilePathButton);
            this.groupBox1.Controls.Add(this.ImagePathButton);
            this.groupBox1.Controls.Add(this.ResultButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.FilePathText);
            this.groupBox1.Controls.Add(this.ImagePathText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1088, 130);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "文件区";
            // 
            // PlatePathButton
            // 
            this.PlatePathButton.Location = new System.Drawing.Point(679, 71);
            this.PlatePathButton.Name = "PlatePathButton";
            this.PlatePathButton.Size = new System.Drawing.Size(114, 23);
            this.PlatePathButton.TabIndex = 12;
            this.PlatePathButton.Text = "选择车牌文件路径";
            this.PlatePathButton.UseVisualStyleBackColor = true;
            this.PlatePathButton.Click += new System.EventHandler(this.PlatePathButton_Click);
            // 
            // PlatePathText
            // 
            this.PlatePathText.Location = new System.Drawing.Point(70, 73);
            this.PlatePathText.Name = "PlatePathText";
            this.PlatePathText.ReadOnly = true;
            this.PlatePathText.Size = new System.Drawing.Size(603, 21);
            this.PlatePathText.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "车牌路径：";
            // 
            // JumpButton
            // 
            this.JumpButton.Location = new System.Drawing.Point(171, 97);
            this.JumpButton.Name = "JumpButton";
            this.JumpButton.Size = new System.Drawing.Size(75, 23);
            this.JumpButton.TabIndex = 9;
            this.JumpButton.Text = "跳转";
            this.JumpButton.UseVisualStyleBackColor = true;
            this.JumpButton.Click += new System.EventHandler(this.JumpButton_Click);
            // 
            // NumberText
            // 
            this.NumberText.Location = new System.Drawing.Point(110, 97);
            this.NumberText.Name = "NumberText";
            this.NumberText.Size = new System.Drawing.Size(44, 21);
            this.NumberText.TabIndex = 8;
            // 
            // FilePathButton
            // 
            this.FilePathButton.Location = new System.Drawing.Point(679, 42);
            this.FilePathButton.Name = "FilePathButton";
            this.FilePathButton.Size = new System.Drawing.Size(114, 23);
            this.FilePathButton.TabIndex = 7;
            this.FilePathButton.Text = "选择标注文件路径";
            this.FilePathButton.UseVisualStyleBackColor = true;
            this.FilePathButton.Click += new System.EventHandler(this.FilePathButton_Click);
            // 
            // ImagePathButton
            // 
            this.ImagePathButton.Location = new System.Drawing.Point(679, 14);
            this.ImagePathButton.Name = "ImagePathButton";
            this.ImagePathButton.Size = new System.Drawing.Size(114, 23);
            this.ImagePathButton.TabIndex = 6;
            this.ImagePathButton.Text = "选择图片路径";
            this.ImagePathButton.UseVisualStyleBackColor = true;
            this.ImagePathButton.Click += new System.EventHandler(this.ImagePathButton_Click);
            // 
            // ResultButton
            // 
            this.ResultButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultButton.Location = new System.Drawing.Point(936, 42);
            this.ResultButton.Name = "ResultButton";
            this.ResultButton.Size = new System.Drawing.Size(146, 23);
            this.ResultButton.TabIndex = 5;
            this.ResultButton.Text = "保存文件结果(Ctrl+S)";
            this.ResultButton.UseVisualStyleBackColor = true;
            this.ResultButton.Click += new System.EventHandler(this.ResultButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "图片标号（0开始）";
            // 
            // FilePathText
            // 
            this.FilePathText.Location = new System.Drawing.Point(70, 46);
            this.FilePathText.Name = "FilePathText";
            this.FilePathText.ReadOnly = true;
            this.FilePathText.Size = new System.Drawing.Size(603, 21);
            this.FilePathText.TabIndex = 3;
            // 
            // ImagePathText
            // 
            this.ImagePathText.Location = new System.Drawing.Point(70, 15);
            this.ImagePathText.Name = "ImagePathText";
            this.ImagePathText.ReadOnly = true;
            this.ImagePathText.Size = new System.Drawing.Size(603, 21);
            this.ImagePathText.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "文件路径：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "图片路径：";
            // 
            // PictureBox
            // 
            this.PictureBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBox.Location = new System.Drawing.Point(3, 17);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(858, 544);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 1;
            this.PictureBox.TabStop = false;
            // 
            // LabelRegion
            // 
            this.LabelRegion.Controls.Add(this.UnclearButton);
            this.LabelRegion.Controls.Add(this.label6);
            this.LabelRegion.Controls.Add(this.CopyButton);
            this.LabelRegion.Controls.Add(this.LeastPlateText);
            this.LabelRegion.Controls.Add(this.label5);
            this.LabelRegion.Controls.Add(this.ClearButton);
            this.LabelRegion.Controls.Add(this.SaveButton);
            this.LabelRegion.Controls.Add(this.NextPlateButton);
            this.LabelRegion.Controls.Add(this.PrePlateButton);
            this.LabelRegion.Controls.Add(this.PlateText);
            this.LabelRegion.Controls.Add(this.PlatePictrueBox);
            this.LabelRegion.Controls.Add(this.DataGridView);
            this.LabelRegion.Controls.Add(this.NextImageButton);
            this.LabelRegion.Controls.Add(this.PreImgaeButton);
            this.LabelRegion.Dock = System.Windows.Forms.DockStyle.Right;
            this.LabelRegion.Location = new System.Drawing.Point(864, 130);
            this.LabelRegion.Name = "LabelRegion";
            this.LabelRegion.Size = new System.Drawing.Size(224, 564);
            this.LabelRegion.TabIndex = 2;
            this.LabelRegion.TabStop = false;
            this.LabelRegion.Text = "标注区";
            // 
            // UnclearButton
            // 
            this.UnclearButton.Location = new System.Drawing.Point(6, 487);
            this.UnclearButton.Name = "UnclearButton";
            this.UnclearButton.Size = new System.Drawing.Size(212, 23);
            this.UnclearButton.TabIndex = 13;
            this.UnclearButton.Text = "车牌不清晰(Ctrl+U)";
            this.UnclearButton.UseVisualStyleBackColor = true;
            this.UnclearButton.Click += new System.EventHandler(this.UnclearButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "请输入车牌：";
            // 
            // CopyButton
            // 
            this.CopyButton.Location = new System.Drawing.Point(6, 429);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(212, 23);
            this.CopyButton.TabIndex = 11;
            this.CopyButton.Text = "复制(Ctrl+Q)";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // LeastPlateText
            // 
            this.LeastPlateText.Location = new System.Drawing.Point(6, 360);
            this.LeastPlateText.Name = "LeastPlateText";
            this.LeastPlateText.Size = new System.Drawing.Size(212, 21);
            this.LeastPlateText.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "上一次输入车牌：";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(6, 458);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(212, 23);
            this.ClearButton.TabIndex = 8;
            this.ClearButton.Text = "清除(Ctrl+E)";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(6, 516);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(212, 23);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "暂存(ENTER)";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // NextPlateButton
            // 
            this.NextPlateButton.Enabled = false;
            this.NextPlateButton.Location = new System.Drawing.Point(124, 224);
            this.NextPlateButton.Name = "NextPlateButton";
            this.NextPlateButton.Size = new System.Drawing.Size(94, 23);
            this.NextPlateButton.TabIndex = 6;
            this.NextPlateButton.Text = "下一张车牌(C)";
            this.NextPlateButton.UseVisualStyleBackColor = true;
            this.NextPlateButton.Click += new System.EventHandler(this.NextPlateButton_Click);
            // 
            // PrePlateButton
            // 
            this.PrePlateButton.Enabled = false;
            this.PrePlateButton.Location = new System.Drawing.Point(6, 224);
            this.PrePlateButton.Name = "PrePlateButton";
            this.PrePlateButton.Size = new System.Drawing.Size(98, 23);
            this.PrePlateButton.TabIndex = 5;
            this.PrePlateButton.Text = "上一张车牌(Z)";
            this.PrePlateButton.UseVisualStyleBackColor = true;
            this.PrePlateButton.Click += new System.EventHandler(this.PrePlateButton_Click);
            // 
            // PlateText
            // 
            this.PlateText.Location = new System.Drawing.Point(6, 402);
            this.PlateText.Name = "PlateText";
            this.PlateText.Size = new System.Drawing.Size(212, 21);
            this.PlateText.TabIndex = 4;
            // 
            // PlatePictrueBox
            // 
            this.PlatePictrueBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlatePictrueBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.PlatePictrueBox.Location = new System.Drawing.Point(37, 253);
            this.PlatePictrueBox.Name = "PlatePictrueBox";
            this.PlatePictrueBox.Size = new System.Drawing.Size(155, 89);
            this.PlatePictrueBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PlatePictrueBox.TabIndex = 3;
            this.PlatePictrueBox.TabStop = false;
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(6, 58);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.ReadOnly = true;
            this.DataGridView.RowTemplate.Height = 23;
            this.DataGridView.Size = new System.Drawing.Size(212, 150);
            this.DataGridView.TabIndex = 2;
            // 
            // NextImageButton
            // 
            this.NextImageButton.Location = new System.Drawing.Point(124, 20);
            this.NextImageButton.Name = "NextImageButton";
            this.NextImageButton.Size = new System.Drawing.Size(94, 23);
            this.NextImageButton.TabIndex = 1;
            this.NextImageButton.Text = "下一张图片(D)";
            this.NextImageButton.UseVisualStyleBackColor = true;
            this.NextImageButton.Click += new System.EventHandler(this.NextImageButton_Click);
            // 
            // PreImgaeButton
            // 
            this.PreImgaeButton.Location = new System.Drawing.Point(7, 20);
            this.PreImgaeButton.Name = "PreImgaeButton";
            this.PreImgaeButton.Size = new System.Drawing.Size(98, 23);
            this.PreImgaeButton.TabIndex = 0;
            this.PreImgaeButton.Text = "上一张图片(A)";
            this.PreImgaeButton.UseVisualStyleBackColor = true;
            this.PreImgaeButton.Click += new System.EventHandler(this.PreImgaeButton_Click);
            // 
            // 图片区
            // 
            this.图片区.Controls.Add(this.PictureBox);
            this.图片区.Dock = System.Windows.Forms.DockStyle.Fill;
            this.图片区.Location = new System.Drawing.Point(0, 130);
            this.图片区.Name = "图片区";
            this.图片区.Size = new System.Drawing.Size(864, 564);
            this.图片区.TabIndex = 3;
            this.图片区.TabStop = false;
            this.图片区.Text = "图片区";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 694);
            this.Controls.Add(this.图片区);
            this.Controls.Add(this.LabelRegion);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "License Plate designed by 陈锋";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.LabelRegion.ResumeLayout(false);
            this.LabelRegion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlatePictrueBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.图片区.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox FilePathText;
        private System.Windows.Forms.TextBox ImagePathText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ResultButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.GroupBox LabelRegion;
        private System.Windows.Forms.Button FilePathButton;
        private System.Windows.Forms.Button ImagePathButton;
        private System.Windows.Forms.Button JumpButton;
        private System.Windows.Forms.TextBox NumberText;
        private System.Windows.Forms.Button NextImageButton;
        private System.Windows.Forms.Button PreImgaeButton;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.PictureBox PlatePictrueBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button NextPlateButton;
        private System.Windows.Forms.Button PrePlateButton;
        private System.Windows.Forms.TextBox PlateText;
        private System.Windows.Forms.Button PlatePathButton;
        private System.Windows.Forms.TextBox PlatePathText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.TextBox LeastPlateText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox 图片区;
        private System.Windows.Forms.Button UnclearButton;
    }
}

