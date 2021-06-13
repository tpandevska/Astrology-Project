using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Astrology_Project
{
    public partial class ShowDailyHoroscope : Form
    {
        public ZodiacSign zodiacSign { get; set; }
        public DailyHoroscope dailyHoroscope { get; set; }
        public ShowDailyHoroscope()
        {
            InitializeComponent();

            dailyHoroscope = new DailyHoroscope();

        }

        private void ShowDailyHoroscop_Load(object sender, EventArgs e)
        {
            String zodiac = Form1.finalZodiac.ToString();
            lblDHname.Text = zodiac;
            lblDHname.BackColor = System.Drawing.Color.Transparent;
            lblDHname.ForeColor = System.Drawing.Color.White;
            lblDHname.Font = new Font("Arial", 24, FontStyle.Bold);
            lblDHtext.ForeColor = System.Drawing.Color.White;
            lblDHtext.BackColor = System.Drawing.Color.Transparent;
            lblDHtext.MaximumSize = new Size(300, 0);
            lblDHtext.AutoSize = true;

            DateTime date = DateTime.UtcNow;
            int day = date.Day;
            lblDHtext.Text = dailyHoroscope.getTodayHoroscope(day, zodiac);
        }
    }

}
