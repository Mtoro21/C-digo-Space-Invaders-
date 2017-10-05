using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Invaders
{
    class Ovni:Alien                
    {
        public Ovni(float posOx, float posOy) : base(posOx, posOy)
        {
            this.posx = posOx;
            this.posy = posOy;
        }
    }
}
