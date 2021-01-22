using System;
using System.Collections.Generic;

namespace DictionarySample
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> Ogrenci1 = new Dictionary<string, string>();

            Ogrenci1.Add("Hoca", "Engin Demirog");
            Ogrenci1.Add("Öğrenci", "Emre Turan");

            Console.WriteLine(Ogrenci1["Hoca"]);

            Console.WriteLine("-------Benim Yapım-------");

            MyDictionary<string, string> Ogrenci2 = new MyDictionary<string, string>();

            Ogrenci2.Add("Hoca", "Engin Demirog");
            Ogrenci2.Add("Öğrenci", "Emre Turan");

            Console.WriteLine(Ogrenci2.Keys[0] +":"+ Ogrenci2.Values[0]);
            Console.WriteLine(Ogrenci2.Keys[1] +":"+ Ogrenci2.Values[1]);




        }
    }
}
