using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2._2
{
    public class Comida:Entidad
    {
        public Comida(Laberinto laberinto) : base("*",laberinto)
        {
        }

        public void Delete(Comida comida)
        {
            Console.SetCursorPosition(comida.X, comida.Y);
            Console.Write(' ');
        }
    }
}
