using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Invaders
{
    class Alien
    {
       public float posx;
       public float posy;
        int life = 1;
        public Alien(float posIx, float posIy) { this.posx = posIx; this.posy = posIy; }
        public int getShipLife() { return (this.life); }
        public void setShipLife(int newShipLife) { this.life = newShipLife; }        
        public void MoveRight(float delta) { this.posx = this.posx + delta; }
        public void MoveLeft(float delta) { this.posx = this.posx - delta; }
        public void SetPositionx(float newPosx) { this.posx = newPosx; }
        public void SetPositiony(float newPosy) { this.posy = newPosy; }
        public void shoot() { Console.WriteLine("bang"); }
        public float GetPositionX() { return (this.posx); }
        public float GetPositionY() { return (this.posy); }
    }
}
