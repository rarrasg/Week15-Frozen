using System;
using System.Collections.Generic;
using System.IO;

namespace Frozen
{
    class Program
    {


        class Wishes
        {
            string character;
            string wish;

            public Wishes(string _character, string _wish)
            {
                character = _character;
                wish = _wish;
            }

            public string Character
            {
                get { return character; }
            }

            public string Wish
            {
                get { return wish; }
            }

        }

        static void Main(string[] args)
        {
            List<Wishes> myWishes = new List<Wishes>();
            string[] wishesFromFile = GetDataFromFile();

            foreach (string line in wishesFromFile)
            {
                string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                Wishes newWishes = new Wishes(tempArray[0], tempArray[1]);
                myWishes.Add(newWishes);
            }

            foreach (Wishes wishesFromList in myWishes   )
            {
                Console.WriteLine($"{wishesFromList.Character} wants {wishesFromList.Wish} for christmas.");
            }
        }

        public static string[] GetDataFromFile()
        {
            string filePath = @"C:\Users\...\samples\frozen.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);

            return dataFromFile;
        }
    }
}
