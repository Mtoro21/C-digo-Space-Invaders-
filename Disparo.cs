using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Invaders.Model
{
    class Disparo
    {
        public float posShootY;

        public Disparo(float MovupY) { this.posShootY = MovupY;}
        public float GetPosShootY() { return (this.posShootY); }
        public void SetPosShhotY(float newShootPosY) { this.posShootY = newShootPosY;}
    }
}
