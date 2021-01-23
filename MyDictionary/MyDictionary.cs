using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] keys;
        TValue[] values;
        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }

        public void Add(TKey key,TValue value)
        {
            TKey[] tempKeys = keys;
            TValue[] tempValues = values;

            keys = new TKey[keys.Length + 1];
            values = new TValue[values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
                //Console.WriteLine(keys[i]);
            }

            keys[keys.Length - 1] = key;

            for (int i = 0; i < tempValues.Length; i++)
            {
                values[i] = tempValues[i];
                //Console.WriteLine(values[i]);

            }

            values[values.Length - 1] = value;
            
            Console.WriteLine("ID :" + keys[keys.Length - 1] + "    Name :" + values[values.Length - 1]+"   listeye eklenmiştir!!!!!");
            Console.WriteLine("");


            Console.WriteLine("***********Yeni Liste***********");


            for (int i = 0; i < values.Length; i++)
            {
                
                Console.WriteLine("ID :"+keys[i]+"    Name :"+values[i]);
            }
            Console.WriteLine("***********Liste Sonu***********");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

        }
    }
}
