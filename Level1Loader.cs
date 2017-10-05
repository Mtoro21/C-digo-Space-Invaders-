using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Invaders.Controller
{
    class Level1Loader
    {
        /*Acá el problema es por que esas clases (squid, Toad, Beatle) se están heredando, toca mirar como es esa sintáxis
        De lo contrario no herdamos y hacemos esas clases desde cero. */
        
        squid mySquid = new squid();
        Toad myToad = new Toad();
        Beatle myBeatle = new Beatle();

        //lista de los pulpos 
        List<squid> SquidList = new List<squid>();
            //inicializar los 11 pulpos
            for (int i = 0; i< 11; i++) 
            {
                squidList.Add(new squid(11));
            }


    //Lista arañas superiores
    List<Toad> ToadList = new List<Toad>();
    //inicializar arañas superiores

    //Lista arañas inferiores
    List<Toad> ToadList2 = new List<Toad>();
    //Inicializar arañas infeiores

    //Lista Escarabajos superiores
    List<Beatle> BeatleList = new List<Beatle>();
    //Inicializar escarabajos superiores

    //Lista Escarabajo Inferior
    List<Beatle> BeatleList2 = new List<Beatle>();
    //Inicializar escarabajos inferiores
}
}
