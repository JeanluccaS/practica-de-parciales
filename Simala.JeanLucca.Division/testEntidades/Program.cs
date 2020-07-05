using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace testEntidades
{
    class Program
    {
        static void Main(string[] args)
        {
            Autor miAutor = new Autor("Pipo", "Ramirez");
            string unAutor = miAutor;
            Console.WriteLine(unAutor);
            Console.ReadKey();
        }
    }
}
