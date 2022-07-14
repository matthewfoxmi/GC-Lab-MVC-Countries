using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_MVC_Countries_Lab
{
    internal class CountryView
    {
        //properties

        public Country DisplayCountry { get; set; }


        //constructor

        public CountryView(Country _displaycountry)
        {
            DisplayCountry = _displaycountry;
        }

        public void Display()
        {
            Console.WriteLine($"Country Name:{DisplayCountry.Name}, Continent: {DisplayCountry.Continent}, Colors: {DisplayCountry.Colors}");            
        }
    }
}
