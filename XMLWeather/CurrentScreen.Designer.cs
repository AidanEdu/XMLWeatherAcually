namespace XMLWeather
{
    partial class CurrentScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cityOutput = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.forecastLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.currentOutput = new System.Windows.Forms.Label();
            this.backColorLabel = new System.Windows.Forms.Label();
            this.xLabel = new System.Windows.Forms.Label();
            this.humidityLabel = new System.Windows.Forms.Label();
            this.sunriseLabel = new System.Windows.Forms.Label();
            this.sunsetLabel = new System.Windows.Forms.Label();
            this.lastUpdateLabel = new System.Windows.Forms.Label();
            this.moreInfoLabel = new System.Windows.Forms.Label();
            this.currentConditionsLabel = new System.Windows.Forms.Label();
            this.searchLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cityOutput
            // 
            this.cityOutput.BackColor = System.Drawing.Color.Transparent;
            this.cityOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityOutput.ForeColor = System.Drawing.Color.Black;
            this.cityOutput.Location = new System.Drawing.Point(39, 27);
            this.cityOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(264, 44);
            this.cityOutput.TabIndex = 22;
            this.cityOutput.Text = "City";
            this.cityOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLabel.ForeColor = System.Drawing.Color.Black;
            this.maxLabel.Location = new System.Drawing.Point(124, 218);
            this.maxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(50, 25);
            this.maxLabel.TabIndex = 31;
            this.maxLabel.Text = "Max";
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLabel.ForeColor = System.Drawing.Color.Black;
            this.minLabel.Location = new System.Drawing.Point(217, 218);
            this.minLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(44, 25);
            this.minLabel.TabIndex = 29;
            this.minLabel.Text = "Min";
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.Black;
            this.forecastLabel.Location = new System.Drawing.Point(253, 495);
            this.forecastLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(128, 34);
            this.forecastLabel.TabIndex = 41;
            this.forecastLabel.Text = "Forcast";
            this.forecastLabel.Click += new System.EventHandler(this.forecastLabel_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.Black;
            this.dateLabel.Location = new System.Drawing.Point(43, 476);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(44, 25);
            this.dateLabel.TabIndex = 42;
            this.dateLabel.Text = "Min";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(276, 207);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // currentOutput
            // 
            this.currentOutput.BackColor = System.Drawing.Color.Transparent;
            this.currentOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 64.8F, System.Drawing.FontStyle.Bold);
            this.currentOutput.Location = new System.Drawing.Point(60, 80);
            this.currentOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentOutput.Name = "currentOutput";
            this.currentOutput.Size = new System.Drawing.Size(315, 233);
            this.currentOutput.TabIndex = 52;
            this.currentOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // backColorLabel
            // 
            this.backColorLabel.BackColor = System.Drawing.Color.Black;
            this.backColorLabel.ForeColor = System.Drawing.Color.Coral;
            this.backColorLabel.Location = new System.Drawing.Point(627, 46);
            this.backColorLabel.Name = "backColorLabel";
            this.backColorLabel.Size = new System.Drawing.Size(355, 453);
            this.backColorLabel.TabIndex = 44;
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.BackColor = System.Drawing.Color.Transparent;
            this.xLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.xLabel.Location = new System.Drawing.Point(929, 63);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(33, 32);
            this.xLabel.TabIndex = 45;
            this.xLabel.Text = "X";
            this.xLabel.Click += new System.EventHandler(this.xLabel_Click);
            // 
            // humidityLabel
            // 
            this.humidityLabel.AutoSize = true;
            this.humidityLabel.BackColor = System.Drawing.Color.Transparent;
            this.humidityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humidityLabel.Location = new System.Drawing.Point(648, 140);
            this.humidityLabel.Name = "humidityLabel";
            this.humidityLabel.Size = new System.Drawing.Size(106, 29);
            this.humidityLabel.TabIndex = 46;
            this.humidityLabel.Text = "Humidity";
            // 
            // sunriseLabel
            // 
            this.sunriseLabel.AutoSize = true;
            this.sunriseLabel.BackColor = System.Drawing.Color.Transparent;
            this.sunriseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunriseLabel.Location = new System.Drawing.Point(648, 241);
            this.sunriseLabel.Name = "sunriseLabel";
            this.sunriseLabel.Size = new System.Drawing.Size(110, 29);
            this.sunriseLabel.TabIndex = 47;
            this.sunriseLabel.Text = "Sun Rise";
            // 
            // sunsetLabel
            // 
            this.sunsetLabel.AutoSize = true;
            this.sunsetLabel.BackColor = System.Drawing.Color.Transparent;
            this.sunsetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunsetLabel.Location = new System.Drawing.Point(648, 346);
            this.sunsetLabel.Name = "sunsetLabel";
            this.sunsetLabel.Size = new System.Drawing.Size(97, 29);
            this.sunsetLabel.TabIndex = 48;
            this.sunsetLabel.Text = "Sun Set";
            // 
            // lastUpdateLabel
            // 
            this.lastUpdateLabel.AutoSize = true;
            this.lastUpdateLabel.BackColor = System.Drawing.Color.Transparent;
            this.lastUpdateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastUpdateLabel.Location = new System.Drawing.Point(648, 442);
            this.lastUpdateLabel.Name = "lastUpdateLabel";
            this.lastUpdateLabel.Size = new System.Drawing.Size(155, 29);
            this.lastUpdateLabel.TabIndex = 49;
            this.lastUpdateLabel.Text = "Last Updated";
            // 
            // moreInfoLabel
            // 
            this.moreInfoLabel.AutoSize = true;
            this.moreInfoLabel.BackColor = System.Drawing.Color.Transparent;
            this.moreInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moreInfoLabel.Location = new System.Drawing.Point(736, 63);
            this.moreInfoLabel.Name = "moreInfoLabel";
            this.moreInfoLabel.Size = new System.Drawing.Size(132, 32);
            this.moreInfoLabel.TabIndex = 50;
            this.moreInfoLabel.Text = "More Info";
            // 
            // currentConditionsLabel
            // 
            this.currentConditionsLabel.AutoSize = true;
            this.currentConditionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentConditionsLabel.Location = new System.Drawing.Point(131, 244);
            this.currentConditionsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentConditionsLabel.Name = "currentConditionsLabel";
            this.currentConditionsLabel.Size = new System.Drawing.Size(135, 25);
            this.currentConditionsLabel.TabIndex = 53;
            this.currentConditionsLabel.Text = "Heavy Clouds";
            this.currentConditionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.searchLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.searchLabel.Location = new System.Drawing.Point(295, 27);
            this.searchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(75, 25);
            this.searchLabel.TabIndex = 55;
            this.searchLabel.Text = "Search";
            this.searchLabel.Click += new System.EventHandler(this.searchLabel_Click);
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.moreInfoLabel);
            this.Controls.Add(this.lastUpdateLabel);
            this.Controls.Add(this.sunsetLabel);
            this.Controls.Add(this.sunriseLabel);
            this.Controls.Add(this.humidityLabel);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.backColorLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.cityOutput);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.currentConditionsLabel);
            this.Controls.Add(this.currentOutput);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(1209, 554);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label currentOutput;
        private System.Windows.Forms.Label backColorLabel;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label humidityLabel;
        private System.Windows.Forms.Label sunriseLabel;
        private System.Windows.Forms.Label sunsetLabel;
        private System.Windows.Forms.Label lastUpdateLabel;
        private System.Windows.Forms.Label moreInfoLabel;
        private System.Windows.Forms.Label currentConditionsLabel;
        private System.Windows.Forms.Label searchLabel;
    }
}
