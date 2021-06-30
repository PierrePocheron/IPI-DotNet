using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationDotNetPOO
{
    //  Déclaration de classe générique grace au <T>
    //  Le T est un type Générique
    class GenericLivreDeSort<T>
    {
        public string analyserUnSort ( T obj)
        {
            Console.WriteLine("__Analyse de l'object : ");
            Console.WriteLine(obj.GetType());
            Console.WriteLine(obj.ToString());

             

            return obj.ToString();
        }
    }
}
