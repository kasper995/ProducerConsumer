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


            return false;

        }

        public bool IsEmpty()
        {
            return true;
        }

        public void Put(int element)
        {
            if (IsFull() == false)
            {
                this._queue.Enqueue(element);
            }

        }

        public int Take()
        {
            while (this._queue.Count == 0)
            {

            }

            int temp = this._queue.Dequeue();
            return temp;



        }

        //public int read()
        //{
        //    queue.Peek();
        //}



    }
}
