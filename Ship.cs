using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Invaders
{
    class Ship
    {
        float posx;
        int life=3;
        //Constructor
        public Ship(float posIx) { this.posx = posIx; }
        //Mutador get de la vida
        public int getShipLife() { return (this.life); }
        //Mutador set de la vida
        public void setShipLife(int newShipLife) { this.life = newShipLife; }
        //Movimiento hacia la derecha
        public void MoveRight(float delta) { this.posx = this.posx + delta; }
        //Movimiento hacia la izquierda
        public void MoveLeft(float delta) { this.posx = this.posx - delta; }
        //Mutador set en X
        public void SetPositionx(float newPosx) { this.posx = newPosx;}
        //Mutador get en X
        public float GetPositionX() { return (this.posx); }
        //Disparo
        public void shoot() { Console.WriteLine("bang"); }     
    }
}
