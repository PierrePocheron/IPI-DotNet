using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationDotNetPOO
{
    enum ETAT_HERO
    {
        NORMAL,
        EMPOISONE,
        BOOST,
        DORMIR,
        COURIR
    }

    class HeroEventArgs : EventArgs
    {
        public string nomComplet;
        public int soin;
        public int attaqueSpécial;
        public ETAT_HERO etatHero;
    }
}
