using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_The_Flag
{
    public class Flag
    {
        public string CountryName { get; set; } 
        public string ImagePath {  get; set; }

        public Flag(string countryName, string imagePath) { 

            CountryName = countryName;
            ImagePath = imagePath;
        }
    }
}
