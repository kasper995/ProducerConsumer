using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Prodcon
{
    class Boundedbuffer
    {
        private int _cap;
        private Queue<int> _queue;


        public Boundedbuffer(int capacity)
        {
            _cap = capacity;
            this._queue = new Queue<int>(capacity);
        }



        public bool IsFull()
        {

            if (_queue.Count >= _cap)
            {
                return true;

            }
            else
            {
                return false;
            }

            

        }

        
        public void Put(int element)
        {
            lock (_queue)
            {
                while (IsFull())
                {
                    Monitor.Wait(_queue);
                }
                
                _queue.Enqueue(element);
                //Console.WriteLine("The value {0} was added to the buffer on thread >X<", element);
                Monitor.PulseAll(_queue);
            }

        }

        public int Take()
        {
            lock (_queue)
            {
                while (_queue.Count == 0)
                {
                    Monitor.Wait(_queue);

                }
                
                int temp = _queue.Dequeue();
                //Console.WriteLine("The value {0} was takened from the buffer on thread >X< ", temp);
                Monitor.PulseAll(_queue);
                return temp;
                
            }
            


        }

        //public int read()
        //{
        //    queue.Peek();
        //}



    }
}
