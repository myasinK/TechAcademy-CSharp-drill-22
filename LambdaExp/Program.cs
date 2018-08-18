using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<KeyValuePair<string, int>> list = new List<KeyValuePair<string, int>>();
            list.Add(new KeyValuePair<string, int>("Joe Smith", 1));
            list.Add(new KeyValuePair<string, int>("Jim Smith", 2));
            list.Add(new KeyValuePair<string, int>("Jack Smith", 3));
            list.Add(new KeyValuePair<string, int>("Beth Smith", 4));
            list.Add(new KeyValuePair<string, int>("Julie Smith", 5));
            list.Add(new KeyValuePair<string, int>("Sarah Smith", 6));
            list.Add(new KeyValuePair<string, int>("Mike Smith", 7));
            list.Add(new KeyValuePair<string, int>("Joe Stevens", 8));
            list.Add(new KeyValuePair<string, int>("Joe Flanders", 9));
            list.Add(new KeyValuePair<string, int>("El Smith", 10));
            list.Add(new KeyValuePair<string, int>("Kim Smith", 11));
            list.Add(new KeyValuePair<string, int>("Todd Smith", 12));
            //Console.WriteLine(list[0].Key.Split(' ')[0]);
            List<KeyValuePair<string, int>> newList_1 = new List<KeyValuePair<string, int>>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Key.Split(' ')[0] == "Joe")
                {
                    newList_1.Add(list[i]);
                    // Console.WriteLine(list[i]);
                }
            }

            // doing the same with a lambda function
            List<KeyValuePair<string, int>> newList_2 = new List<KeyValuePair<string, int>>();
            newList_2 = list.Where(x => x.Key.Split(' ')[0] == "Joe").ToList<KeyValuePair<string, int>>();
            Console.WriteLine("All Joes in the list:");
            foreach (KeyValuePair<string, int> employee in newList_2)
            {
                Console.WriteLine(employee);
            }

            // pick rows in list with id > 5
            List<KeyValuePair<string, int>> newList_3 = new List<KeyValuePair<string, int>>();
            newList_3 = list.Where(x => x.Value > 5).ToList<KeyValuePair<string, int>>();
            Console.WriteLine("\nEmployees with ID>5:");
            foreach (KeyValuePair<string, int> employee in newList_3)
            {                
                Console.WriteLine(employee);
            }
        }
    }
}
