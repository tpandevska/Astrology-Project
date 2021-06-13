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
    public partial class CalculateMoonSign : Form
    {
        public MoonSign moonSign { get; set; }
        public CalculateMoonSign()
        {
            InitializeComponent();

            for (int i = 1960; i < 2021; i++)
            {
                cbmYear.Items.Add(i);
            }
            moonSign = new MoonSign();
        }

        private void btnCalcutateMoon_Click(object sender, EventArgs e)
        {
            if (cbmDay.SelectedIndex == -1 || cbmMonth.SelectedIndex == -1 || cbmYear.SelectedIndex == -1 || cbmHour.SelectedIndex == -1 || cbmminute.SelectedIndex == -1)
            {
                MessageBox.Show("Please insert a valid date");
                return;
            }

            int day = Convert.ToInt16(cbmDay.SelectedIndex + 1);
            int month = Convert.ToInt16(cbmMonth.SelectedIndex + 1);
            int year = Convert.ToInt32(cbmYear.SelectedItem);
            int hour = Convert.ToInt32(cbmHour.SelectedItem);
            int minute = Convert.ToInt32(cbmminute.SelectedItem);

            int value = (day + month + year + hour + minute) % 12;
            moonSign.setZodiac(value);
            MessageBox.Show("Your moon zodiac sign is: " + moonSign.sign);

            DialogResult = DialogResult.OK;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

    }
}
