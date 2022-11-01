using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2._2
{
    public class Serpiente: Entidad
    { 
        public Serpiente(Laberinto laberinto) : base("O",laberinto)
        {
        }

        public void Mover(Direccion direccion)
        {
            if (direccion == Direccion.Arriba)
            {
                Y--;
            }
            if (direccion == Direccion.Abajo)
            {
                Y++;
            }
            if (direccion == Direccion.Derecha)
            {
                X++;
            }
            if (direccion == Direccion.Izquierda)
            {
                X--;
            }
        }
    }
}
