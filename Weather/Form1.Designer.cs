
namespace Weather
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lDeg = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LDateTime = new System.Windows.Forms.Label();
            this.LCityAndCountry = new System.Windows.Forms.Label();
            this.Ltemp = new System.Windows.Forms.Label();
            this.LDescription = new System.Windows.Forms.Label();
            this.LPressureAndHumidity = new System.Windows.Forms.Label();
            this.LSpeedVis = new System.Windows.Forms.Label();
            this.LSunrise = new System.Windows.Forms.Label();
            this.LSunset = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lDeg
            // 
            this.lDeg.AutoSize = true;
            this.lDeg.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lDeg.Location = new System.Drawing.Point(1247, 484);
            this.lDeg.Name = "lDeg";
            this.lDeg.Size = new System.Drawing.Size(75, 25);
            this.lDeg.TabIndex = 13;
            this.lDeg.Text = "label8";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::Weather.Properties.Resources._50n;
            this.pictureBox1.Location = new System.Drawing.Point(315, 194);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LDateTime
            // 
            this.LDateTime.AutoSize = true;
            this.LDateTime.BackColor = System.Drawing.Color.Transparent;
            this.LDateTime.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LDateTime.ForeColor = System.Drawing.Color.White;
            this.LDateTime.Location = new System.Drawing.Point(359, 9);
            this.LDateTime.Name = "LDateTime";
            this.LDateTime.Size = new System.Drawing.Size(122, 25);
            this.LDateTime.TabIndex = 17;
            this.LDateTime.Text = "DataAndTime";
            // 
            // LCityAndCountry
            // 
            this.LCityAndCountry.AutoSize = true;
            this.LCityAndCountry.BackColor = System.Drawing.Color.Transparent;
            this.LCityAndCountry.Font = new System.Drawing.Font("Segoe UI Semilight", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LCityAndCountry.ForeColor = System.Drawing.Color.White;
            this.LCityAndCountry.Location = new System.Drawing.Point(343, 48);
            this.LCityAndCountry.Name = "LCityAndCountry";
            this.LCityAndCountry.Size = new System.Drawing.Size(57, 35);
            this.LCityAndCountry.TabIndex = 18;
            this.LCityAndCountry.Text = "City";
            // 
            // Ltemp
            // 
            this.Ltemp.AutoSize = true;
            this.Ltemp.BackColor = System.Drawing.Color.Transparent;
            this.Ltemp.Font = new System.Drawing.Font("Segoe UI Semilight", 22.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ltemp.ForeColor = System.Drawing.Color.White;
            this.Ltemp.Location = new System.Drawing.Point(383, 90);
            this.Ltemp.Name = "Ltemp";
            this.Ltemp.Size = new System.Drawing.Size(188, 42);
            this.Ltemp.TabIndex = 19;
            this.Ltemp.Text = "Temperatura";
            // 
            // LDescription
            // 
            this.LDescription.AutoSize = true;
            this.LDescription.BackColor = System.Drawing.Color.Transparent;
            this.LDescription.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LDescription.ForeColor = System.Drawing.Color.White;
            this.LDescription.Location = new System.Drawing.Point(402, 138);
            this.LDescription.Name = "LDescription";
            this.LDescription.Size = new System.Drawing.Size(117, 30);
            this.LDescription.TabIndex = 20;
            this.LDescription.Text = "Description";
            // 
            // LPressureAndHumidity
            // 
            this.LPressureAndHumidity.AutoSize = true;
            this.LPressureAndHumidity.BackColor = System.Drawing.Color.Transparent;
            this.LPressureAndHumidity.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LPressureAndHumidity.ForeColor = System.Drawing.Color.White;
            this.LPressureAndHumidity.Location = new System.Drawing.Point(297, 413);
            this.LPressureAndHumidity.Name = "LPressureAndHumidity";
            this.LPressureAndHumidity.Size = new System.Drawing.Size(212, 30);
            this.LPressureAndHumidity.TabIndex = 21;
            this.LPressureAndHumidity.Text = "PressureAndHumidity";
            // 
            // LSpeedVis
            // 
            this.LSpeedVis.AutoSize = true;
            this.LSpeedVis.BackColor = System.Drawing.Color.Transparent;
            this.LSpeedVis.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LSpeedVis.ForeColor = System.Drawing.Color.White;
            this.LSpeedVis.Location = new System.Drawing.Point(237, 462);
            this.LSpeedVis.Name = "LSpeedVis";
            this.LSpeedVis.Size = new System.Drawing.Size(97, 30);
            this.LSpeedVis.TabIndex = 22;
            this.LSpeedVis.Text = "SpeedVis";
            // 
            // LSunrise
            // 
            this.LSunrise.AutoSize = true;
            this.LSunrise.BackColor = System.Drawing.Color.Transparent;
            this.LSunrise.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LSunrise.ForeColor = System.Drawing.Color.White;
            this.LSunrise.Location = new System.Drawing.Point(389, 503);
            this.LSunrise.Name = "LSunrise";
            this.LSunrise.Size = new System.Drawing.Size(80, 30);
            this.LSunrise.TabIndex = 23;
            this.LSunrise.Text = "Sunrise";
            // 
            // LSunset
            // 
            this.LSunset.AutoSize = true;
            this.LSunset.BackColor = System.Drawing.Color.Transparent;
            this.LSunset.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LSunset.ForeColor = System.Drawing.Color.White;
            this.LSunset.Location = new System.Drawing.Point(389, 541);
            this.LSunset.Name = "LSunset";
            this.LSunset.Size = new System.Drawing.Size(75, 30);
            this.LSunset.TabIndex = 24;
            this.LSunset.Text = "Sunset";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(865, 582);
            this.Controls.Add(this.LSunset);
            this.Controls.Add(this.LSunrise);
            this.Controls.Add(this.LSpeedVis);
            this.Controls.Add(this.LPressureAndHumidity);
            this.Controls.Add(this.LDescription);
            this.Controls.Add(this.Ltemp);
            this.Controls.Add(this.LCityAndCountry);
            this.Controls.Add(this.LDateTime);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lDeg);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lDeg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LDateTime;
        private System.Windows.Forms.Label LCityAndCountry;
        private System.Windows.Forms.Label Ltemp;
        private System.Windows.Forms.Label LDescription;
        private System.Windows.Forms.Label LPressureAndHumidity;
        private System.Windows.Forms.Label LSpeedVis;
        private System.Windows.Forms.Label LSunrise;
        private System.Windows.Forms.Label LSunset;
    }
}

