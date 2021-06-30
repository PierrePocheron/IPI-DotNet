using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationDotNetPOO
{
    class Monstre
    {
        private int sante = 100;
        private string nom;

        public Monstre(string nom)
        {
            this.nom = nom;
        }

        public void recevoirDesDegats(int degats, string message)
        {
            Console.WriteLine($"Le Monstre : Aie ouille aie ! je me suis fait attaquer par {message}");
            sante -= degats;
            Console.WriteLine($"Le Monstre : Info - {degats} pv, Il me reste {sante} points de vie");

        }
    }
}
