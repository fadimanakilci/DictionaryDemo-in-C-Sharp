using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryDemo
{
    class MyDictionary<T1, T2>
    {
        T1[] desserts;
        T2[] prices;
        public MyDictionary()
        {
            desserts = new T1[0];
            prices = new T2[0];
        }
        public void Add(T1 dessert, T2 price)
        {
            T1[] tempArrayd = desserts;
            T2[] tempArrayp = prices;
            desserts = new T1[desserts.Length + 1];
            prices = new T2[prices.Length + 1];
            for (int i = 0; i < tempArrayp.Length; i++)
            {
                desserts[i] = tempArrayd[i];
                prices[i] = tempArrayp[i];

            }
            desserts[desserts.Length - 1] = dessert;
            prices[prices.Length - 1] = price;
        }
        public void List()
        {
            for (int i = 0; i < desserts.Length; i++)
            {
                Console.WriteLine(desserts[i] + "\t   ->\t" + prices[i]);
            }

        }
    }
}
