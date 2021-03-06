﻿namespace Data_Visual
{
    partial class 用户主页
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(用户主页));
            this.labelVisual = new System.Windows.Forms.Label();
            this.labelSelect = new System.Windows.Forms.Label();
            this.labelUserC = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelVisual
            // 
            this.labelVisual.AutoSize = true;
            this.labelVisual.BackColor = System.Drawing.Color.Transparent;
            this.labelVisual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelVisual.Font = new System.Drawing.Font("张海山锐线体简", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelVisual.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelVisual.Location = new System.Drawing.Point(208, 352);
            this.labelVisual.Name = "labelVisual";
            this.labelVisual.Size = new System.Drawing.Size(138, 29);
            this.labelVisual.TabIndex = 2;
            this.labelVisual.Text = "数据可视化";
            this.labelVisual.Click += new System.EventHandler(this.labelVisual_Click);
            // 
            // labelSelect
            // 
            this.labelSelect.AutoSize = true;
            this.labelSelect.BackColor = System.Drawing.Color.Transparent;
            this.labelSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelSelect.Font = new System.Drawing.Font("张海山锐线体简", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelSelect.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSelect.Location = new System.Drawing.Point(528, 352);
            this.labelSelect.Name = "labelSelect";
            this.labelSelect.Size = new System.Drawing.Size(113, 29);
            this.labelSelect.TabIndex = 3;
            this.labelSelect.Text = "海洋科普";
            this.labelSelect.Click += new System.EventHandler(this.labelSelect_Click);
            // 
            // labelUserC
            // 
            this.labelUserC.AutoSize = true;
            this.labelUserC.BackColor = System.Drawing.Color.Transparent;
            this.labelUserC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelUserC.Font = new System.Drawing.Font("张海山锐线体简", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelUserC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelUserC.Location = new System.Drawing.Point(803, 352);
            this.labelUserC.Name = "labelUserC";
            this.labelUserC.Size = new System.Drawing.Size(114, 29);
            this.labelUserC.TabIndex = 4;
            this.labelUserC.Text = "用户中心";
            this.labelUserC.Click += new System.EventHandler(this.labelUserC_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("张海山锐线体简", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(341, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(479, 33);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ocean Tracer   —  To the Infinite Ocean";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitButton.Font = new System.Drawing.Font("张海山锐线体简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ExitButton.ForeColor = System.Drawing.Color.Black;
            this.ExitButton.Location = new System.Drawing.Point(477, 508);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(213, 61);
            this.ExitButton.TabIndex = 10;
            this.ExitButton.Text = "退出登录";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("张海山锐线体简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(456, 428);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Attention： 暂无新通知";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(539, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "区间更新中...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Data_Visual.Properties.Resources.logo_white_op10;
            this.pictureBox1.Location = new System.Drawing.Point(-21, 69);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(492, 456);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // 用户主页
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(121)))), ((int)(((byte)(133)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1144, 598);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelUserC);
            this.Controls.Add(this.labelSelect);
            this.Controls.Add(this.labelVisual);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "用户主页";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户主页";
            this.Load += new System.EventHandler(this.用户主页_Load);
            this.Shown += new System.EventHandler(this.用户主页_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelVisual;
        private System.Windows.Forms.Label labelSelect;
        private System.Windows.Forms.Label labelUserC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}