using System;
using System.Threading;

namespace Ex04.Menus.Test
{
    public class TesterDelegatesMethods
    {
        private const int k_ThreadSleepTime = 1500;

        public static void ShowVersion()
        {
            Console.WriteLine("Version: 21.1.4.8930");
            Thread.Sleep(k_ThreadSleepTime);
        }

        public static void CountSpaces()
        {
            int spacesAmount = 0;
            Console.WriteLine("Please enter a sentence");
            string userSentence = Console.ReadLine();
            foreach(char letter in userSentence)
            {
                if(char.IsWhiteSpace(letter))
                {
                    spacesAmount++;
                }
            }

            Console.WriteLine(@"There are {0} spaces in the sentence you entered.", spacesAmount);
            Thread.Sleep(k_ThreadSleepTime);
        }

        public static void ShowTime()
        {
            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss tt"));
            Thread.Sleep(k_ThreadSleepTime);
        }

        public static void ShowDate()
        {
            Console.WriteLine(DateTime.Now.ToString("dd/MM/yyyy"));
            Thread.Sleep(k_ThreadSleepTime);
        }
    }
}
