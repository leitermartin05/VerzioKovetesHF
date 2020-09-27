using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerzioKovetesHF
{
    class Program
    {
        static void Main(string[] args)
        {
            int mennyi;
            Console.WriteLine("Adja meg, hány számot szeretne megadni: ");
            mennyi = Convert.ToInt32(Console.ReadLine());
            int[] tomb = new int[mennyi];
            for (int i = 0; i < mennyi; i++)
            {
                Console.WriteLine("Kérem, adjon megy egy számot: ");
                tomb[i]= Convert.ToInt32(Console.ReadLine());

            }

            int atlag=0;
            for (int i = 0; i < mennyi; i++)
            {
                atlag += tomb[i];
            }
            atlag = atlag / mennyi;
            Console.WriteLine("A számok átlaga: "+atlag);

            Console.WriteLine("A legnagyobb szám a(z) {0}, a legkisebb pedig a(z) {1}",tomb.Max(),tomb.Min());
            Console.ReadKey();
            
        }

        

      
    }
}
