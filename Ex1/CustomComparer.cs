using System.Collections.Generic;

namespace Ex2
{
    public class CustomComparer : IComparer<Country>
    {
        public int Compare(Country x, Country y)
        {
            if (x.Capital.CompareTo(y.Capital) != 0)
                return x.Capital.CompareTo(y.Capital);
            return 0;
        }
    }
}