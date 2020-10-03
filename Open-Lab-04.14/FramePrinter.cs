using System;

namespace Open_Lab_04._14
{
    public class FramePrinter
    {
        public void Print(string[] strings)
        {
            string sideFrame = "";
            int longest = 0;

            foreach (string word in strings)
            {
                if (longest < word.Length)
                    longest = word.Length;
            }

            for (int i = 0; i < longest + 4; i++)
            {
                sideFrame += "*";
            }

            Console.WriteLine(sideFrame);

            foreach(string word in strings)
            {
                if (word.Length < longest)
                {
                    string afterWord = "";
                    for(int i = 0; i < longest - word.Length; i++)
                    {
                        afterWord += " ";
                    }
                    Console.WriteLine("* " + word + afterWord +" *");
                }
                else
                    Console.WriteLine("* " + word + " *");
            }

            Console.WriteLine(sideFrame);
        }
    }
}