namespace Astrology_Project
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btnZodiacSign = new System.Windows.Forms.Button();
            this.btnAsceningSign = new System.Windows.Forms.Button();
            this.btnMoonSign = new System.Windows.Forms.Button();
            this.btnDaily = new System.Windows.Forms.Button();
            this.btnMonthly = new System.Windows.Forms.Button();
            this.btnYearly = new System.Windows.Forms.Button();
            this.cbHoroscopeSign = new System.Windows.Forms.ComboBox();
            this.lblZodiac = new System.Windows.Forms.Label();
            this.lblMoon = new System.Windows.Forms.Label();
            this.lblAscending = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Astrology";
            // 
            // btnZodiacSign
            // 
            this.btnZodiacSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZodiacSign.Location = new System.Drawing.Point(20, 340);
            this.btnZodiacSign.Margin = new System.Windows.Forms.Padding(2);
            this.btnZodiacSign.Name = "btnZodiacSign";
            this.btnZodiacSign.Size = new System.Drawing.Size(156, 28);
            this.btnZodiacSign.TabIndex = 2;
            this.btnZodiacSign.Text = "Calculate Zodiac Sign";
            this.btnZodiacSign.UseVisualStyleBackColor = true;
            this.btnZodiacSign.Click += new System.EventHandler(this.btnZodiacSign_Click);
            // 
            // btnAsceningSign
            // 
            this.btnAsceningSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsceningSign.Location = new System.Drawing.Point(20, 405);
            this.btnAsceningSign.Margin = new System.Windows.Forms.Padding(2);
            this.btnAsceningSign.Name = "btnAsceningSign";
            this.btnAsceningSign.Size = new System.Drawing.Size(156, 28);
            this.btnAsceningSign.TabIndex = 3;
            this.btnAsceningSign.Text = "Calculate Ascending Sign";
            this.btnAsceningSign.UseVisualStyleBackColor = true;
            this.btnAsceningSign.Click += new System.EventHandler(this.btnAsceningSign_Click);
            // 
            // btnMoonSign
            // 
            this.btnMoonSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoonSign.Location = new System.Drawing.Point(20, 372);
            this.btnMoonSign.Margin = new System.Windows.Forms.Padding(2);
            this.btnMoonSign.Name = "btnMoonSign";
            this.btnMoonSign.Size = new System.Drawing.Size(156, 28);
            this.btnMoonSign.TabIndex = 4;
            this.btnMoonSign.Text = "Calculate Moon Sign";
            this.btnMoonSign.UseVisualStyleBackColor = true;
            this.btnMoonSign.Click += new System.EventHandler(this.btnMoonSign_Click);
            // 
            // btnDaily
            // 
            this.btnDaily.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaily.Location = new System.Drawing.Point(496, 10);
            this.btnDaily.Margin = new System.Windows.Forms.Padding(2);
            this.btnDaily.Name = "btnDaily";
            this.btnDaily.Size = new System.Drawing.Size(156, 28);
            this.btnDaily.TabIndex = 5;
            this.btnDaily.Text = "Daily Horoscope";
            this.btnDaily.UseVisualStyleBackColor = true;
            this.btnDaily.Click += new System.EventHandler(this.btnDaily_Click);
            // 
            // btnMonthly
            // 
            this.btnMonthly.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonthly.Location = new System.Drawing.Point(496, 42);
            this.btnMonthly.Margin = new System.Windows.Forms.Padding(2);
            this.btnMonthly.Name = "btnMonthly";
            this.btnMonthly.Size = new System.Drawing.Size(156, 28);
            this.btnMonthly.TabIndex = 6;
            this.btnMonthly.Text = "Monthly Horoscope";
            this.btnMonthly.UseVisualStyleBackColor = true;
            this.btnMonthly.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnYearly
            // 
            this.btnYearly.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYearly.Location = new System.Drawing.Point(496, 75);
            this.btnYearly.Margin = new System.Windows.Forms.Padding(2);
            this.btnYearly.Name = "btnYearly";
            this.btnYearly.Size = new System.Drawing.Size(156, 28);
            this.btnYearly.TabIndex = 7;
            this.btnYearly.Text = "Yearly Horoscope";
            this.btnYearly.UseVisualStyleBackColor = true;
            // 
            // cbHoroscopeSign
            // 
            this.cbHoroscopeSign.BackColor = System.Drawing.SystemColors.Window;
            this.cbHoroscopeSign.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cbHoroscopeSign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbHoroscopeSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHoroscopeSign.FormattingEnabled = true;
            this.cbHoroscopeSign.Items.AddRange(new object[] {
            "Aries",
            "Taurus",
            "Gemini",
            "Cancer",
            "Leo",
            "Virgo",
            "Libra",
            "Scorpio",
            "Sagittarius",
            "Capricorn",
            "Aquarius",
            "Pisces"});
            this.cbHoroscopeSign.Location = new System.Drawing.Point(9, 62);
            this.cbHoroscopeSign.Margin = new System.Windows.Forms.Padding(2);
            this.cbHoroscopeSign.Name = "cbHoroscopeSign";
            this.cbHoroscopeSign.Size = new System.Drawing.Size(157, 28);
            this.cbHoroscopeSign.TabIndex = 8;
            this.cbHoroscopeSign.Text = "Choose your sign!";
            this.cbHoroscopeSign.SelectedIndexChanged += new System.EventHandler(this.cbHoroscopeSign_SelectedIndexChanged);
            // 
            // lblZodiac
            // 
            this.lblZodiac.AutoSize = true;
            this.lblZodiac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZodiac.Location = new System.Drawing.Point(456, 345);
            this.lblZodiac.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblZodiac.Name = "lblZodiac";
            this.lblZodiac.Size = new System.Drawing.Size(141, 18);
            this.lblZodiac.TabIndex = 9;
            this.lblZodiac.Text = "Your zodiac sign is: ";
            this.lblZodiac.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblZodiac.Visible = false;
            // 
            // lblMoon
            // 
            this.lblMoon.AutoSize = true;
            this.lblMoon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoon.Location = new System.Drawing.Point(456, 377);
            this.lblMoon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMoon.Name = "lblMoon";
            this.lblMoon.Size = new System.Drawing.Size(136, 18);
            this.lblMoon.TabIndex = 10;
            this.lblMoon.Text = "Your moon sign is: ";
            this.lblMoon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMoon.Visible = false;
            // 
            // lblAscending
            // 
            this.lblAscending.AutoSize = true;
            this.lblAscending.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAscending.Location = new System.Drawing.Point(456, 410);
            this.lblAscending.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAscending.Name = "lblAscending";
            this.lblAscending.Size = new System.Drawing.Size(164, 18);
            this.lblAscending.TabIndex = 11;
            this.lblAscending.Text = "Your ascending sign is: ";
            this.lblAscending.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAscending.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(678, 474);
            this.Controls.Add(this.lblAscending);
            this.Controls.Add(this.lblMoon);
            this.Controls.Add(this.lblZodiac);
            this.Controls.Add(this.cbHoroscopeSign);
            this.Controls.Add(this.btnYearly);
            this.Controls.Add(this.btnMonthly);
            this.Controls.Add(this.btnDaily);
            this.Controls.Add(this.btnMoonSign);
            this.Controls.Add(this.btnAsceningSign);
            this.Controls.Add(this.btnZodiacSign);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnZodiacSign;
        private System.Windows.Forms.Button btnAsceningSign;
        private System.Windows.Forms.Button btnMoonSign;
        private System.Windows.Forms.Button btnDaily;
        private System.Windows.Forms.Button btnMonthly;
        private System.Windows.Forms.Button btnYearly;
        private System.Windows.Forms.ComboBox cbHoroscopeSign;
        private System.Windows.Forms.Label lblZodiac;
        private System.Windows.Forms.Label lblMoon;
        private System.Windows.Forms.Label lblAscending;
    }
}

