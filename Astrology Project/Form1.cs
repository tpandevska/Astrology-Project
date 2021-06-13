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
    public partial class Form1 : Form
    {
        public static string finalZodiac = "";
        public ZodiacSign myZodiac { get; set; }
        public MoonSign myMoonSign { get; set; }

        public AscendingSign myAscendingSign { get; set; }
        public Form1()
        {
            InitializeComponent();
            myZodiac = new ZodiacSign();
            myMoonSign = new MoonSign();
            myAscendingSign = new AscendingSign();
        }
          

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnZodiacSign_Click(object sender, EventArgs e)
        {
            CalculateZodiacSign form = new CalculateZodiacSign();
            DialogResult result = form.ShowDialog();
            if(result == DialogResult.OK)
            {
                myZodiac = form.zodiacSign;

                lblZodiac.Text = String.Format("Your zodiac sign is: {0}", form.zodiacSign.sign);
                lblZodiac.Visible = true;
                finalZodiac = form.zodiacSign.sign;

            }
        }

        private void cbHoroscopeSign_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbHoroscopeSign.SelectedIndex != -1)
            {
                lblZodiac.Text = String.Format("Your zodiac sign is: {0}", cbHoroscopeSign.SelectedItem);
                lblZodiac.Visible = true;
                finalZodiac = cbHoroscopeSign.SelectedItem.ToString();
               
            }
            else
                lblZodiac.Visible = false;
        }

        private void btnMoonSign_Click(object sender, EventArgs e)
        {
            CalculateMoonSign form = new CalculateMoonSign();
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                myMoonSign = form.moonSign;

                lblMoon.Text = String.Format("Your moon sign is: {0}", myMoonSign.sign);
                lblMoon.Visible = true;

            }
        }

        private void btnAsceningSign_Click(object sender, EventArgs e)
        {
            CalculateAscendingSign form = new CalculateAscendingSign();
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                myAscendingSign.sign = form.ascendingSign.sign.ToString();

                lblAscending.Text = String.Format("Your ascending sign is: {0}", myAscendingSign.sign);
                lblAscending.Visible = true;
            }
        }

        private void btnDaily_Click(object sender, EventArgs e)
        {
            ShowDailyHoroscope form = new ShowDailyHoroscope();
            DialogResult result = form.ShowDialog();
            if(result == DialogResult.OK)
            {

            }
        }
    }
}
