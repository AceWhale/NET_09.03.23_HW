﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._02._23_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> voc = new SortedDictionary<string, string>();
            voc.Add("Украина", "Ukraine");
            voc.Add("Польша", "Poland");
            voc.Add("Франция", "France");
            voc.Add("Германия", "Germany");
            Console.WriteLine("1. Show\n2. Search");
            Console.Write("Введите слово для поиска перевода/Enter the word for translate: ");
            string Word = Console.ReadLine();
            if (voc.ContainsKey(Word))
                Console.WriteLine(Word + " - " + voc[Word]);
            else if (voc.ContainsValue(Word))
                Console.WriteLine(Word + " - " + voc.First(x => x.Value == Word).Key);
            else
                Console.WriteLine("Данного слова нет в словаре");
        }
    }
}
