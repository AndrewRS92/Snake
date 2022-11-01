using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2._2
{

    public class Laberinto
    {
        public List<Pared> Paredes { get; set; }
        public int Ancho { get; set; }
        public int Alto { get; set; }

        public Laberinto(int ancho, int alto)
        {   
            Ancho = ancho;
            Alto = alto;
            Paredes = new List<Pared>();
            Paredes.Add(new Pared()
            {
                X = 0,
                Y = 0
            });
            for (int i = 0; i <alto; i++)
            {
                Paredes.Add(new Pared()
                {
                    X = 0,
                    Y = i
                });
            }
            for (int i = 0; i < ancho; i++)
            {
                Paredes.Add(new Pared()
                {
                    X = i ,
                    Y = alto
                });
            }
            for (int i = 0; i < alto; i++)
            {
                Paredes.Add(new Pared()
                {
                    X = ancho,
                    Y = i
                });
            }
            for (int i = 0; i < ancho; i++)
            {
                Paredes.Add(new Pared()
                {
                    X = i,
                    Y = 0
                });
            }
        }

       
        public void Dibujar()
        {
            foreach (Pared pared in Paredes)
            {
                Console.SetCursorPosition(pared.X, pared.Y);
                Console.WriteLine(pared.Ladrillo);
            }
        }
        public bool EsPared(int x, int y)
        {
            foreach (var pared in Paredes)
            {
                if ((x, y) == (pared.X, pared.Y))
                {
                    return true;
                }

            }
            return false;
        }
    }

    public class Pared
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Ladrillo = "#";

    }
}


