using System;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n  ~~~~ Welcome to our bakery ~~~~\n");
            MyDictionary<string, float> myDictionary = new MyDictionary<string, float>();
            Console.WriteLine("Please enter the number of desserts to add");
            int numb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("___________________________________________________\n");
            for (int i = 1; i <= numb; i++)
            {
                Console.WriteLine("[" + i + "]  Please enter the dessert first, then the price");
                myDictionary.Add(Console.ReadLine(), float.Parse(Console.ReadLine()) );
            }
            Console.WriteLine("\n___________________________________________________\n");
            myDictionary.List();
        }
    }
}
