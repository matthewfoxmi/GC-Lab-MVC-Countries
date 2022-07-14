using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_MVC_Countries_Lab
{
    internal class CountryController
    {
        public List<Country> CountryDb = new List<Country>()
        {
            new Country("USA", "North America", new List<string> {"Red", "White", "Blue"}),
            new Country("Ireland", "Europe", new List<string> {"Green", "White", "Orange"}),
            new Country("United Kingdom", "Europe", new List<string> {"Blue", "White", "Red"}),
            new Country("Japan", "Asia", new List<string> {"Red", "White"}),
            new Country("China", "Asia", new List<string> {"Red", "Yellow"})
        };

        public CountryController()
        {

        }

        public void CountryAction(Country c)
        {
            CountryView country = new CountryView(c);
            country.Display();
        }

        public void WelcomeAction()
        {
            bool goAgain = true;
            while (goAgain)
            {
                CountryListView country = new CountryListView(CountryDb);
                Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list by typing 0-4:");
                country.Display();
                int choice = int.Parse(Console.ReadLine());


                Console.WriteLine("Would you like to learn about another Country? Type y/n");
                string input = Console.ReadLine().ToLower().Trim();

                if (input == "y")
                {

                }
                else if (input == "n")
                {
                    goAgain = false;
                }
                else
                {
                    Console.WriteLine("Please type y/n");
                }
            }
        }
    }
}
