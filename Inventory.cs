using System;
using System.Collections.Generic;
using System.Security.AccessControl;

namespace TextAdventure
{
    public class Inventory
    {
        static List<string> dbItems = new List<string>();
        static string[] str = new string[10];

        int windowSize = 25;

        public void WriteBoard()
        {
            Inventory inv = new Inventory();
            Console.Clear();
            for (int i = 1; i <= windowSize; i++)
            {
                Console.SetCursorPosition(i, 1);
                Console.Write("-");
            }
            for (int i = 1; i <= windowSize; i++)
            {
                Console.SetCursorPosition(i, windowSize);
                Console.Write("-");
            }
            for (int i = 1; i <= windowSize; i++)
            {
                Console.SetCursorPosition(1, i);
                Console.Write("|");
            }

            for (int i = 0; i <= str.Length; i++)
            {
                Console.SetCursorPosition(5, 5);
                Console.WriteLine(String.Join("\n     ", str));
            }

            for (int i = 1; i <= windowSize; i++)
            {
                Console.SetCursorPosition(windowSize, i);
                Console.Write("|");
            }
        }

        public void AddItems(string x)
        {
            string itm = x;
            Inventory inv = new Inventory();
            //loop that increases size of array
            dbItems.Add(itm);
            
            str = dbItems.ToArray();
        }

        
    }
}