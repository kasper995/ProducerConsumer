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

            Producer prod = new Producer(10);
            Consumer con = new Consumer();

            Parallel.Invoke(prod.run(), con.Run());
        }
    }
}
