using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Invaders
{
    class Partida
    {
        static void Main(string[] args)
        {
            //Se llama la clase marcador
            marcador marker = new marcador(0);
            Console.WriteLine("Su puntaje es= " + marker.GetScore());
            //Se llama a la clase Ovni
            Ovni o = new Ovni(5, 0);
            //Se llama la clase Ship
            Ship s = new Ship(25);
            Console.WriteLine("La nave esta en la posición = " + s.GetPositionX());
            //Se crea un array de objetos
            Towel[] towelArray;
            towelArray = new Towel[4];
            towelArray[0] = new Towel(5, 10);
            towelArray[1] = new Towel(15, 10);
            towelArray[2] = new Towel(35, 10);
            towelArray[3] = new Towel(45, 10);
            //Leer array
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Posicion torre " + (i + 1) + " (" + towelArray[i].getposicionX() + "," + towelArray[i].getposicionY() + ")");
            }
            //Cantidad De vidas
            Console.WriteLine("Vidas Actuales = " + s.getShipLife());
            //Movimiento
            s.MoveRight(11);
            Console.WriteLine("Nave Posicion despues del movimiento a la Derecha  (" + s.GetPositionX() +  ")");
            s.MoveLeft(3);
            Console.WriteLine("Nave Posicion despues del movimiento a la Izquierda  (" + s.GetPositionX() + ")");                     
            s.shoot();



            Console.ReadKey();   
            
        }
    }
}
