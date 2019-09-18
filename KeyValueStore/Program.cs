using System;
using System.Collections.Generic;

namespace KeyValueStore
{
    public struct KeyValue
    {
        public readonly string Key;
        public readonly object Value;

        public KeyValue(string x, object y)
        {
            Key = x;
            Value = y;
        }
                
    }
    public class MyDictionary
    {
        public KeyValue[] keyArray = new KeyValue[20];

        public int Counter = 0;
        public bool matchFound = false;
        
        public object this[string key]
        {
            set
            {
                bool matchFound = false;
                for (int i = 0; i < Counter; i++)
                {

                    if (keyArray[i].Key == key)
                    {
                        keyArray[i] = new KeyValue(key, value);
                        matchFound = true;
                    }

                    
                }
                if (matchFound == false)
                {
                    keyArray[Counter] = new KeyValue(key, value);
                    Counter++;
                }

            }
            get
            {
                
                for (int i = 0; i < keyArray.Length; i++)
                {
                    if (key == keyArray[i].Key)
                    {
                        
                        return keyArray[i].Value;


                    }
                    
                }
                
                throw new KeyNotFoundException();
                    
                
            }
        }



    }


      




    class Program
    {
        static void Main(string[] args)
        {
            var d = new MyDictionary();
            try
            {
                Console.WriteLine(d["Cats"]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            d["Cats"] = 42;
            d["Dogs"] = 17;
            Console.WriteLine($"{(int)d["Cats"]}, {(int)d["Dogs"]}");
        }
    }
}
