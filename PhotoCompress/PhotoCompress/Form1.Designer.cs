namespace PhotoCompress
{
    partial class frmMain
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkRotate = new System.Windows.Forms.CheckBox();
            this.btn_Begin = new System.Windows.Forms.Button();
            this.chkPadding = new System.Windows.Forms.CheckBox();
            this.chkDefault = new System.Windows.Forms.CheckBox();
            this.btnViewForder = new System.Windows.Forms.Button();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtQuality = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOutPutDir = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtWorkDir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtxtLog = new System.Windows.Forms.RichTextBox();
            this.btnViewOut = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkRotate);
            this.groupBox1.Controls.Add(this.btn_Begin);
            this.groupBox1.Controls.Add(this.chkPadding);
            this.groupBox1.Controls.Add(this.chkDefault);
            this.groupBox1.Controls.Add(this.btnViewOut);
            this.groupBox1.Controls.Add(this.btnViewForder);
            this.groupBox1.Controls.Add(this.txtHeight);
            this.groupBox1.Controls.Add(this.txtWidth);
            this.groupBox1.Controls.Add(this.txtQuality);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtOutPutDir);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtWorkDir);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 191);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "配置区域";
            // 
            // chkRotate
            // 
            this.chkRotate.AutoSize = true;
            this.chkRotate.Location = new System.Drawing.Point(251, 83);
            this.chkRotate.Name = "chkRotate";
            this.chkRotate.Size = new System.Drawing.Size(72, 16);
            this.chkRotate.TabIndex = 5;
            this.chkRotate.Text = "自动旋转";
            this.chkRotate.UseVisualStyleBackColor = true;
            // 
            // btn_Begin
            // 
            this.btn_Begin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Begin.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Begin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Begin.Location = new System.Drawing.Point(23, 150);
            this.btn_Begin.Name = "btn_Begin";
            this.btn_Begin.Size = new System.Drawing.Size(304, 35);
            this.btn_Begin.TabIndex = 1;
            this.btn_Begin.Text = "压缩";
            this.btn_Begin.UseVisualStyleBackColor = false;
            this.btn_Begin.Click += new System.EventHandler(this.btn_Begin_Click);
            // 
            // chkPadding
            // 
            this.chkPadding.AutoSize = true;
            this.chkPadding.Location = new System.Drawing.Point(140, 83);
            this.chkPadding.Name = "chkPadding";
            this.chkPadding.Size = new System.Drawing.Size(72, 16);
            this.chkPadding.TabIndex = 5;
            this.chkPadding.Text = "自动填充";
            this.chkPadding.UseVisualStyleBackColor = true;
            // 
            // chkDefault
            // 
            this.chkDefault.AutoSize = true;
            this.chkDefault.Checked = true;
            this.chkDefault.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDefault.Location = new System.Drawing.Point(299, 52);
            this.chkDefault.Name = "chkDefault";
            this.chkDefault.Size = new System.Drawing.Size(48, 16);
            this.chkDefault.TabIndex = 4;
            this.chkDefault.Text = "默认";
            this.chkDefault.UseVisualStyleBackColor = true;
            this.chkDefault.CheckedChanged += new System.EventHandler(this.chkDefault_CheckedChanged);
            // 
            // btnViewForder
            // 
            this.btnViewForder.Location = new System.Drawing.Point(251, 17);
            this.btnViewForder.Name = "btnViewForder";
            this.btnViewForder.Size = new System.Drawing.Size(44, 23);
            this.btnViewForder.TabIndex = 3;
            this.btnViewForder.Text = "选择";
            this.btnViewForder.UseVisualStyleBackColor = true;
            this.btnViewForder.Click += new System.EventHandler(this.btnViewForder_Click);
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(158, 112);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(31, 21);
            this.txtHeight.TabIndex = 1;
            this.txtHeight.Text = "768";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(80, 112);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(31, 21);
            this.txtWidth.TabIndex = 1;
            this.txtWidth.Text = "1024";
            // 
            // txtQuality
            // 
            this.txtQuality.Location = new System.Drawing.Point(80, 81);
            this.txtQuality.Name = "txtQuality";
            this.txtQuality.Size = new System.Drawing.Size(31, 21);
            this.txtQuality.TabIndex = 1;
            this.txtQuality.Text = "85";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "高";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "宽";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "输出质量";
            // 
            // txtOutPutDir
            // 
            this.txtOutPutDir.Location = new System.Drawing.Point(80, 50);
            this.txtOutPutDir.Name = "txtOutPutDir";
            this.txtOutPutDir.Size = new System.Drawing.Size(164, 21);
            this.txtOutPutDir.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "工作目录";
            // 
            // txtWorkDir
            // 
            this.txtWorkDir.Location = new System.Drawing.Point(80, 19);
            this.txtWorkDir.Name = "txtWorkDir";
            this.txtWorkDir.Size = new System.Drawing.Size(164, 21);
            this.txtWorkDir.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "工作目录";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.rtxtLog);
            this.groupBox2.Location = new System.Drawing.Point(12, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(355, 142);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "输出区域-日志";
            // 
            // rtxtLog
            // 
            this.rtxtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtLog.Location = new System.Drawing.Point(3, 17);
            this.rtxtLog.Name = "rtxtLog";
            this.rtxtLog.Size = new System.Drawing.Size(349, 122);
            this.rtxtLog.TabIndex = 2;
            this.rtxtLog.Text = "";
            // 
            // btnViewOut
            // 
            this.btnViewOut.Location = new System.Drawing.Point(251, 48);
            this.btnViewOut.Name = "btnViewOut";
            this.btnViewOut.Size = new System.Drawing.Size(44, 23);
            this.btnViewOut.TabIndex = 3;
            this.btnViewOut.Text = "选择";
            this.btnViewOut.UseVisualStyleBackColor = true;
            this.btnViewOut.Click += new System.EventHandler(this.btnViewForder_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 364);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "图片压缩工具";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtWorkDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Begin;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtQuality;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnViewForder;
        private System.Windows.Forms.TextBox txtOutPutDir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkDefault;
        private System.Windows.Forms.CheckBox chkRotate;
        private System.Windows.Forms.CheckBox chkPadding;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rtxtLog;
        private System.Windows.Forms.Button btnViewOut;
    }
}

