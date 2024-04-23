using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csukol3
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            Console.WriteLine("Zadejte prikaz");
            string prikaz = Console.ReadLine();
            Console.WriteLine("Zadejte hodnotu");
            string a = Console.ReadLine();
            if (prikaz == "pridat")
            {
                queue.Enqueue(a);
            } else if (prikaz == )
        }
    }
}
