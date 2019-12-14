using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartRateApp
{
    class HeartRateCalculator
    {
        public string Name { get; set; }
        public int BirthYear {get; set;}
        public int CurrentYear { get; set; }
        public int Age { get; set; }
        public int MaxRate { get; set; }
        public int LowRange { get; set; }
        public int HighRange { get; set; }

        public HeartRateCalculator(string name, int birthYear, int currentYear)
        {
            Name = name;

            if (birthYear < currentYear && birthYear > 1900)
            {
                BirthYear = birthYear;
            }

            CurrentYear = currentYear;

            Age = currentYear - birthYear;
        }

        public void CalculateMaxRate (int Age)
        {
            MaxRate = 220 - Age;
            LowRange = MaxRate * 50 / 100;
            HighRange = MaxRate * 85 / 100;       
        }
    }
}
