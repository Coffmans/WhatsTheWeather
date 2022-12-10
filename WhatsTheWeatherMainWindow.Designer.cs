namespace WhatsTheWeather
{
    partial class WhatsTheWeatherMainWindow
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
            this.cbWeatherService = new System.Windows.Forms.ComboBox();
            this.btnTestWeatherService = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLastTemperature = new System.Windows.Forms.TextBox();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnWeatherProviders = new System.Windows.Forms.Button();
            this.btnStartPollForWeather = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbWeatherService
            // 
            this.cbWeatherService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWeatherService.FormattingEnabled = true;
            this.cbWeatherService.Location = new System.Drawing.Point(130, 40);
            this.cbWeatherService.Name = "cbWeatherService";
            this.cbWeatherService.Size = new System.Drawing.Size(206, 23);
            this.cbWeatherService.TabIndex = 17;
            // 
            // btnTestWeatherService
            // 
            this.btnTestWeatherService.Location = new System.Drawing.Point(342, 39);
            this.btnTestWeatherService.Name = "btnTestWeatherService";
            this.btnTestWeatherService.Size = new System.Drawing.Size(53, 23);
            this.btnTestWeatherService.TabIndex = 16;
            this.btnTestWeatherService.Text = "Test";
            this.btnTestWeatherService.UseVisualStyleBackColor = true;
            this.btnTestWeatherService.Click += new System.EventHandler(this.btnTestWeatherService_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(413, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Last Temperature (Poll Time)";
            // 
            // txtLastTemperature
            // 
            this.txtLastTemperature.Location = new System.Drawing.Point(413, 39);
            this.txtLastTemperature.Name = "txtLastTemperature";
            this.txtLastTemperature.ReadOnly = true;
            this.txtLastTemperature.Size = new System.Drawing.Size(177, 23);
            this.txtLastTemperature.TabIndex = 14;
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(8, 39);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(100, 23);
            this.txtZipCode.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Zip Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Select A Weather Provider";
            // 
            // btnWeatherProviders
            // 
            this.btnWeatherProviders.Location = new System.Drawing.Point(413, 88);
            this.btnWeatherProviders.Name = "btnWeatherProviders";
            this.btnWeatherProviders.Size = new System.Drawing.Size(177, 23);
            this.btnWeatherProviders.TabIndex = 10;
            this.btnWeatherProviders.Text = "Configure Providers";
            this.btnWeatherProviders.UseVisualStyleBackColor = true;
            this.btnWeatherProviders.Click += new System.EventHandler(this.btnWeatherProviders_Click);
            // 
            // btnStartPollForWeather
            // 
            this.btnStartPollForWeather.Location = new System.Drawing.Point(8, 97);
            this.btnStartPollForWeather.Name = "btnStartPollForWeather";
            this.btnStartPollForWeather.Size = new System.Drawing.Size(143, 23);
            this.btnStartPollForWeather.TabIndex = 18;
            this.btnStartPollForWeather.Text = "Start";
            this.btnStartPollForWeather.UseVisualStyleBackColor = true;
            this.btnStartPollForWeather.Click += new System.EventHandler(this.btnStartPollForWeather_Click);
            // 
            // WhatsTheWeatherMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 132);
            this.Controls.Add(this.btnStartPollForWeather);
            this.Controls.Add(this.cbWeatherService);
            this.Controls.Add(this.btnTestWeatherService);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLastTemperature);
            this.Controls.Add(this.txtZipCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnWeatherProviders);
            this.Name = "WhatsTheWeatherMainWindow";
            this.Text = "What\'s The Weather";
            this.Load += new System.EventHandler(this.WhatsTheWeatherMainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbWeatherService;
        private Button btnTestWeatherService;
        private Label label3;
        private TextBox txtLastTemperature;
        private TextBox txtZipCode;
        private Label label2;
        private Label label1;
        private Button btnWeatherProviders;
        private Button btnStartPollForWeather;
    }
}