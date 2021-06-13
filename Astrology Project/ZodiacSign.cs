using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astrology_Project
{
    public class ZodiacSign
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


        public ZodiacSign()
        {

        }


        public void setZodiac(DateTime dateOfBirth)
        {
            if ((dateOfBirth.Month == 3 && dateOfBirth.Day >= 20) || (dateOfBirth.Month == 4 && dateOfBirth.Day <= 19))
            {
                this.sign = Signs[0];
            }
            else if ((dateOfBirth.Date.Month == 4 && dateOfBirth.Day >= 20) || (dateOfBirth.Month == 5 && dateOfBirth.Day <= 20))
            {
                this.sign = Signs[1];
            }
            else if ((dateOfBirth.Date.Month == 5 && dateOfBirth.Day >= 21) || (dateOfBirth.Month == 6 && dateOfBirth.Day <= 20))
            {
                this.sign = Signs[2];
            }
            else if ((dateOfBirth.Date.Month == 6 && dateOfBirth.Day >= 21) || (dateOfBirth.Month == 7 && dateOfBirth.Day <= 22))
            {
                this.sign = Signs[3];
            }
            else if ((dateOfBirth.Month == 7 && dateOfBirth.Day >= 23) || (dateOfBirth.Month == 8 && dateOfBirth.Day <= 22))
            {
                this.sign = Signs[4];
            }
            else if ((dateOfBirth.Month == 8 && dateOfBirth.Day >= 23) || (dateOfBirth.Month == 9 && dateOfBirth.Day <= 22))
            {
                this.sign = Signs[5];
            }
            else if ((dateOfBirth.Month == 9 && dateOfBirth.Day >= 23) || (dateOfBirth.Month == 10 && dateOfBirth.Day <= 22))
            {
                this.sign = Signs[6];
            }
            else if ((dateOfBirth.Month == 10 && dateOfBirth.Day >= 23) || (dateOfBirth.Month == 11 && dateOfBirth.Day <= 21))
            {
                this.sign = Signs[7];
            }
            else if ((dateOfBirth.Month == 11 && dateOfBirth.Day >= 22) || (dateOfBirth.Month == 12 && dateOfBirth.Day <= 21))
            {
                this.sign = Signs[8];
            }
            else if ((dateOfBirth.Month == 12 && dateOfBirth.Day >= 22) || (dateOfBirth.Month == 1 && dateOfBirth.Day <= 19))
            {
                this.sign = Signs[9];
            }
            else if ((dateOfBirth.Month == 1 && dateOfBirth.Day >= 20) || (dateOfBirth.Month == 2 && dateOfBirth.Day <= 17))
            {
                this.sign = Signs[10];
            }
            else if ((dateOfBirth.Month == 2 && dateOfBirth.Day >= 18) || (dateOfBirth.Month == 3 && dateOfBirth.Day <= 19))
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
