using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Invaders
{
    class marcador
    {
        public int Score = 0;
        public marcador(int score) { this.Score = score; }
        public int GetScore() { return (this.Score); }
        public void SetScore(int newScore) { this.Score = newScore; }
    }
}
