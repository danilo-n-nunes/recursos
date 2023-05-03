using System;
using System.Collections.Generic;

namespace Course {
    class Program {
        static void Main(string[] args) {

            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("bob");

            foreach (var item in list) {
                Console.WriteLine(item);
            }

            list.Insert(2, "Marco");

            foreach(var item in list) {
                Console.WriteLine(item);
            }
            Console.WriteLine("list count: " + list.Count);

            string s1 = list.Find(Test);
            Console.WriteLine(s1);

            string s2 = list.Find(x => x[0] == 'A');
            Console.WriteLine(s2);

            string s3 = list.FindLast(x => x[0] ==  'A');
            Console.WriteLine(s3);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position 'A': " + pos2);

            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("---------------------------------");
            foreach (string item in list2) { 
                Console.WriteLine(item); 
            }

            list.Remove("Alex");
            Console.WriteLine("-----------Removendo-------------");
            foreach (var item in list) {
                Console.WriteLine(item);
            }

            list.RemoveAll(x=> x[0] == 'M');
            Console.WriteLine("-----------Removendo-------------");
            foreach (var item in list) {
                Console.WriteLine(item);
            }

            list.RemoveAt(2);
            Console.WriteLine("-----------Removendo-------------");
            foreach (var item in list) {
                Console.WriteLine(item);
            }

            list.RemoveRange(2, 2);
            Console.WriteLine("-----------Removendo-------------");
            foreach (var item in list) {
                Console.WriteLine(item);
            }
        }

        static bool Test(string s) {
            return s[0] == 'A';
        }
    }
}