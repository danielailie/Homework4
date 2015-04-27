using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise1;

namespace Exercise1Test
{
    [TestClass]
    public class CustomDictionaryTest
    {
        readonly CustomDictionary customDictionary=new CustomDictionary();

        [TestMethod]
        public void The_Get_Method_Returns_The_Element_With_The_Given_Key()
        {
            CreateDictionary(customDictionary);

            Assert.AreEqual(2,customDictionary.Get(2).Key);
        }

        [TestMethod]
        public void The_Put_Method_Returns_False_If_The_Key_Exists()
        {
            CreateDictionary(customDictionary);
           
            Assert.IsFalse(customDictionary.Put(2, "Image"));
        }

        [TestMethod]
        public void The_Put_Method_Returns_True_If_The_Key_Does_Not_Exists()
        {
            CreateDictionary(customDictionary);
            
            Assert.IsTrue(customDictionary.Put(5, "Image"));
        }

        [TestMethod]
        public void The_Remove_Method_Returns_False_If_The_Key_Does_Not_Exists()
        {
            CreateDictionary(customDictionary);
            Assert.IsFalse(customDictionary.Remove(4));
        }

        [TestMethod]
        public void The_Remove_Method_Returns_True_If_The_Key_Exists()
        {
            CreateDictionary(customDictionary);
            Assert.IsTrue(customDictionary.Remove(2));
        }

        [TestMethod]
        public void The_Count_Returns_The_Number_Of_Elements()
        {
            CreateDictionary(customDictionary);
            
            Assert.AreEqual(2,customDictionary.Count());
        }

        [TestMethod]
        public void The_ContainsKey_Returns_True_If_Contains_The_Key()
        {
            CreateDictionary(customDictionary);

            Assert.IsTrue(customDictionary.ContainsKey(2));
        }

        [TestMethod]
        public void The_ContainsKey_Returns_False_If_Does_Not_Contains_The_Key()
        {
            CreateDictionary(customDictionary);

            Assert.IsFalse(customDictionary.ContainsKey(6));
        }

        private static void CreateDictionary(CustomDictionary customDictionary)
        {
            customDictionary.Put(2, "Image");
            customDictionary.Put(3, "Cartoon");
        }
    }
}
