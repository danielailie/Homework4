using System;
using System.Collections.Generic;

namespace Ex2
{
    class Program
    {
        static void Main()
        {
            var countries = new List<Country>
            {
                new Country("Norway", "Oslo"),
                new Country("Montenegro", "Podgorica"),
                new Country("Cehia", "Praga"),
                new Country("Austria", "Wien"),
                new Country("France","Paris")
            };

            countries.Sort((x, y) => x.Capital.CompareTo(y.Capital));

            int index=countries.BinarySearch(new Country("Paris"), new CustomComparer());

            Console.WriteLine("The Country with The Capital Paris is on position: {0}",index);

            DisplayAllTheCountries(countries);
        }

        private static void DisplayAllTheCountries(List<Country> countries)
        {
            foreach (var country in countries)
            {
                Console.WriteLine(country.ToString());
            }
        }
    }
}
