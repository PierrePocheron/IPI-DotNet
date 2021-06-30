using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationDotNetPOO
{
    partial class Mage
    {
        //  Implémenter interface : IChaman
        public void communiquerAvecLesEsprits()
        {
            Console.WriteLine($"Le mage : {NomComplet} comminique avec les esprits");
        }

        public int absorberPouvoirEnemie(int puissanceAbsorbsion)
        {
            Console.WriteLine($"Le mage : {NomComplet} Absorbe le pouvoir d'un ennemie");
            Console.WriteLine($"Le mage : {NomComplet} puissance de base : {puissanceAbsorbsion}");
            Console.WriteLine($"Le mage : {NomComplet} puissance apres absorbsion : {puissanceAbsorbsion * 3}");

            return puissanceAbsorbsion * 3;
        }

        //  Implémenter interface : IAssassin
        public void marcheSilencieuse()
        {
            Console.WriteLine($"Le mage : {NomComplet} effectue une marche silencieuse");
        }

        public void unCoupDansOmbre(int puissance)
        {
            Console.WriteLine($"Le mage : {NomComplet} donne un coup dans l'ombre de puissance : {puissance}");
        }
    }
}
