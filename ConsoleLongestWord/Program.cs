﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLongestWord {
    // Пусть функция LongestWord(sen) примет передаваемый параметр sen и вернет самое большое слово в строке.     
    class Program {
        public static string LongWord(string sen) {
            string[] word = sen.Split(' '); //записываем в строковый массив строку разбивая на пробелы
            return word.OrderByDescending(s => s.Length).First(); //сортируем по убыванию. Таким образом первый элемент будет наибольшим
        }
        static void Main() {
            Console.WriteLine(LongWord(Console.ReadLine()));
            Console.ReadKey();
        }
    }
}
