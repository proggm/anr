using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace anr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = new string[10] { "Apple", "Microsoft", "Google", "Telegram", "Sapce X", "NASA", "Yandex", "Amazon","Instagram","Vektor"};
            Console.Write("Введите символ поиска: ");
           string item = (Console.ReadLine());
            Console.WriteLine(Find(item,words));
            Console.ReadKey();
        }
        static int Find(string item, string[] words)
        {
            int count = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].StartsWith(item))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
