using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodcon
{
    class Consumer
    {
        public void Run()
        {
            for (int i = 0; i < UPPER; i++)
            {
                Console.WriteLine("Comsumer added to buffer");
            }
            
        }
    }
}
