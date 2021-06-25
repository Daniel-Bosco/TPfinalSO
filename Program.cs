using System;
using System.Threading;

namespace threads
{
    class Program
    {
        static void Main(string[] args)
        {
            CopaPiston kachaw = new CopaPiston();

            Thread rayo = new Thread(new ThreadStart(kachaw.Liebre));
            Thread mate = new Thread(new ThreadStart(kachaw.Tortuga));

            rayo.Start();
            mate.Start();

            rayo.Name = "rayo";
            mate.Name = "mate";

            //if (rayo.IsAlive != true && mate.IsAlive != true) Console.WriteLine("finalizado");
        }
    }
}
