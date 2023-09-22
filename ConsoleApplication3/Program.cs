using System;
using System.Collections.Generic;

namespace ConsoleApplication3
{
    internal class Program
    {
        static List<string> Todolist = new List<string>();
        static int Count = 1;
        public static void Main(string[] args)
        {
            ShowTheContent();
            KeepAdding();
            for (int i = 0; i < Todolist.Count; i++)
            {
                Console.WriteLine($"Вот колличество твоих заданий на сегодня: {Count++} ");
                ShowTheContent();
                KeepAdding();
            }
        }

        static void AddTolist(string Input)
        {
            Todolist.Add(Input);
        }

        static void ShowTheContent()
        {
            foreach (string task in Todolist)
            {
                Console.WriteLine(task);
            }
        }

        static void KeepAdding()
        {
            Console.WriteLine("---------------\n Добавьте новую задачу");
            string Input = Console.ReadLine();
            AddTolist(Input);
            Console.WriteLine("---------------");
        }
    }
}