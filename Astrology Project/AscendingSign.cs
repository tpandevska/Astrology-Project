using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astrology_Project
{
    public class AscendingSign
    {
        public String sign { get; set; }
        public static readonly List<String> Signs = new List<String> {
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
            "Pisces"
        };

        public DateTime dateOfBirth { get; set; }
        public int hour { get; set; }
        public int minute { get; set; }


        public AscendingSign()
        {

        }


        public void setZodiac(int calculatedValue)
        {
            if (calculatedValue == 0)
            {
                this.sign = Signs[0];
            }
            else if (calculatedValue == 1)
            {
                this.sign = Signs[1];
            }
            else if (calculatedValue == 2)
            {
                this.sign = Signs[2];
            }
            else if (calculatedValue == 3)
            {
                this.sign = Signs[3];
            }
            else if (calculatedValue == 4)
            {
                this.sign = Signs[4];
            }
            else if (calculatedValue == 5)
            {
                this.sign = Signs[5];
            }
            else if (calculatedValue == 6)
            {
                this.sign = Signs[6];
            }
            else if (calculatedValue == 7)
            {
                this.sign = Signs[7];
            }
            else if (calculatedValue == 8)
            {
                this.sign = Signs[8];
            }
            else if (calculatedValue == 9)
            {
                this.sign = Signs[9];
            }
            else if (calculatedValue == 10)
            {
                this.sign = Signs[10];
            }
            else if (calculatedValue == 11)
            {
                this.sign = Signs[11];
            }

            else
            {
                sign = "Invalid date";
            }

        }


    }
}

