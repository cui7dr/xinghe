﻿namespace nhat
{
    partial class master
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
            this.index = new System.Windows.Forms.Button();
            this.measure = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.calibration = new System.Windows.Forms.Button();
            this.diagnosis = new System.Windows.Forms.Button();
            this.setting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // index
            // 
            this.index.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.index.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.index.Location = new System.Drawing.Point(13, 652);
            this.index.Name = "index";
            this.index.Size = new System.Drawing.Size(204, 56);
            this.index.TabIndex = 0;
            this.index.Text = "主界面";
            this.index.UseVisualStyleBackColor = true;
            // 
            // measure
            // 
            this.measure.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.measure.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.measure.Location = new System.Drawing.Point(223, 652);
            this.measure.Name = "measure";
            this.measure.Size = new System.Drawing.Size(204, 56);
            this.measure.TabIndex = 1;
            this.measure.Text = "测量";
            this.measure.UseVisualStyleBackColor = true;
            // 
            // zero
            // 
            this.zero.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zero.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.zero.Location = new System.Drawing.Point(433, 652);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(204, 56);
            this.zero.TabIndex = 2;
            this.zero.Text = "调零";
            this.zero.UseVisualStyleBackColor = true;
            // 
            // calibration
            // 
            this.calibration.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calibration.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.calibration.Location = new System.Drawing.Point(643, 652);
            this.calibration.Name = "calibration";
            this.calibration.Size = new System.Drawing.Size(204, 56);
            this.calibration.TabIndex = 3;
            this.calibration.Text = "校准";
            this.calibration.UseVisualStyleBackColor = true;
            // 
            // diagnosis
            // 
            this.diagnosis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.diagnosis.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.diagnosis.Location = new System.Drawing.Point(853, 652);
            this.diagnosis.Name = "diagnosis";
            this.diagnosis.Size = new System.Drawing.Size(204, 56);
            this.diagnosis.TabIndex = 4;
            this.diagnosis.Text = "诊断";
            this.diagnosis.UseVisualStyleBackColor = true;
            // 
            // setting
            // 
            this.setting.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.setting.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.setting.Location = new System.Drawing.Point(1063, 652);
            this.setting.Name = "setting";
            this.setting.Size = new System.Drawing.Size(204, 56);
            this.setting.TabIndex = 5;
            this.setting.Text = "设置";
            this.setting.UseVisualStyleBackColor = true;
            // 
            // master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.setting);
            this.Controls.Add(this.diagnosis);
            this.Controls.Add(this.calibration);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.measure);
            this.Controls.Add(this.index);
            this.Name = "master";
            this.Text = "master";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button index; //主界面
        private System.Windows.Forms.Button measure; //测量
        private System.Windows.Forms.Button zero; //调零
        private System.Windows.Forms.Button calibration; //校准
        private System.Windows.Forms.Button diagnosis; //诊断
        private System.Windows.Forms.Button setting; //设置
    }
}