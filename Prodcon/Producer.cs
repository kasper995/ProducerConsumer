using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodcon
{
    class Producer
    {
        private int _max;

        private Boundedbuffer _buffer;
        public Producer(Boundedbuffer buffer, int howManyToProduce)
        {
            this._max = howManyToProduce;
            this._buffer = buffer;
        }

        public void run()
        {
            for (int i = 0; i < this._max; i++)
            {
                
                
                    this._buffer.Put(i);
                   
                
            }

        }
    }
}
