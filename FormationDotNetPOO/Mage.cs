using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationDotNetPOO
{
    //  Heritage -> classe Fille : classe Mère
    partial class Mage : Hero, IChaman, IAssassin
    {
        //  Propriétés
        private int puissanceMagique;


        // Getters Setters
        public int PuissanceMagique { get {return puissanceMagique; } set {this.puissanceMagique = value; } }


        // Constructeurs
        public Mage(string nom, string prenom, int puissanceMagique) : base(nom:nom, prenom:prenom) { }



        // Fontions et Méthodes
        public void attaqueMagiqueFeu()
        {
            Console.WriteLine($"Le mage {base.NomComplet} envoie une boule de feu !");
        }

        public void attaqueCombineEpeeMagiqueFeu()
        {
            Console.WriteLine("=== SUPER ATTAQUE ===");
            base.attaquerEpee();
            this.attaqueMagiqueFeu();
        }

        public override void voyager()
        {
            Console.WriteLine($"Le mage : {NomComplet} va se téléporter");
        }

    }
}
