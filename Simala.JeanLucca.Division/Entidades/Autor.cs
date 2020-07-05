using System;

namespace Entidades
{
    public class Autor
    {
        private string apellido;

        private string nombre;

        public Autor(string nombre,string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        
        public static implicit  operator string(Autor a)
        {
         
            
            return a.nombre + a.apellido;
        }

            
    }
}
