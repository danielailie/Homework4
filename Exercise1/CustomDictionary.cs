using System.Collections.Generic;
using System.Linq;

namespace Exercise1
{
    public class CustomDictionary
    {
        private readonly List<CustomPair> elements=new List<CustomPair>();  
        public CustomPair Get(object key)
        {
            return elements.FirstOrDefault(element => element.Key.Equals(key));
        }

        public bool Put(object key, object value)
        {
            if (ContainsKey(key))
                return false;
            elements.Add(new CustomPair(key,value));
            return true;
        }

        public bool Remove(object key)
        {
            foreach (var element in elements)
            {
                if (ContainsKey(key))
                {
                    elements.Remove(element);
                    return true;
                }
            }
            return false;
        }

        public bool ContainsKey(object key)
        {
            return elements.Any(elem => elem.Key.Equals(key));
        }

        public int Count()
        {
            return elements.Count;
        }
    }
}