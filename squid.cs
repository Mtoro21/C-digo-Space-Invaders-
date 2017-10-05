using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Invaders.Model
{
    class squid:Alien
    {
        public squid(float posOx, float posOy) : base(posOx, posOy)
        {
            this.posx = posOx;
            this.posy = posOy;
        }
    }
}
