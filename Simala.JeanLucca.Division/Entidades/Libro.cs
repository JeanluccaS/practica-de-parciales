using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public abstract class Libro
    {
        protected Autor autor;
        protected int cantidadDePaginas;
        protected Random generadorDePaginas;
        protected float precio;
        protected string titulo;

        public int CantidadDePaginas
        {
            get;
        }

        public static explicit operator tring(Libro I)
        {
            StringBuilder Libro = new StringBuilder();
            Libro.AppendLine("Autor: "+I.autor);
            return Libro.ToString();
        }
        


    }
}
