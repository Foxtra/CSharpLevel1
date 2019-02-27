namespace WeatherAppTest
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbCitys = new System.Windows.Forms.ListBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.gbClient = new System.Windows.Forms.GroupBox();
            this.gbTemperature = new System.Windows.Forms.GroupBox();
            this.lblTemperatureValueMax = new System.Windows.Forms.Label();
            this.lblTemperatureValueMin = new System.Windows.Forms.Label();
            this.lblTemperatureMax = new System.Windows.Forms.Label();
            this.lblTemperatureMin = new System.Windows.Forms.Label();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.gbPressure = new System.Windows.Forms.GroupBox();
            this.lblPressureValueMax = new System.Windows.Forms.Label();
            this.lblPressureValueMin = new System.Windows.Forms.Label();
            this.lblPressureMax = new System.Windows.Forms.Label();
            this.lblPressureMin = new System.Windows.Forms.Label();
            this.gbClient.SuspendLayout();
            this.gbTemperature.SuspendLayout();
            this.gbPressure.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCitys
            // 
            this.lbCitys.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbCitys.FormattingEnabled = true;
            this.lbCitys.ItemHeight = 24;
            this.lbCitys.Location = new System.Drawing.Point(0, 0);
            this.lbCitys.Margin = new System.Windows.Forms.Padding(6);
            this.lbCitys.Name = "lbCitys";
            this.lbCitys.Size = new System.Drawing.Size(455, 594);
            this.lbCitys.TabIndex = 0;
            this.lbCitys.SelectedIndexChanged += new System.EventHandler(this.lbCitys_SelectedIndexChanged);
            this.lbCitys.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblPressureMin_MouseDown);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(455, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(6);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(6, 594);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // gbClient
            // 
            this.gbClient.Controls.Add(this.gbTemperature);
            this.gbClient.Controls.Add(this.splitter2);
            this.gbClient.Controls.Add(this.gbPressure);
            this.gbClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbClient.Location = new System.Drawing.Point(461, 0);
            this.gbClient.Margin = new System.Windows.Forms.Padding(6);
            this.gbClient.Name = "gbClient";
            this.gbClient.Padding = new System.Windows.Forms.Padding(6);
            this.gbClient.Size = new System.Drawing.Size(465, 594);
            this.gbClient.TabIndex = 2;
            this.gbClient.TabStop = false;
            // 
            // gbTemperature
            // 
            this.gbTemperature.Controls.Add(this.lblTemperatureValueMax);
            this.gbTemperature.Controls.Add(this.lblTemperatureValueMin);
            this.gbTemperature.Controls.Add(this.lblTemperatureMax);
            this.gbTemperature.Controls.Add(this.lblTemperatureMin);
            this.gbTemperature.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTemperature.Location = new System.Drawing.Point(6, 219);
            this.gbTemperature.Margin = new System.Windows.Forms.Padding(6);
            this.gbTemperature.Name = "gbTemperature";
            this.gbTemperature.Padding = new System.Windows.Forms.Padding(6);
            this.gbTemperature.Size = new System.Drawing.Size(453, 369);
            this.gbTemperature.TabIndex = 2;
            this.gbTemperature.TabStop = false;
            this.gbTemperature.Text = "Температура";
            // 
            // lblTemperatureValueMax
            // 
            this.lblTemperatureValueMax.AutoSize = true;
            this.lblTemperatureValueMax.Location = new System.Drawing.Point(72, 94);
            this.lblTemperatureValueMax.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTemperatureValueMax.Name = "lblTemperatureValueMax";
            this.lblTemperatureValueMax.Size = new System.Drawing.Size(0, 24);
            this.lblTemperatureValueMax.TabIndex = 3;
            this.lblTemperatureValueMax.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblPressureMin_MouseDown);
            // 
            // lblTemperatureValueMin
            // 
            this.lblTemperatureValueMin.AutoSize = true;
            this.lblTemperatureValueMin.Location = new System.Drawing.Point(72, 48);
            this.lblTemperatureValueMin.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTemperatureValueMin.Name = "lblTemperatureValueMin";
            this.lblTemperatureValueMin.Size = new System.Drawing.Size(0, 24);
            this.lblTemperatureValueMin.TabIndex = 2;
            this.lblTemperatureValueMin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblPressureMin_MouseDown);
            // 
            // lblTemperatureMax
            // 
            this.lblTemperatureMax.AutoSize = true;
            this.lblTemperatureMax.Location = new System.Drawing.Point(6, 96);
            this.lblTemperatureMax.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTemperatureMax.Name = "lblTemperatureMax";
            this.lblTemperatureMax.Size = new System.Drawing.Size(46, 24);
            this.lblTemperatureMax.TabIndex = 1;
            this.lblTemperatureMax.Text = "max";
            this.lblTemperatureMax.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblPressureMin_MouseDown);
            // 
            // lblTemperatureMin
            // 
            this.lblTemperatureMin.AutoSize = true;
            this.lblTemperatureMin.Location = new System.Drawing.Point(6, 48);
            this.lblTemperatureMin.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTemperatureMin.Name = "lblTemperatureMin";
            this.lblTemperatureMin.Size = new System.Drawing.Size(41, 24);
            this.lblTemperatureMin.TabIndex = 0;
            this.lblTemperatureMin.Text = "min";
            this.lblTemperatureMin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblPressureMin_MouseDown);
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(6, 213);
            this.splitter2.Margin = new System.Windows.Forms.Padding(6);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(453, 6);
            this.splitter2.TabIndex = 1;
            this.splitter2.TabStop = false;
            // 
            // gbPressure
            // 
            this.gbPressure.Controls.Add(this.lblPressureValueMax);
            this.gbPressure.Controls.Add(this.lblPressureValueMin);
            this.gbPressure.Controls.Add(this.lblPressureMax);
            this.gbPressure.Controls.Add(this.lblPressureMin);
            this.gbPressure.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbPressure.Location = new System.Drawing.Point(6, 28);
            this.gbPressure.Margin = new System.Windows.Forms.Padding(6);
            this.gbPressure.Name = "gbPressure";
            this.gbPressure.Padding = new System.Windows.Forms.Padding(6);
            this.gbPressure.Size = new System.Drawing.Size(453, 185);
            this.gbPressure.TabIndex = 0;
            this.gbPressure.TabStop = false;
            this.gbPressure.Text = "Давление";
            // 
            // lblPressureValueMax
            // 
            this.lblPressureValueMax.AutoSize = true;
            this.lblPressureValueMax.Location = new System.Drawing.Point(66, 83);
            this.lblPressureValueMax.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPressureValueMax.Name = "lblPressureValueMax";
            this.lblPressureValueMax.Size = new System.Drawing.Size(0, 24);
            this.lblPressureValueMax.TabIndex = 3;
            this.lblPressureValueMax.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblPressureMin_MouseDown);
            // 
            // lblPressureValueMin
            // 
            this.lblPressureValueMin.AutoSize = true;
            this.lblPressureValueMin.Location = new System.Drawing.Point(66, 37);
            this.lblPressureValueMin.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPressureValueMin.Name = "lblPressureValueMin";
            this.lblPressureValueMin.Size = new System.Drawing.Size(0, 24);
            this.lblPressureValueMin.TabIndex = 2;
            this.lblPressureValueMin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblPressureMin_MouseDown);
            // 
            // lblPressureMax
            // 
            this.lblPressureMax.AutoSize = true;
            this.lblPressureMax.Location = new System.Drawing.Point(11, 83);
            this.lblPressureMax.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPressureMax.Name = "lblPressureMax";
            this.lblPressureMax.Size = new System.Drawing.Size(46, 24);
            this.lblPressureMax.TabIndex = 1;
            this.lblPressureMax.Text = "max";
            this.lblPressureMax.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblPressureMin_MouseDown);
            // 
            // lblPressureMin
            // 
            this.lblPressureMin.AutoSize = true;
            this.lblPressureMin.Location = new System.Drawing.Point(13, 37);
            this.lblPressureMin.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPressureMin.Name = "lblPressureMin";
            this.lblPressureMin.Size = new System.Drawing.Size(41, 24);
            this.lblPressureMin.TabIndex = 0;
            this.lblPressureMin.Text = "min";
            this.lblPressureMin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblPressureMin_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 594);
            this.Controls.Add(this.gbClient);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.lbCitys);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbClient.ResumeLayout(false);
            this.gbTemperature.ResumeLayout(false);
            this.gbTemperature.PerformLayout();
            this.gbPressure.ResumeLayout(false);
            this.gbPressure.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbCitys;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.GroupBox gbClient;
        private System.Windows.Forms.GroupBox gbTemperature;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.GroupBox gbPressure;
        private System.Windows.Forms.Label lblTemperatureValueMax;
        private System.Windows.Forms.Label lblTemperatureValueMin;
        private System.Windows.Forms.Label lblTemperatureMax;
        private System.Windows.Forms.Label lblTemperatureMin;
        private System.Windows.Forms.Label lblPressureValueMax;
        private System.Windows.Forms.Label lblPressureValueMin;
        private System.Windows.Forms.Label lblPressureMax;
        private System.Windows.Forms.Label lblPressureMin;
    }
}

