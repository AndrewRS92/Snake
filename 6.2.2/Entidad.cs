using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2._2
{
    public class Entidad
    {
        public Entidad(string imagen,Laberinto laberinto, int? x = null, int? y = null)
        {
            Random generador = new Random();

            if (x == null)
            {
                X = generador.Next(0, laberinto.Ancho);
            }
            else
            {
                X = x.Value;
            }
            if (y == null)
            {
                Y = generador.Next(0, laberinto.Alto);

            }
            else
            {
                Y = y.Value;
            }

            Imagen = imagen;
        }
        public int X { get; set; }
        public int Y { get; set; }
        public string Imagen { get; set; }

        public void Dibujar()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(Imagen);
        }
    }
}
