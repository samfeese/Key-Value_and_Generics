using System;
using System.Collections.Generic;
using System.Text;

namespace KeyValueStore
{
    class Generic_Key_Value
    {
        public struct KeyValueGeneric<TKey, TValue>
        {
            public readonly TKey Key;
            public readonly TValue Value;

            public KeyValueGeneric(TKey x, TValue y) 
            {
                Key = x;
                Value = y;
            }

        }
        public class MyDictionaryGenerics <TKey, TValue>
         
        {
            public KeyValueGeneric<TKey, TValue>[] keyArray = new KeyValueGeneric<TKey, TValue>[20]; 

            public int Counter = 0;
            public bool matchFound = false;

            public TValue this[ TKey key]
            {
                set
                {
                    bool matchFound = false;
                    for (int i = 0; i < Counter; i++)
                    {

                        if (keyArray[i].Key.Equals(key)) 
                        {
                            keyArray[i] = new KeyValueGeneric<TKey, TValue>(key, value);
                            matchFound = true;
                        }


                    }
                    if (matchFound == false)
                    {
                        keyArray[Counter] = new KeyValueGeneric<TKey, TValue>(key, value);
                        Counter++;
                    }

                }
                get
                {

                    for (int i = 0; i < keyArray.Length; i++)
                    {
                        if (keyArray[i].Key.Equals(key))
                        {

                            return keyArray[i].Value;


                        }

                    }

                    throw new KeyNotFoundException();


                }
            }
        }
    }
}
