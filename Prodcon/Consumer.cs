using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodcon
{
    class Consumer
    {
        private Boundedbuffer _buffer;
        private int _max;
           
        public Consumer(Boundedbuffer buffer, int expectedAmount)
        {
            this._buffer = buffer;
            this._max = expectedAmount;
        }
        public void Run()
        {
            for (int i = 0; i < this._max; i++)
            {

               
                    int temp = this._buffer.Take();
                    
                

            }
            
        }
    }
}
