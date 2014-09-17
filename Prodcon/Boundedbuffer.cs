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
        private int Capacitet;
        private Queue<int> queue = new Queue<int>();


        public Boundedbuffer(int Cap)
        {
            Capacitet = Cap;
        }
       

        
       public bool IsFull()
        {
            
            if (queue.Count >= Capacitet)
            {
                return true;
                
            }
            
        
                return false;
            
       }

        public void Put(int element)
        {
            if (IsFull() == false)
            {
                queue.Enqueue(element);
            }
           
        }

        public int Take()
        {
            var temp = queue.Dequeue();
            return temp;
        }

        //public int read()
        //{
        //    queue.Peek();
        //}

    

    }
}
