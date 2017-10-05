using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Invaders
{
    class Towel
    {              
       float posx;
       float posy;
        //Constructor
        public Towel(float posx, float posy) {this.posx = posx;this.posy = posy;}
        //Mutador get posición X
        public float getposicionX() {return (this.posx);}
        //Mutador get posición Y
        public float getposicionY() {return (this.posy);}
        //Mutador set posición X
        public void setPositionX(float newPostitionX){posx = newPostitionX;}
        //Mutador set posición Y
        public void setPositionY(float newPostitionY){posy = newPostitionY;}
    }
}
