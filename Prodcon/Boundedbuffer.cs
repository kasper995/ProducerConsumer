using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Prodcon
{
    class Boundedbuffer
    {
        public Queue<int> queue = new Queue<int>();

        private int BoundedBuffer;
        public bool IsFull()
        {
            
            if (BoundedBuffer <= 4)
            {
                return true;
                
            }
            
        else
            {
                return false;
            }
       }

        public int Put()
        {
            queue.Enqueue(0);
        }

        public int Take()
        {
            queue.Dequeue();
        }

        public int read()
        {
            queue.Peek();
        }

    

    }
}
