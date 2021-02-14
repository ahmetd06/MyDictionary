using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDictionary<string, int> myDictionary = new MyDictionary<string, int>();

            myDictionary.Add("Ahmet", 5);
            myDictionary.Add("Hakan", 6);

            
        }
    }
}
