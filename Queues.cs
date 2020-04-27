using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport_guidance
{
    //Jeg ved ikke hvor de skal være så har sat dem her for nu 
    class Queues
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();

            q.Enqueue(“toilet”);
            q.Enqueue(“shop”);
            q.Enqueue(“food”);
            q.Enqueue(“info”);
            q.Enqueue(“gate ”);
            q.Enqueue(“gate 1”);
            q.Enqueue(“gate 2”);
            q.Enqueue(“gate 3”);
            q.Enqueue(“gate 4”);
            q.Enqueue(“gate 5”);
            q.Enqueue(“gate 6”);
            q.Enqueue(“gate 7”);
            q.Enqueue(“gate 8”);
            q.Enqueue(“gate 9”);
            q.Enqueue(“gate 10”);
            q.Enqueue(“gate 11”);

            foreach (Object obj in q)
            {
                Console.WriteLine(obj);
            }
            {
                Console.ReadKey();
            }
        }
    }
}
