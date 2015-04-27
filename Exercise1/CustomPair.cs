namespace Exercise1
{
    public class CustomPair
    {
        public CustomPair(object key, object value)
        {
            Key = key;
            Value = value;
        }

        public object Key { get; private set; }
        public object Value { get; private set; }

         public override string ToString()
         {
             return string.Format("Key: {0}, Value: {1}", Key, Value);
         }
    }
}
