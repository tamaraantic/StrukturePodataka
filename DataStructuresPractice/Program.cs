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
            ArrayPerformanceTest apt=new ArrayPerformanceTest();
            LinkedListPerformanceTest llpt = new LinkedListPerformanceTest();
            HashsetPerformanceTest hpt = new HashsetPerformanceTest();
            apt.ExecuteTest();
            llpt.ExecuteTest();
            hpt.ExecuteTest();
          
        }
    }
    static class Constants
    {
        public static int EL_NUM = 1000000;
    }
    class PerformanceTest
    {
        public PerformanceTest()
        {
            var rand = new Random();
            Stopwatch timer = new Stopwatch();
        }
        public Stopwatch timer;
        public Random rand;

        public virtual long ExecuteTest()
        {
            return 0;
        }
        public virtual long ExecuteTest(int el_num)
        {
            return 0;
        }

    }
    class ArrayPerformanceTest : PerformanceTest
    {
        public ArrayPerformanceTest()
        {
            rand = new Random();
            timer = new Stopwatch();
        }
        public override long ExecuteTest()
        {
            int[] array = new int[Constants.EL_NUM];

            timer.Start();
            for (int i = 0; i < Constants.EL_NUM; i++)
            {
                array[i] = rand.Next();
            }
            timer.Stop();

            Console.WriteLine("Dodavanje 1M elemenata u niz je trajalo= " + timer.ElapsedMilliseconds.ToString() + "ms");
           //Console.ReadLine();
            return timer.ElapsedMilliseconds;
        }
        public override long ExecuteTest(int el_num)
        {
            int[] array = new int[el_num];

            timer.Start();
            for (int i = 0; i < el_num; i++)
            {
                array[i] = rand.Next();
            }
            timer.Stop();

            Console.WriteLine("Dodavanje " + el_num + " elemenata u niz je trajalo= " + timer.ElapsedMilliseconds.ToString() + "ms");
            //Console.ReadLine();
            return timer.ElapsedMilliseconds;
        }
    }
    class LinkedListPerformanceTest : PerformanceTest
    {
        public LinkedListPerformanceTest()
        {
            rand = new Random();
            timer = new Stopwatch();
        }
        public override long ExecuteTest()
        {
            //Dodavanje 1M elemenata u kolekciju.
            LinkedList<int> lList = new LinkedList<int>();

            timer.Start();
            for (int i = 0; i < Constants.EL_NUM; i++)
            {
                lList.AddLast(rand.Next());
            }
            timer.Stop();

            Console.WriteLine("Dodavanje 1M elemenata u listu je trajalo= " + this.timer.ElapsedMilliseconds.ToString() + "ms");
            //Console.ReadLine();
            return timer.ElapsedMilliseconds;
        }
        public override long ExecuteTest(int el_num)
        { 
            LinkedList<int> lList = new LinkedList<int>();

            timer.Start();
            for (int i = 0; i < el_num; i++)
            {
                lList.AddLast(rand.Next());
            }
            timer.Stop();

            Console.WriteLine("Dodavanje " + el_num + " elemenata u listu je trajalo= " + this.timer.ElapsedMilliseconds.ToString() + "ms");
            //Console.ReadLine();
            return timer.ElapsedMilliseconds;
        }
    }
    class HashsetPerformanceTest : PerformanceTest
    {
        public HashsetPerformanceTest()
        {
            rand = new Random();
            timer = new Stopwatch();
        }
        public override long ExecuteTest()
        {
            //Dodavanje 1M elemenata u kolekciju.
            HashSet<int> hash = new HashSet<int>();

            timer.Start();
            for (int i = 0; i < Constants.EL_NUM; i++)
            {
                hash.Add(rand.Next());
            }
            timer.Stop();

            Console.WriteLine("Dodavanje 1M elemenata u hashset je trajalo= " + timer.ElapsedMilliseconds.ToString() + "ms");
            Console.ReadLine();
            return timer.ElapsedMilliseconds;
        }
        public override long ExecuteTest(int el_num)
        {
            HashSet<int> hash = new HashSet<int>();

            timer.Start();
            for (int i = 0; i < el_num; i++)
            {
                hash.Add(rand.Next());
            }
            timer.Stop();

            Console.WriteLine("Dodavanje " + el_num +" elemenata u hashset je trajalo= "+ timer.ElapsedMilliseconds.ToString() + "ms");
            Console.ReadLine();
            return timer.ElapsedMilliseconds;
        }
    }
}