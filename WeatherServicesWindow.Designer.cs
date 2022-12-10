namespace WhatsTheWeather
{
    partial class WeatherServicesWindow
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
            this.chkAccuWeather = new System.Windows.Forms.CheckBox();
            this.chkWeatherBit = new System.Windows.Forms.CheckBox();
            this.chkWeatherUnlocked = new System.Windows.Forms.CheckBox();
            this.chkWeatherApi = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWeatherBitAPIKey = new System.Windows.Forms.TextBox();
            this.txtWeatherUnlockedAppId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWeatherUnlockedAppKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOpenWeatherAPIKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkOpenWeather = new System.Windows.Forms.CheckBox();
            this.txtWeatherAPIKey = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAccuWeatherAPIKey = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVisualCrossingAPIKey = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chkVisualCrossing = new System.Windows.Forms.CheckBox();
            this.btnSaveWeatherServices = new System.Windows.Forms.Button();
            this.btnCancelWeatherServices = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkAccuWeather
            // 
            this.chkAccuWeather.AutoSize = true;
            this.chkAccuWeather.Location = new System.Drawing.Point(12, 23);
            this.chkAccuWeather.Name = "chkAccuWeather";
            this.chkAccuWeather.Size = new System.Drawing.Size(97, 19);
            this.chkAccuWeather.TabIndex = 0;
            this.chkAccuWeather.Text = "AccuWeather";
            this.chkAccuWeather.UseVisualStyleBackColor = true;
            this.chkAccuWeather.CheckedChanged += new System.EventHandler(this.chkAccuWeather_CheckedChanged);
            // 
            // chkWeatherBit
            // 
            this.chkWeatherBit.AutoSize = true;
            this.chkWeatherBit.Location = new System.Drawing.Point(18, 318);
            this.chkWeatherBit.Name = "chkWeatherBit";
            this.chkWeatherBit.Size = new System.Drawing.Size(97, 19);
            this.chkWeatherBit.TabIndex = 1;
            this.chkWeatherBit.Text = "WeatherBit.io";
            this.chkWeatherBit.UseVisualStyleBackColor = true;
            this.chkWeatherBit.CheckedChanged += new System.EventHandler(this.chkWeatherBit_CheckedChanged);
            // 
            // chkWeatherUnlocked
            // 
            this.chkWeatherUnlocked.AutoSize = true;
            this.chkWeatherUnlocked.Location = new System.Drawing.Point(12, 235);
            this.chkWeatherUnlocked.Name = "chkWeatherUnlocked";
            this.chkWeatherUnlocked.Size = new System.Drawing.Size(123, 19);
            this.chkWeatherUnlocked.TabIndex = 2;
            this.chkWeatherUnlocked.Text = "Weather Unlocked";
            this.chkWeatherUnlocked.UseVisualStyleBackColor = true;
            this.chkWeatherUnlocked.CheckedChanged += new System.EventHandler(this.chkWeatherUnlocked_CheckedChanged);
            // 
            // chkWeatherApi
            // 
            this.chkWeatherApi.AutoSize = true;
            this.chkWeatherApi.Location = new System.Drawing.Point(12, 181);
            this.chkWeatherApi.Name = "chkWeatherApi";
            this.chkWeatherApi.Size = new System.Drawing.Size(91, 19);
            this.chkWeatherApi.TabIndex = 3;
            this.chkWeatherApi.Text = "Weather API";
            this.chkWeatherApi.UseVisualStyleBackColor = true;
            this.chkWeatherApi.CheckedChanged += new System.EventHandler(this.chkWeatherApi_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "API Key";
            // 
            // txtWeatherBitAPIKey
            // 
            this.txtWeatherBitAPIKey.Location = new System.Drawing.Point(95, 341);
            this.txtWeatherBitAPIKey.Name = "txtWeatherBitAPIKey";
            this.txtWeatherBitAPIKey.Size = new System.Drawing.Size(460, 23);
            this.txtWeatherBitAPIKey.TabIndex = 5;
            // 
            // txtWeatherUnlockedAppId
            // 
            this.txtWeatherUnlockedAppId.Location = new System.Drawing.Point(89, 260);
            this.txtWeatherUnlockedAppId.Name = "txtWeatherUnlockedAppId";
            this.txtWeatherUnlockedAppId.Size = new System.Drawing.Size(460, 23);
            this.txtWeatherUnlockedAppId.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "APP ID";
            // 
            // txtWeatherUnlockedAppKey
            // 
            this.txtWeatherUnlockedAppKey.Location = new System.Drawing.Point(89, 289);
            this.txtWeatherUnlockedAppKey.Name = "txtWeatherUnlockedAppKey";
            this.txtWeatherUnlockedAppKey.Size = new System.Drawing.Size(460, 23);
            this.txtWeatherUnlockedAppKey.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "APP Key";
            // 
            // txtOpenWeatherAPIKey
            // 
            this.txtOpenWeatherAPIKey.Location = new System.Drawing.Point(89, 100);
            this.txtOpenWeatherAPIKey.Name = "txtOpenWeatherAPIKey";
            this.txtOpenWeatherAPIKey.Size = new System.Drawing.Size(460, 23);
            this.txtOpenWeatherAPIKey.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "API Key";
            // 
            // chkOpenWeather
            // 
            this.chkOpenWeather.AutoSize = true;
            this.chkOpenWeather.Location = new System.Drawing.Point(12, 77);
            this.chkOpenWeather.Name = "chkOpenWeather";
            this.chkOpenWeather.Size = new System.Drawing.Size(102, 19);
            this.chkOpenWeather.TabIndex = 10;
            this.chkOpenWeather.Text = "Open Weather";
            this.chkOpenWeather.UseVisualStyleBackColor = true;
            this.chkOpenWeather.CheckedChanged += new System.EventHandler(this.chkOpenWeather_CheckedChanged);
            // 
            // txtWeatherAPIKey
            // 
            this.txtWeatherAPIKey.Location = new System.Drawing.Point(89, 206);
            this.txtWeatherAPIKey.Name = "txtWeatherAPIKey";
            this.txtWeatherAPIKey.Size = new System.Drawing.Size(460, 23);
            this.txtWeatherAPIKey.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "API Key";
            // 
            // txtAccuWeatherAPIKey
            // 
            this.txtAccuWeatherAPIKey.Location = new System.Drawing.Point(89, 48);
            this.txtAccuWeatherAPIKey.Name = "txtAccuWeatherAPIKey";
            this.txtAccuWeatherAPIKey.Size = new System.Drawing.Size(460, 23);
            this.txtAccuWeatherAPIKey.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "API Key";
            // 
            // txtVisualCrossingAPIKey
            // 
            this.txtVisualCrossingAPIKey.Location = new System.Drawing.Point(89, 152);
            this.txtVisualCrossingAPIKey.Name = "txtVisualCrossingAPIKey";
            this.txtVisualCrossingAPIKey.Size = new System.Drawing.Size(460, 23);
            this.txtVisualCrossingAPIKey.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "API Key";
            // 
            // chkVisualCrossing
            // 
            this.chkVisualCrossing.AutoSize = true;
            this.chkVisualCrossing.Location = new System.Drawing.Point(12, 129);
            this.chkVisualCrossing.Name = "chkVisualCrossing";
            this.chkVisualCrossing.Size = new System.Drawing.Size(106, 19);
            this.chkVisualCrossing.TabIndex = 17;
            this.chkVisualCrossing.Text = "Visual Crossing";
            this.chkVisualCrossing.UseVisualStyleBackColor = true;
            this.chkVisualCrossing.CheckedChanged += new System.EventHandler(this.chkVisualCrossing_CheckedChanged);
            // 
            // btnSaveWeatherServices
            // 
            this.btnSaveWeatherServices.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSaveWeatherServices.Location = new System.Drawing.Point(144, 382);
            this.btnSaveWeatherServices.Name = "btnSaveWeatherServices";
            this.btnSaveWeatherServices.Size = new System.Drawing.Size(75, 23);
            this.btnSaveWeatherServices.TabIndex = 20;
            this.btnSaveWeatherServices.Text = "OK";
            this.btnSaveWeatherServices.UseVisualStyleBackColor = true;
            this.btnSaveWeatherServices.Click += new System.EventHandler(this.btnSaveWeatherServices_Click);
            // 
            // btnCancelWeatherServices
            // 
            this.btnCancelWeatherServices.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelWeatherServices.Location = new System.Drawing.Point(374, 382);
            this.btnCancelWeatherServices.Name = "btnCancelWeatherServices";
            this.btnCancelWeatherServices.Size = new System.Drawing.Size(75, 23);
            this.btnCancelWeatherServices.TabIndex = 21;
            this.btnCancelWeatherServices.Text = "Cancel";
            this.btnCancelWeatherServices.UseVisualStyleBackColor = true;
            this.btnCancelWeatherServices.Click += new System.EventHandler(this.btnCancelWeatherServices_Click);
            // 
            // WeatherServicesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 416);
            this.Controls.Add(this.btnCancelWeatherServices);
            this.Controls.Add(this.btnSaveWeatherServices);
            this.Controls.Add(this.txtVisualCrossingAPIKey);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chkVisualCrossing);
            this.Controls.Add(this.txtAccuWeatherAPIKey);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtWeatherAPIKey);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtOpenWeatherAPIKey);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkOpenWeather);
            this.Controls.Add(this.txtWeatherUnlockedAppKey);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtWeatherUnlockedAppId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtWeatherBitAPIKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkWeatherApi);
            this.Controls.Add(this.chkWeatherUnlocked);
            this.Controls.Add(this.chkWeatherBit);
            this.Controls.Add(this.chkAccuWeather);
            this.Name = "WeatherServicesWindow";
            this.Text = "Pick and Choose Your Weather Providers";
            this.Load += new System.EventHandler(this.WeatherServicesWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox chkAccuWeather;
        private CheckBox chkWeatherBit;
        private CheckBox chkWeatherUnlocked;
        private CheckBox chkWeatherApi;
        private Label label1;
        private TextBox txtWeatherBitAPIKey;
        private TextBox txtWeatherUnlockedAppId;
        private Label label2;
        private TextBox txtWeatherUnlockedAppKey;
        private Label label3;
        private TextBox txtOpenWeatherAPIKey;
        private Label label4;
        private CheckBox chkOpenWeather;
        private TextBox txtWeatherAPIKey;
        private Label label5;
        private TextBox txtAccuWeatherAPIKey;
        private Label label6;
        private TextBox txtVisualCrossingAPIKey;
        private Label label7;
        private CheckBox chkVisualCrossing;
        private Button btnSaveWeatherServices;
        private Button btnCancelWeatherServices;
    }
}