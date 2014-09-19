using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodcon
{
    class Program
    {
        static void Main(string[] args)
        {
            Boundedbuffer buf = new Boundedbuffer(4);

            Producer prod = new Producer(buf, 10);
            Consumer con = new Consumer(buf, 10);

            Parallel.Invoke(prod.run, con.Run);
        }
    }
}
