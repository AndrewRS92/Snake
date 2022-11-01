using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2._2
{
    internal class Partida
    {
        public void Lanzar()
        {
            Laberinto laberinto = new Laberinto(80,50);
            Serpiente jugador = new Serpiente(laberinto);
            Comida manzana = null;
            while (true)
            {
                laberinto.Dibujar();
                jugador.Dibujar();
                if(manzana == null)
                {
                    manzana = new Comida(laberinto);
                }
                else
                {
                    if(jugador.X==manzana.X && jugador.Y == manzana.Y)
                    {
                        manzana = new Comida(laberinto);
                    }
                } 
                
                manzana.Dibujar();
                Mover(jugador);

                Console.Clear();

            }
        }

        private void Mover(Serpiente jugador)
        {
            ConsoleKeyInfo tecla = Console.ReadKey();
            if (tecla.Key == ConsoleKey.UpArrow)
            {
                jugador.Mover(Direccion.Arriba);
            }
            if (tecla.Key == ConsoleKey.DownArrow)
            {
                jugador.Mover(Direccion.Abajo);
            }
            if (tecla.Key == ConsoleKey.LeftArrow)
            {
                jugador.Mover(Direccion.Izquierda);
            }
            if (tecla.Key == ConsoleKey.RightArrow)
            {
                jugador.Mover(Direccion.Derecha);
            }
        }
    }
}
