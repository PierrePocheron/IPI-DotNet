using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationDotNetPOO
{
    class Sacoche
    {
        public delegate void DelegateTriSacoche(String[] contenuSacoche);
        private void TrierEtAfficherLaSacocheAsc(String[] contenuSacoche)
        {
            Console.WriteLine("Tri Asc : ");
            Array.Sort(contenuSacoche);
            foreach (String i in contenuSacoche)
            {
                Console.WriteLine(i);
            }
        }
        private void TrierEtAfficherLaSacocheDesc(String[] contenuSacoche)
        {
            Array.Sort(contenuSacoche);
            Array.Reverse(contenuSacoche);
            Console.WriteLine("Tri Desc : ");
            foreach (String i in contenuSacoche)
            {
                Console.WriteLine(i);
            }
        }
        public void DemoTriSacoche(String[] contenuSacoche)
        {
            DelegateTriSacoche delegateTriSacoche;
            delegateTriSacoche = TrierEtAfficherLaSacocheAsc;
            delegateTriSacoche += TrierEtAfficherLaSacocheDesc;
            delegateTriSacoche(contenuSacoche);
        }

    }
}
