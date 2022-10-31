using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2._2
{
    public class Juego
    {   
        public void EmpezarJuego()
        {
            Bienvenida bienvenida = new Bienvenida();
            while (bienvenida.GetSalir() == false)
            {
                bienvenida.Lanzar();
                
                if (bienvenida.GetSalir() == false)
                {
                    Partida partida = new Partida();
                    partida.Lanzar();
                }
            }
        }
    }
}
