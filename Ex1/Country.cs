using System;

namespace Ex2
{
    public class Country:IComparable<Country>
    {
        public string Name { get; private set; }
        public string Capital { get; set; }

        public Country(string capital)
        {
            Capital = capital;
        }
   
        public Country(string name, string cap)
        {
            Name = name;
            Capital = cap;
        }
    
        public int CompareTo(Country country)
        {
            if (country == null) 
                return 1;
            return Name.CompareTo(country.Name);
        }

        public override string ToString()
        {
            return String.Format("The name of the country is {0} and the capital {1} ", Name, Capital);
        }
    }
}
