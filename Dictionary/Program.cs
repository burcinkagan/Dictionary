using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> word = new MyDictionary<string>();
            word.Add("araba");
            word.Add("boğaz");
            word.Add("cinsiyet");
            word.Add("deniz");
            word.Add("eşya");
            word.Count();

        }
    }
}
