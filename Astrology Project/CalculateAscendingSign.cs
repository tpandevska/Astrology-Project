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
    public partial class CalculateAscendingSign : Form
    {
        public AscendingSign ascendingSign { get; set; }
        public CalculateAscendingSign()
        {
            InitializeComponent();

            for (int i = 1960; i < 2021; i++)
            {
                cbaYear.Items.Add(i);
            }
            ascendingSign = new AscendingSign();
        }

        private void btnCalculateAscending_Click(object sender, EventArgs e)
        {
            if (cbaDay.SelectedIndex == -1 || cbaMonth.SelectedIndex == -1 || cbaYear.SelectedIndex == -1 || cbaHour.SelectedIndex == -1 || cbaminute.SelectedIndex == -1)
            {
                MessageBox.Show("Please insert a valid date");
                return;
            }

            int day = Convert.ToInt16(cbaDay.SelectedIndex + 1);
            int month = Convert.ToInt16(cbaMonth.SelectedIndex + 1);
            int year = Convert.ToInt32(cbaYear.SelectedItem);
            int hour = Convert.ToInt32(cbaHour.SelectedItem);
            int minute = Convert.ToInt32(cbaminute.SelectedItem);

            int value = (day * month * year * hour * minute) % 12;
            ascendingSign.setZodiac(value);
            MessageBox.Show("Your ascending zodiac sign is: " + ascendingSign.sign);

            DialogResult = DialogResult.OK;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
