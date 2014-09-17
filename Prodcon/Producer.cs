using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodcon
{
    class Producer
    {
        
        public void run()
        {
            for (int i = 0; i < UPPER; i++)
            {
                Console.WriteLine("Producer added to buffer");
            }
         
        }
    }
}
