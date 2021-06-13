namespace Astrology_Project
{
    partial class CalculateMoonSign
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
            this.cbmDay = new System.Windows.Forms.ComboBox();
            this.cbmMonth = new System.Windows.Forms.ComboBox();
            this.cbmYear = new System.Windows.Forms.ComboBox();
            this.cbmHour = new System.Windows.Forms.ComboBox();
            this.cbmminute = new System.Windows.Forms.ComboBox();
            this.btnCalcutateMoon = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbmDay
            // 
            this.cbmDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmDay.FormattingEnabled = true;
            this.cbmDay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cbmDay.Location = new System.Drawing.Point(24, 91);
            this.cbmDay.Margin = new System.Windows.Forms.Padding(2);
            this.cbmDay.Name = "cbmDay";
            this.cbmDay.Size = new System.Drawing.Size(92, 25);
            this.cbmDay.TabIndex = 1;
            this.cbmDay.Text = "Enter Day";
            // 
            // cbmMonth
            // 
            this.cbmMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmMonth.FormattingEnabled = true;
            this.cbmMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cbmMonth.Location = new System.Drawing.Point(24, 120);
            this.cbmMonth.Margin = new System.Windows.Forms.Padding(2);
            this.cbmMonth.Name = "cbmMonth";
            this.cbmMonth.Size = new System.Drawing.Size(92, 25);
            this.cbmMonth.TabIndex = 2;
            this.cbmMonth.Text = "Enter Month";
            //this.cbmMonth.SelectedIndexChanged += new System.EventHandler(this.cbMonth_SelectedIndexChanged);
            // 
            // cbmYear
            // 
            this.cbmYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmYear.FormattingEnabled = true;
            this.cbmYear.Location = new System.Drawing.Point(24, 149);
            this.cbmYear.Margin = new System.Windows.Forms.Padding(2);
            this.cbmYear.Name = "cbmYear";
            this.cbmYear.Size = new System.Drawing.Size(92, 25);
            this.cbmYear.TabIndex = 3;
            this.cbmYear.Text = "Enter Year";
            // 
            // cbmHour
            // 
            this.cbmHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmHour.FormattingEnabled = true;
            this.cbmHour.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cbmHour.Location = new System.Drawing.Point(202, 91);
            this.cbmHour.Margin = new System.Windows.Forms.Padding(2);
            this.cbmHour.Name = "cbmHour";
            this.cbmHour.Size = new System.Drawing.Size(108, 25);
            this.cbmHour.TabIndex = 4;
            this.cbmHour.Text = "Enter hour";
            // 
            // cbmminute
            // 
            this.cbmminute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmminute.FormattingEnabled = true;
            this.cbmminute.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cbmminute.Location = new System.Drawing.Point(202, 120);
            this.cbmminute.Margin = new System.Windows.Forms.Padding(2);
            this.cbmminute.Name = "cbmminute";
            this.cbmminute.Size = new System.Drawing.Size(108, 25);
            this.cbmminute.TabIndex = 5;
            this.cbmminute.Text = "Enter minute";
            // 
            // btnCalcutateMoon
            // 
            this.btnCalcutateMoon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcutateMoon.Location = new System.Drawing.Point(121, 232);
            this.btnCalcutateMoon.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalcutateMoon.Name = "btnCalcutateMoon";
            this.btnCalcutateMoon.Size = new System.Drawing.Size(91, 25);
            this.btnCalcutateMoon.TabIndex = 6;
            this.btnCalcutateMoon.Text = "Calculate!";
            this.btnCalcutateMoon.UseVisualStyleBackColor = true;
            this.btnCalcutateMoon.Click += new System.EventHandler(this.btnCalcutateMoon_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(395, 414);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(68, 25);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Go Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // CalculateMoonSign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Astrology_Project.Properties.Resources.sun_moon_sign750_min1;
            this.ClientSize = new System.Drawing.Size(474, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCalcutateMoon);
            this.Controls.Add(this.cbmminute);
            this.Controls.Add(this.cbmHour);
            this.Controls.Add(this.cbmYear);
            this.Controls.Add(this.cbmMonth);
            this.Controls.Add(this.cbmDay);
            this.Name = "CalculateMoonSign";
            this.Text = "CalculateMoonSign";
            //this.Load += new System.EventHandler(this.CalculateMoonSign_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbmDay;
        private System.Windows.Forms.ComboBox cbmMonth;
        private System.Windows.Forms.ComboBox cbmYear;
        private System.Windows.Forms.ComboBox cbmHour;
        private System.Windows.Forms.ComboBox cbmminute;
        private System.Windows.Forms.Button btnCalcutateMoon;
        private System.Windows.Forms.Button btnBack;
    }
}