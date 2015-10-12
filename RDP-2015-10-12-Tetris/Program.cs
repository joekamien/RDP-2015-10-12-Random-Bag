using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDP_2015_10_12_Tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            Bag bag = new Bag();
            for(int i = 0; i < 50; i++)
            {
                Console.Write(bag.next());
            }
            Console.WriteLine();
        }
    }

    class Bag
    {
        private Stack<char> stack = new Stack<char>(7);
        private Random rng = new Random();

        public char next()
        {
            if (stack.Count() == 0) replenish();    

            return stack.Pop();
        }

        public void replenish()
        {
            List<char> ordered = new List<char>(new char[] { 'O', 'I', 'S', 'Z', 'L', 'J', 'T' });
            while (ordered.Count() > 0)
            {
                int pos = rng.Next(0, ordered.Count());
                stack.Push(ordered[pos]);
                ordered.RemoveAt(pos);
            }
        }

    }
}
