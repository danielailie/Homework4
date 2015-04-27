using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ex2;

namespace Ex2TestProject
{
    [TestClass]
    public class CountryTest
    {
        readonly List<Country> countries = new List<Country>
            {
                new Country("Norway", "Oslo"),
                new Country("Montenegro", "Podgorica"),
                new Country("Cehia", "Praga"),
                new Country("Austria", "Wien"),
                new Country("France","Paris")
            };

        [TestMethod]
        public void The_Sort_After_Name_Works_Properly()
        {
            countries.Sort();
            var expectedList = countries.OrderBy(x => x.Name);

            Assert.IsTrue(expectedList.SequenceEqual(countries));
        }

        [TestMethod]
        public void The_Sort_After_Capital_Works_Properly()
        {
            countries.Sort((x, y) => x.Capital.CompareTo(y.Capital));
            var expectedList = countries.OrderBy(x => x.Capital);

            Assert.IsTrue(expectedList.SequenceEqual(countries));
        }

        [TestMethod]
        public void The_BinarySearch_Returns_The_Index_Of_The_Country_With_The_Capital_Paris()
        {
            countries.Sort((x, y) => x.Capital.CompareTo(y.Capital));
            int index=countries.BinarySearch(new Country("Paris"), new CustomComparer());

            Assert.AreEqual(1,index);
        }
    }
}
