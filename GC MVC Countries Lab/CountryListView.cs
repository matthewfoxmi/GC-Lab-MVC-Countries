using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_MVC_Countries_Lab
{
    internal class CountryListView
    {
        public List<Country> Countries { get; set; }        
        
        //constructor
        public CountryListView(List<Country> countries)
        {
            Countries = countries;                    
        }

        //get index

        public void Display()
        {
            for (int i = 0; i < Countries.Count; i++)
            {
                Console.WriteLine(Countries[i].Name);
            }
        }
    }
}
