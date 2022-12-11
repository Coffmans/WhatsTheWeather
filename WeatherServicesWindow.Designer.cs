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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkShowBalloonTip = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numPollForWeatherTimer = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPollForWeatherTimer)).BeginInit();
            this.SuspendLayout();
            // 
            // chkAccuWeather
            // 
            this.chkAccuWeather.AutoSize = true;
            this.chkAccuWeather.Location = new System.Drawing.Point(24, 33);
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
            this.chkWeatherBit.Location = new System.Drawing.Point(24, 328);
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
            this.chkWeatherUnlocked.Location = new System.Drawing.Point(24, 245);
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
            this.chkWeatherApi.Location = new System.Drawing.Point(24, 191);
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
            this.label1.Location = new System.Drawing.Point(48, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "API Key";
            // 
            // txtWeatherBitAPIKey
            // 
            this.txtWeatherBitAPIKey.Location = new System.Drawing.Point(101, 351);
            this.txtWeatherBitAPIKey.Name = "txtWeatherBitAPIKey";
            this.txtWeatherBitAPIKey.Size = new System.Drawing.Size(460, 23);
            this.txtWeatherBitAPIKey.TabIndex = 5;
            // 
            // txtWeatherUnlockedAppId
            // 
            this.txtWeatherUnlockedAppId.Location = new System.Drawing.Point(101, 270);
            this.txtWeatherUnlockedAppId.Name = "txtWeatherUnlockedAppId";
            this.txtWeatherUnlockedAppId.Size = new System.Drawing.Size(460, 23);
            this.txtWeatherUnlockedAppId.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "APP ID";
            // 
            // txtWeatherUnlockedAppKey
            // 
            this.txtWeatherUnlockedAppKey.Location = new System.Drawing.Point(101, 299);
            this.txtWeatherUnlockedAppKey.Name = "txtWeatherUnlockedAppKey";
            this.txtWeatherUnlockedAppKey.Size = new System.Drawing.Size(460, 23);
            this.txtWeatherUnlockedAppKey.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "APP Key";
            // 
            // txtOpenWeatherAPIKey
            // 
            this.txtOpenWeatherAPIKey.Location = new System.Drawing.Point(101, 110);
            this.txtOpenWeatherAPIKey.Name = "txtOpenWeatherAPIKey";
            this.txtOpenWeatherAPIKey.Size = new System.Drawing.Size(460, 23);
            this.txtOpenWeatherAPIKey.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "API Key";
            // 
            // chkOpenWeather
            // 
            this.chkOpenWeather.AutoSize = true;
            this.chkOpenWeather.Location = new System.Drawing.Point(24, 87);
            this.chkOpenWeather.Name = "chkOpenWeather";
            this.chkOpenWeather.Size = new System.Drawing.Size(102, 19);
            this.chkOpenWeather.TabIndex = 10;
            this.chkOpenWeather.Text = "Open Weather";
            this.chkOpenWeather.UseVisualStyleBackColor = true;
            this.chkOpenWeather.CheckedChanged += new System.EventHandler(this.chkOpenWeather_CheckedChanged);
            // 
            // txtWeatherAPIKey
            // 
            this.txtWeatherAPIKey.Location = new System.Drawing.Point(101, 216);
            this.txtWeatherAPIKey.Name = "txtWeatherAPIKey";
            this.txtWeatherAPIKey.Size = new System.Drawing.Size(460, 23);
            this.txtWeatherAPIKey.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "API Key";
            // 
            // txtAccuWeatherAPIKey
            // 
            this.txtAccuWeatherAPIKey.Location = new System.Drawing.Point(101, 58);
            this.txtAccuWeatherAPIKey.Name = "txtAccuWeatherAPIKey";
            this.txtAccuWeatherAPIKey.Size = new System.Drawing.Size(460, 23);
            this.txtAccuWeatherAPIKey.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "API Key";
            // 
            // txtVisualCrossingAPIKey
            // 
            this.txtVisualCrossingAPIKey.Location = new System.Drawing.Point(101, 162);
            this.txtVisualCrossingAPIKey.Name = "txtVisualCrossingAPIKey";
            this.txtVisualCrossingAPIKey.Size = new System.Drawing.Size(460, 23);
            this.txtVisualCrossingAPIKey.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "API Key";
            // 
            // chkVisualCrossing
            // 
            this.chkVisualCrossing.AutoSize = true;
            this.chkVisualCrossing.Location = new System.Drawing.Point(24, 139);
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
            this.btnSaveWeatherServices.Location = new System.Drawing.Point(169, 522);
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
            this.btnCancelWeatherServices.Location = new System.Drawing.Point(372, 522);
            this.btnCancelWeatherServices.Name = "btnCancelWeatherServices";
            this.btnCancelWeatherServices.Size = new System.Drawing.Size(75, 23);
            this.btnCancelWeatherServices.TabIndex = 21;
            this.btnCancelWeatherServices.Text = "Cancel";
            this.btnCancelWeatherServices.UseVisualStyleBackColor = true;
            this.btnCancelWeatherServices.Click += new System.EventHandler(this.btnCancelWeatherServices_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkAccuWeather);
            this.groupBox1.Controls.Add(this.chkWeatherBit);
            this.groupBox1.Controls.Add(this.chkWeatherUnlocked);
            this.groupBox1.Controls.Add(this.txtVisualCrossingAPIKey);
            this.groupBox1.Controls.Add(this.chkWeatherApi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chkVisualCrossing);
            this.groupBox1.Controls.Add(this.txtWeatherBitAPIKey);
            this.groupBox1.Controls.Add(this.txtAccuWeatherAPIKey);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtWeatherUnlockedAppId);
            this.groupBox1.Controls.Add(this.txtWeatherAPIKey);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtWeatherUnlockedAppKey);
            this.groupBox1.Controls.Add(this.txtOpenWeatherAPIKey);
            this.groupBox1.Controls.Add(this.chkOpenWeather);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(21, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(578, 390);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Weather Providers";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkShowBalloonTip);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.numPollForWeatherTimer);
            this.groupBox2.Location = new System.Drawing.Point(21, 436);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(587, 65);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Miscellaneous Settings";
            // 
            // chkShowBalloonTip
            // 
            this.chkShowBalloonTip.AutoSize = true;
            this.chkShowBalloonTip.Location = new System.Drawing.Point(288, 26);
            this.chkShowBalloonTip.Name = "chkShowBalloonTip";
            this.chkShowBalloonTip.Size = new System.Drawing.Size(273, 19);
            this.chkShowBalloonTip.TabIndex = 26;
            this.chkShowBalloonTip.Text = "Show Balloon Tip for Each Temperature Update";
            this.chkShowBalloonTip.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(207, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 15);
            this.label8.TabIndex = 25;
            this.label8.Text = "Hour(s)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 15);
            this.label9.TabIndex = 24;
            this.label9.Text = "Poll For Temperature Every";
            // 
            // numPollForWeatherTimer
            // 
            this.numPollForWeatherTimer.Location = new System.Drawing.Point(159, 22);
            this.numPollForWeatherTimer.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numPollForWeatherTimer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPollForWeatherTimer.Name = "numPollForWeatherTimer";
            this.numPollForWeatherTimer.Size = new System.Drawing.Size(42, 23);
            this.numPollForWeatherTimer.TabIndex = 23;
            this.numPollForWeatherTimer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // WeatherServicesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 574);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelWeatherServices);
            this.Controls.Add(this.btnSaveWeatherServices);
            this.Name = "WeatherServicesWindow";
            this.Text = "Pick and Choose Your Weather Providers";
            this.Load += new System.EventHandler(this.WeatherServicesWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPollForWeatherTimer)).EndInit();
            this.ResumeLayout(false);

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
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private CheckBox chkShowBalloonTip;
        private Label label8;
        private Label label9;
        private NumericUpDown numPollForWeatherTimer;
    }
}