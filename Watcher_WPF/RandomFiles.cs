using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Watcher_WPF
{
	class RandomFiles
	{
        private static Random random = new Random();

        public static void GenerateFiles()
        {
            for (int x = 0; x < 30; x++)
            {
                StreamWriter w = new StreamWriter(@"d:\texts\text" + x.ToString() + ".txt");

                for (int i = 0; i < 10; i++)
                {
                    int randnum = random.Next(50);
                    if (randnum != 0)
                    {
                        w.WriteLine(RandomString(randnum));
                    }
                }

                w.Close();
            }
        }
        private static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
