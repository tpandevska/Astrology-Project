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
    public partial class CalculateZodiacSign : Form
    {
        public ZodiacSign zodiacSign { get; set; }

        public CalculateZodiacSign()
        {
            InitializeComponent();

            for (int i = 1960; i < 2021; i++)
            {
                cbYear.Items.Add(i);
            }

            zodiacSign = new ZodiacSign();

        }

        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbDay.SelectedIndex == -1 || cbMonth.SelectedIndex == -1 || cbYear.SelectedIndex == -1) {
                MessageBox.Show("Please insert a valid date");
                return;
            }
       
            int day = Convert.ToInt16(cbDay.SelectedIndex + 1);
            int month = Convert.ToInt16(cbMonth.SelectedIndex + 1);
            int year = Convert.ToInt32(cbYear.SelectedItem);

            DateTime date = new DateTime(year, month, day);
            zodiacSign.setZodiac(date);
            MessageBox.Show("Your zodiac sign is: " + zodiacSign.sign);

            DialogResult = DialogResult.OK;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void CalculateZodiacSign_Load(object sender, EventArgs e)
        {
           
        }
    }
}

