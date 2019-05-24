﻿namespace nhat
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.index = new System.Windows.Forms.Button();
            this.measure = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.calibration = new System.Windows.Forms.Button();
            this.diagnosis = new System.Windows.Forms.Button();
            this.setting = new System.Windows.Forms.Button();
            this.NO = new System.Windows.Forms.Label();
            this.NO2 = new System.Windows.Forms.Label();
            this.N = new System.Windows.Forms.Label();
            this.NOx = new System.Windows.Forms.Label();
            this.CO2 = new System.Windows.Forms.Label();
            this.K = new System.Windows.Forms.Label();
            this.Oiltemp = new System.Windows.Forms.Label();
            this.Airpressure = new System.Windows.Forms.Label();
            this.PEF = new System.Windows.Forms.Label();
            this.temperature = new System.Windows.Forms.Label();
            this.humidity = new System.Windows.Forms.Label();
            this.lambda = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.NO_value = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.NO2_value = new System.Windows.Forms.Label();
            this.CO2_value = new System.Windows.Forms.Label();
            this.Oiltemp_value = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Air_value = new System.Windows.Forms.Label();
            this.PEF_value = new System.Windows.Forms.Label();
            this.CO = new System.Windows.Forms.Label();
            this.HC = new System.Windows.Forms.Label();
            this.CO_value = new System.Windows.Forms.Label();
            this.HC_value = new System.Windows.Forms.Label();
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
            this.index.Click += new System.EventHandler(this.Index_Click);
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
            this.measure.Click += new System.EventHandler(this.Measure_Click);
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
            this.zero.Click += new System.EventHandler(this.Zero_Click);
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
            this.calibration.Click += new System.EventHandler(this.Calibration_Click);
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
            this.diagnosis.Click += new System.EventHandler(this.Diagnosis_Click);
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
            this.setting.Click += new System.EventHandler(this.Setting_Click);
            // 
            // NO
            // 
            this.NO.AutoSize = true;
            this.NO.Font = new System.Drawing.Font("微软雅黑", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NO.Location = new System.Drawing.Point(12, 9);
            this.NO.Name = "NO";
            this.NO.Size = new System.Drawing.Size(208, 124);
            this.NO.TabIndex = 6;
            this.NO.Text = "NO";
            // 
            // NO2
            // 
            this.NO2.AutoSize = true;
            this.NO2.Font = new System.Drawing.Font("微软雅黑", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NO2.Location = new System.Drawing.Point(12, 144);
            this.NO2.Name = "NO2";
            this.NO2.Size = new System.Drawing.Size(264, 124);
            this.NO2.TabIndex = 7;
            this.NO2.Text = "NO2";
            // 
            // N
            // 
            this.N.AutoSize = true;
            this.N.Font = new System.Drawing.Font("微软雅黑", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.N.Location = new System.Drawing.Point(12, 279);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(130, 124);
            this.N.TabIndex = 8;
            this.N.Text = "N";
            // 
            // NOx
            // 
            this.NOx.AutoSize = true;
            this.NOx.Font = new System.Drawing.Font("微软雅黑", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NOx.Location = new System.Drawing.Point(643, 9);
            this.NOx.Name = "NOx";
            this.NOx.Size = new System.Drawing.Size(257, 124);
            this.NOx.TabIndex = 9;
            this.NOx.Text = "NOx";
            // 
            // CO2
            // 
            this.CO2.AutoSize = true;
            this.CO2.Font = new System.Drawing.Font("微软雅黑", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CO2.Location = new System.Drawing.Point(643, 144);
            this.CO2.Name = "CO2";
            this.CO2.Size = new System.Drawing.Size(250, 124);
            this.CO2.TabIndex = 10;
            this.CO2.Text = "CO2";
            // 
            // K
            // 
            this.K.AutoSize = true;
            this.K.Font = new System.Drawing.Font("微软雅黑", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.K.Location = new System.Drawing.Point(643, 279);
            this.K.Name = "K";
            this.K.Size = new System.Drawing.Size(113, 124);
            this.K.TabIndex = 11;
            this.K.Text = "K";
            // 
            // Oiltemp
            // 
            this.Oiltemp.AutoSize = true;
            this.Oiltemp.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Oiltemp.Location = new System.Drawing.Point(27, 554);
            this.Oiltemp.Name = "Oiltemp";
            this.Oiltemp.Size = new System.Drawing.Size(111, 33);
            this.Oiltemp.TabIndex = 12;
            this.Oiltemp.Text = "油温：";
            // 
            // Airpressure
            // 
            this.Airpressure.AutoSize = true;
            this.Airpressure.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Airpressure.Location = new System.Drawing.Point(427, 554);
            this.Airpressure.Name = "Airpressure";
            this.Airpressure.Size = new System.Drawing.Size(111, 33);
            this.Airpressure.TabIndex = 13;
            this.Airpressure.Text = "气压：";
            // 
            // PEF
            // 
            this.PEF.AutoSize = true;
            this.PEF.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PEF.Location = new System.Drawing.Point(853, 554);
            this.PEF.Name = "PEF";
            this.PEF.Size = new System.Drawing.Size(95, 33);
            this.PEF.TabIndex = 14;
            this.PEF.Text = "PEF：";
            // 
            // temperature
            // 
            this.temperature.AutoSize = true;
            this.temperature.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.temperature.Location = new System.Drawing.Point(27, 593);
            this.temperature.Name = "temperature";
            this.temperature.Size = new System.Drawing.Size(111, 33);
            this.temperature.TabIndex = 15;
            this.temperature.Text = "气温：";
            // 
            // humidity
            // 
            this.humidity.AutoSize = true;
            this.humidity.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.humidity.Location = new System.Drawing.Point(427, 593);
            this.humidity.Name = "humidity";
            this.humidity.Size = new System.Drawing.Size(111, 33);
            this.humidity.TabIndex = 16;
            this.humidity.Text = "湿度：";
            // 
            // lambda
            // 
            this.lambda.AutoSize = true;
            this.lambda.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lambda.Location = new System.Drawing.Point(853, 593);
            this.lambda.Name = "lambda";
            this.lambda.Size = new System.Drawing.Size(79, 33);
            this.lambda.TabIndex = 17;
            this.lambda.Text = "λ：";
            // 
            // NO_value
            // 
            this.NO_value.AutoSize = true;
            this.NO_value.Font = new System.Drawing.Font("宋体", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NO_value.Location = new System.Drawing.Point(226, 53);
            this.NO_value.Name = "NO_value";
            this.NO_value.Size = new System.Drawing.Size(284, 64);
            this.NO_value.TabIndex = 18;
            this.NO_value.Text = "NO_value";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1192, 486);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1192, 515);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "test2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // NO2_value
            // 
            this.NO2_value.AutoSize = true;
            this.NO2_value.Font = new System.Drawing.Font("宋体", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NO2_value.Location = new System.Drawing.Point(290, 188);
            this.NO2_value.Name = "NO2_value";
            this.NO2_value.Size = new System.Drawing.Size(316, 64);
            this.NO2_value.TabIndex = 22;
            this.NO2_value.Text = "NO2_value";
            // 
            // CO2_value
            // 
            this.CO2_value.AutoSize = true;
            this.CO2_value.Font = new System.Drawing.Font("宋体", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CO2_value.Location = new System.Drawing.Point(899, 188);
            this.CO2_value.Name = "CO2_value";
            this.CO2_value.Size = new System.Drawing.Size(316, 64);
            this.CO2_value.TabIndex = 23;
            this.CO2_value.Text = "CO2_value";
            // 
            // Oiltemp_value
            // 
            this.Oiltemp_value.AutoSize = true;
            this.Oiltemp_value.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Oiltemp_value.Location = new System.Drawing.Point(144, 561);
            this.Oiltemp_value.Name = "Oiltemp_value";
            this.Oiltemp_value.Size = new System.Drawing.Size(166, 24);
            this.Oiltemp_value.TabIndex = 24;
            this.Oiltemp_value.Text = "Oiltemp_value";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 611);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 25;
            this.label1.Text = "label1";
            // 
            // Air_value
            // 
            this.Air_value.AutoSize = true;
            this.Air_value.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Air_value.Location = new System.Drawing.Point(544, 561);
            this.Air_value.Name = "Air_value";
            this.Air_value.Size = new System.Drawing.Size(118, 24);
            this.Air_value.TabIndex = 26;
            this.Air_value.Text = "Air_value";
            // 
            // PEF_value
            // 
            this.PEF_value.AutoSize = true;
            this.PEF_value.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PEF_value.Location = new System.Drawing.Point(954, 561);
            this.PEF_value.Name = "PEF_value";
            this.PEF_value.Size = new System.Drawing.Size(118, 24);
            this.PEF_value.TabIndex = 27;
            this.PEF_value.Text = "PEF_value";
            // 
            // CO
            // 
            this.CO.AutoSize = true;
            this.CO.Font = new System.Drawing.Font("微软雅黑", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CO.Location = new System.Drawing.Point(12, 414);
            this.CO.Name = "CO";
            this.CO.Size = new System.Drawing.Size(194, 124);
            this.CO.TabIndex = 28;
            this.CO.Text = "CO";
            // 
            // HC
            // 
            this.HC.AutoSize = true;
            this.HC.Font = new System.Drawing.Font("微软雅黑", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HC.Location = new System.Drawing.Point(643, 414);
            this.HC.Name = "HC";
            this.HC.Size = new System.Drawing.Size(190, 124);
            this.HC.TabIndex = 29;
            this.HC.Text = "HC";
            // 
            // CO_value
            // 
            this.CO_value.AutoSize = true;
            this.CO_value.Font = new System.Drawing.Font("宋体", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CO_value.Location = new System.Drawing.Point(212, 455);
            this.CO_value.Name = "CO_value";
            this.CO_value.Size = new System.Drawing.Size(284, 64);
            this.CO_value.TabIndex = 30;
            this.CO_value.Text = "CO_value";
            // 
            // HC_value
            // 
            this.HC_value.AutoSize = true;
            this.HC_value.Font = new System.Drawing.Font("宋体", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HC_value.Location = new System.Drawing.Point(839, 455);
            this.HC_value.Name = "HC_value";
            this.HC_value.Size = new System.Drawing.Size(284, 64);
            this.HC_value.TabIndex = 31;
            this.HC_value.Text = "HC_value";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.HC_value);
            this.Controls.Add(this.CO_value);
            this.Controls.Add(this.HC);
            this.Controls.Add(this.CO);
            this.Controls.Add(this.PEF_value);
            this.Controls.Add(this.Air_value);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Oiltemp_value);
            this.Controls.Add(this.CO2_value);
            this.Controls.Add(this.NO2_value);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NO_value);
            this.Controls.Add(this.lambda);
            this.Controls.Add(this.humidity);
            this.Controls.Add(this.temperature);
            this.Controls.Add(this.PEF);
            this.Controls.Add(this.Airpressure);
            this.Controls.Add(this.Oiltemp);
            this.Controls.Add(this.K);
            this.Controls.Add(this.CO2);
            this.Controls.Add(this.NOx);
            this.Controls.Add(this.N);
            this.Controls.Add(this.NO2);
            this.Controls.Add(this.NO);
            this.Controls.Add(this.setting);
            this.Controls.Add(this.diagnosis);
            this.Controls.Add(this.calibration);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.measure);
            this.Controls.Add(this.index);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "主菜单";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button index; //主界面
        private System.Windows.Forms.Button measure; //测量
        private System.Windows.Forms.Button zero; //调零
        private System.Windows.Forms.Button calibration; //校准
        private System.Windows.Forms.Button diagnosis; //诊断
        private System.Windows.Forms.Button setting; //设置
        private System.Windows.Forms.Label NO;
        private System.Windows.Forms.Label NO2;
        private System.Windows.Forms.Label N; //不透光度
        private System.Windows.Forms.Label NOx;
        private System.Windows.Forms.Label CO2;
        private System.Windows.Forms.Label K; //光吸收系数
        private System.Windows.Forms.Label Oiltemp; //油温
        private System.Windows.Forms.Label Airpressure; //气压
        private System.Windows.Forms.Label PEF; //PEF
        private System.Windows.Forms.Label temperature; //气温
        private System.Windows.Forms.Label humidity; //湿度
        private System.Windows.Forms.Label lambda; //λ
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label NO_value;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label NO2_value;
        private System.Windows.Forms.Label CO2_value;
        private System.Windows.Forms.Label Oiltemp_value;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Air_value; //气压值
        private System.Windows.Forms.Label PEF_value;
        private System.Windows.Forms.Label CO;
        private System.Windows.Forms.Label HC;
        private System.Windows.Forms.Label CO_value;
        private System.Windows.Forms.Label HC_value;
    }
}

