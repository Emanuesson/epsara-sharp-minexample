using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using epsara;

namespace EpsaraSharpXmpl
{
    class Program
    {
        static void Main(string[] args)
        {
            EpsaraDataVector new_vector = new EpsaraDataVector(20);
            Console.WriteLine("new_vector.Size = {0}", new_vector.Size);

            new_vector[2] = 10.21;
            Console.WriteLine("new_vector[2] = {0}", new_vector[2]);

            new_vector.Size = 30;
            Console.WriteLine("new_vector.Size = {0}", new_vector.Size);

            new_vector[31] = 30;
            Console.WriteLine("new_vector.Size = {0}", new_vector.Size);
            Console.WriteLine("new_vector[2] = {0}", new_vector[2]);
            Console.WriteLine("new_vector[31] = {0}", new_vector[31]);

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
