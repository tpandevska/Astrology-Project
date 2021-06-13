namespace Astrology_Project
{
    partial class ShowDailyHoroscope
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
            this.lblDHname = new System.Windows.Forms.Label();
            this.lblDHtext = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDHname
            // 
            this.lblDHname.AutoSize = true;
            this.lblDHname.Location = new System.Drawing.Point(208, 203);
            this.lblDHname.Name = "lblDHname";
            this.lblDHname.Size = new System.Drawing.Size(35, 13);
            this.lblDHname.TabIndex = 0;
            this.lblDHname.Text = "label1";
            // 
            // lblDHtext
            // 
            this.lblDHtext.AutoSize = true;
            this.lblDHtext.Location = new System.Drawing.Point(492, 266);
            this.lblDHtext.Name = "lblDHtext";
            this.lblDHtext.Size = new System.Drawing.Size(35, 13);
            this.lblDHtext.TabIndex = 1;
            this.lblDHtext.Text = "label1";
            // 
            // ShowDailyHoroscop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Astrology_Project.Properties.Resources.Daily_Horoscope_Astrology;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDHtext);
            this.Controls.Add(this.lblDHname);
            this.Name = "ShowDailyHoroscop";
            this.Text = "ShowDailyHoroscop";
            this.Load += new System.EventHandler(this.ShowDailyHoroscop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDHname;
        private System.Windows.Forms.Label lblDHtext;
    }
}