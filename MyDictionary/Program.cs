using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> kisi = new MyDictionary<int, string>();
            kisi.Add(1, "Gülben");
            kisi.Add(2, "Bilge");
            kisi.Add(3, "Erdem");
            kisi.Add(4, "Gülşen");
            kisi.Add(5, "Mustafa");
            kisi.Add(6, "Merve");
            kisi.Add(7, "Zeki");


        }
    }
}
