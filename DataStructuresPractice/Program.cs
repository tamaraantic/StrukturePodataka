using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DataStructuresPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            Pocetak:
            Console.WriteLine("1.Testiraj niz.      2.Testiraj listu.     3.Testiraj hashset");
            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    MeasureArrayPerformance();
                    break;
                case "2":
                    MeasureLinkedListPerformance();
                    break;
                case "3":
                    MeasureHashsetPerformance();
                    break;
                default:
                    Console.WriteLine("Izaberite broj 1-3!");
                    goto Pocetak;
                    break;
            }
        }

        static void MeasureArrayPerformance()
        {
            //Dodavanje 1M elemenata u kolekciju.
            int[] array = new int[1000000];
            var rand = new Random();
            Stopwatch timer = new Stopwatch();
       
            timer.Start();
            for (int i=0; i<1000000; i++)
            {
                array[i] = rand.Next();
            }
            timer.Stop();

            Console.WriteLine("Dodavanje 1M elemenata u niz je trajalo= " + timer.ElapsedMilliseconds.ToString() + "ms");
            Console.ReadLine();
        }

        static void MeasureLinkedListPerformance()
        {
            //Dodavanje 1M elemenata u kolekciju.
            LinkedList<int> lList = new LinkedList<int>();
            var rand = new Random();
            Stopwatch timer1 = new Stopwatch();

            timer1.Start();
            for (int i = 0; i < 1000000; i++)
            {
                lList.AddLast(rand.Next());
            }
            timer1.Stop();

            Console.WriteLine("Dodavanje 1M elemenata u listu je trajalo= " + timer1.ElapsedMilliseconds.ToString() + "ms");
            Console.ReadLine();

        }
        static void MeasureHashsetPerformance()
        {
            //Dodavanje 1M elemenata u kolekciju.
            HashSet<int> hash = new HashSet<int>();
            var rand = new Random();
            Stopwatch timer2 = new Stopwatch();

            timer2.Start();
            for (int i = 0; i < 1000000; i++)
            {
                hash.Add(rand.Next());
            }
            timer2.Stop();

            Console.WriteLine("Dodavanje 1M elemenata u hashset je trajalo= " + timer2.ElapsedMilliseconds.ToString() + "ms");
            Console.ReadLine();

        }
    }
}

