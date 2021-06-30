using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationDotNetPOO
{
    abstract class Druide
    {
        //  Propriétés
        protected int manaVert;
        public abstract int ManaVert { get; set; }

        public abstract void planterArbre(int nombreArbre);

        public void chanterPourLesPlantes()
        {
            Console.WriteLine("le druide chante pour les plantes");
        }
    }
}
