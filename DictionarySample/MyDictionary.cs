using System;
using System.Collections.Generic;
using System.Text;

namespace DictionarySample
{
    class MyDictionary<T1,T2>
    {
        T1[] arrayKey;
        T2[] arrayValue;
        public MyDictionary()
        {
            arrayKey = new T1[0] ;
            arrayValue = new T2[0] ;
        }

        public void Add(T1 key, T2 value)
        {
            T1[] tempKey = arrayKey;
            T2[] tempValue = arrayValue;

            arrayKey = new T1[arrayKey.Length + 1];
            arrayValue = new T2[arrayValue.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                arrayKey[i] = tempKey[i];
                arrayValue[i] = tempValue[i];
            }

            arrayKey[arrayKey.Length - 1] = key;
            arrayValue[arrayValue.Length - 1] = value;
            
        }

        public T1[] Keys
        {
            get { return arrayKey; }
        }
        public T2[] Values
        {
            get { return arrayValue; }
        }
    }
}
