using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        { 
            // pole
            int[] pole = new int[10];
            pole[9] = 1;
            // list
            List<int> list = new List<int>();
            list.Add(1);
            list.Remove(1);
            list.RemoveAll((int i) => i == 1);
            list.RemoveAt(0);
            int hodnota = list[0];
            // stack
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            int hodnota2 = stack.Peek();
            int hodnota3 = stack.Pop();
            // queue
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
        }
    }
}
