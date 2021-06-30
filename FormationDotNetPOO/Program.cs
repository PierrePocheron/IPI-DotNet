using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationDotNetPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            typeGenerique();
            Console.ReadLine();
        }

        static void Scénario1()
        {
            System.Console.WriteLine("Début - Scénario 1\n");

            //  Création d'un objet Hero
            Hero hero1 = new Hero("Popo", "Pierre");

            //  Modification du héro grace aux Getters Setters
            Console.WriteLine("Nom de base : " + hero1.Nom);
            hero1.Nom = "Popo";
            Console.WriteLine("Nom apres modif : " + hero1.Nom);

            Console.WriteLine("Prénom de base : " + hero1.Prenom);
            //  Throw an Exception
            //  hero1.Prenom = "";
            //  Console.WriteLine("Prénom apres modif : " + hero1.Prenom);
            Console.WriteLine("\n");


            Console.WriteLine("Nom complet : " + hero1.NomComplet);
            Console.WriteLine("Il appartient au clan : " + Hero.clan);

            Console.WriteLine("\n");


            //  Appel de fonctions et méthodes
            hero1.marcher();
            hero1.courrir(7);

            Console.WriteLine("\n");

            Console.WriteLine(hero1.NomComplet + " est tombé dans une embuscade ! ");

            if (hero1.defendre() == 1)
            {
                Console.WriteLine("Défense réussi");
            }
            else
            {
                Console.WriteLine("Aie ! -10 PV");
            }

            Console.WriteLine("\n");

            hero1.recupererUnePotion(3, "potion bleu", 10);
            hero1.recupererUnePotion(lvl: 3, puissance: 5, nom: "potion verte");
            hero1.recupererUnePotion(2);

            System.Console.WriteLine("\nFin - Scénario 1");

        }

        static void Scénario2()
        {
            System.Console.WriteLine("Début - Scénario 2\n");

            //  Création des personnages
            //  Instanciation des Objets
            Hero conan = new Hero("Conan", "Le Barbar");
            Console.WriteLine("Nom complet de notre hero : " + conan.NomComplet);

            Mage unMage = new Mage("Gandalf","Le gris", 10);
            Console.WriteLine("Nom complet de notre mage : " + unMage.NomComplet);

            Hero guerrier = new Mage("Chevalier","Du feu",7);
            Console.WriteLine($"Nom hero mage : {guerrier.NomComplet}");

            Console.WriteLine("\n");

            //  Le caste
            Mage mageGuerrier;
            mageGuerrier = (Mage)guerrier;
            mageGuerrier.attaqueCombineEpeeMagiqueFeu();


            Console.WriteLine("\n");

            //conan.attaquerEpee();
            unMage.attaqueMagiqueFeu();
            //unMage.attaquerEpee();

            Console.WriteLine("\n");

            unMage.attaqueCombineEpeeMagiqueFeu();

            Console.WriteLine("\n");

            conan.voyager();
            unMage.voyager();


            System.Console.WriteLine("\nFin - Scénario 2");

        }

        static void Scénario3()
        {
            System.Console.WriteLine("Début - Scénario 3\n");


            //  Création des personnages
            //  Instanciation des Objets
            Hero conan = new Hero("Conan", "Le Barbar");
            Console.WriteLine("Nom complet de notre hero : " + conan.NomComplet);

            Mage unMage = new Mage("Gandalf", "Le gris", 10);
            Console.WriteLine("Nom complet de notre mage : " + unMage.NomComplet);

            Console.WriteLine("\n");

            //  Appel a une méthode abstraite redéfini
            conan.planterArbre(10);
            unMage.planterArbre(34);

            Console.WriteLine("\n");

            conan.chanterPourLesPlantes();
            unMage.chanterPourLesPlantes();

            Console.WriteLine("\n");

            conan.ManaVert = 3;
            unMage.ManaVert = 80;

            Console.WriteLine($"Notre hero : {conan.NomComplet} possède {conan.ManaVert} de mana verte");
            Console.WriteLine($"Notre mage : {unMage.NomComplet} possède {unMage.ManaVert} de mana verte");

            Console.WriteLine("\n");

            unMage.marcheSilencieuse();
            unMage.absorberPouvoirEnemie(10);

            System.Console.WriteLine("\nFin - Scénario 3");
        }

        static void LesTypesAnonyme()
        {
            System.Console.WriteLine("Début - LesTypesAnonyme\n");

            var objetInconnu = new { poids = 3, valeurPieceOr = 10 };

            var newPnj = new
            {
                nom = "Flavien",
                force = 10,
                dateNaissance = new DateTime(1987, 12, 3)
            };

            var newPnj1 = new
            {
                nom = "Flavlar",
                force = 0,
                dateNaissance = new DateTime(1237, 02, 2)
            };

            Console.WriteLine($"Objet inconnu : {objetInconnu.poids} , {objetInconnu.valeurPieceOr}");
            Console.WriteLine($"Nouveau Pnj : {newPnj.nom} , {newPnj.force}, {newPnj.dateNaissance}");

            Console.WriteLine("\n");

            Console.WriteLine($"Hashage png 0 : {newPnj.GetHashCode()}\nHashage png 1 : {newPnj1.GetHashCode()}");



            System.Console.WriteLine("\nFin - LesTypesAnonyme");
        }

        static void ExempleLINQ()
        {
            System.Console.WriteLine("Début - ExempleLINQ\n");

            List<Hero> armeeDuNord = new List<Hero>();

            foreach (int i in Enumerable.Range(0, 15))
            {
                armeeDuNord.Add(new Hero("hero_" + i.ToString(), i.ToString()));
            }

            var resultat = from hero in armeeDuNord
                           group hero by new
                           {
                               nom = hero.NomComplet,
                               mana = hero.ManaVert
                           };

            System.Console.WriteLine("Liste de l'armée du Nord : ");
            foreach (var item in armeeDuNord)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("\n");

            System.Console.WriteLine("Liste des resultats de la requète : ");
            foreach (var item in resultat)
            {
                foreach (var itemBis in item)
                {
                    Console.WriteLine(itemBis.NomComplet);
                }
            }

            System.Console.WriteLine("\nFin - ExempleLINQ");
        }

        // === Debut - Partie sur les délégués ===

        public delegate string reverse(string s);

        static string reverseString(string maChaine)
        {
            return new string(maChaine.Reverse().ToArray());
        }

        static void LesDelegues()
        {
            System.Console.WriteLine("Début - LesDélégués\n");

            string chaine = "hello world";
            Console.WriteLine($"Before reverse : {chaine}");
            Console.WriteLine($"After reverse  : {reverseString(chaine)}");

            reverse rev = reverseString;
            Console.WriteLine(rev.ToString());
            

            System.Console.WriteLine("\nFin - LesDélégués");
        }

        static void LesDeleguesSacoche()
        {
            System.Console.WriteLine("Début - LesDéléguésSacoche\n");

            List<string> contenuSacoche = new List<string>();

            contenuSacoche.Add("Epee");
            contenuSacoche.Add("Bouclier");
            contenuSacoche.Add("Casque");
            contenuSacoche.Add("Bottes");
            contenuSacoche.Add("Potion");

            Console.WriteLine("Afficher le contenu de la sacoche :\n");

            foreach (var item in contenuSacoche)
            {
                Console.WriteLine(item);
            }

            Sacoche sacoche = new Sacoche();

            Console.WriteLine("\nAfficher le contenu de la sacoche - Trié:\n");

            sacoche.DemoTriSacoche(contenuSacoche.ToArray());

            System.Console.WriteLine("\nFin - LesDéléguésSacoche");
        }

        // === Fin - Partie sur les délégués ===


        // === Debut - Partie sur les délégués - Exemple ===

        static int calculerDeuxThermes(int a, int b, Func<int,int,int> operation )
        {
            return operation(a, b);
        }

        static int somme (int a, int b)
        {
            return a + b;
        }

        static int multi(int a, int b)
        {
            return a * b;
        }

        static void LesDeleguesExemple()
        {
            System.Console.WriteLine("Début - LesDeleguesExemple\n");


            int resultat = calculerDeuxThermes(9, 3, somme);
            Console.WriteLine($"Resultat : {resultat}");

            Console.WriteLine("\n");

            resultat = calculerDeuxThermes(9, 3, multi);
            Console.WriteLine($"Resultat : {resultat}");

            Console.WriteLine("\n");

            //  Delegate => création d'une fonction anonyme implémenté dans la ligne
            resultat = calculerDeuxThermes(9, 3, delegate (int a, int b) {return a / b;});
            Console.WriteLine($"Resultat : {resultat}");


            System.Console.WriteLine("\nFin - LesDeleguesExemple");
        }

        // === Fin - Partie sur les délégués - Exemple ===


        // === Debut - partie sur les Lambda

        static Boolean compareText (string txt)
        {
            return txt == "sort des premiers soin";
        }

        static void ExpressionsLambda()
        {
            System.Console.WriteLine("Début - ExpressionsLambda\n");

            List<string> listLivreDesSorts = new List<string>();
            listLivreDesSorts.Add("sort des morts vivants");
            listLivreDesSorts.Add("sort des premiers soin");
            listLivreDesSorts.Add("sort boule de feu");
            listLivreDesSorts.Add("sort des premiers soin");

            List<string> result1 = listLivreDesSorts.FindAll(compareText);
            Console.WriteLine("sorts trouvés 1 : ");

            foreach (var item in result1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n");


            List<string> result2 = listLivreDesSorts.FindAll(
            delegate (string sort)
            {
                return (sort == "sort des premiers soin");
            }
            );
            Console.WriteLine("sorts trouvés 2 : ");

            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("\n");

            //  3 => Meilleure facon de faire
            List<string> result3 = listLivreDesSorts.FindAll( sort => sort == "sort des premiers soin");

            Console.WriteLine("sorts trouvés 3 : ");

            foreach (var item in result3)
            {
                Console.WriteLine(item);
            }

            System.Console.WriteLine("\nFin - ExpressionsLambda");
        }

        // === Fin - partie sur les Lambda

        // === Début - partie sur les Evenements

        static void Evenements()
        {
            System.Console.WriteLine("Début - Evenements\n");

            Hero heroConan = new Hero("Conan","Le Barbare");
            Hero heroTortue = new Hero("Tortue","Ninja");

            Monstre monstreZombie = new Monstre("Un Zombie");
            Monstre monstreDragon = new Monstre("Un Dragon");

            Hero.DelegateAttaqueEpee delegateAttaqueMonstre = monstreZombie.recevoirDesDegats;
            Hero.DelegateAttaqueEpee delegateAttaqueMonstre2 = monstreDragon.recevoirDesDegats;

            //  Déclarations d'évenements
            //  Le += signifie que l'object est abonné 
            heroConan.eventAttaqueEpee += delegateAttaqueMonstre;
            heroTortue.eventAttaqueEpee += delegateAttaqueMonstre;

            heroConan.eventAttaqueEpee += delegateAttaqueMonstre2;
            heroTortue.eventAttaqueEpee += delegateAttaqueMonstre2;

            heroConan.eventHandlerHero += heroTortue.recevoirSoin;
            heroConan.eventHandlerHero += heroConan.recevoirSoin;


            heroConan.attaquerEpee();
            System.Console.WriteLine("\n");
            heroTortue.attaquerEpee();
            System.Console.WriteLine("\n");
            heroConan.attaquerEpee();
            System.Console.WriteLine("\n");
            heroTortue.attaquerEpee();
            System.Console.WriteLine("\n");

            heroConan.eventAttaqueEpee -= delegateAttaqueMonstre2;

            heroConan.attaquerEpee();
            System.Console.WriteLine("\n");
            System.Console.WriteLine("\n");

            heroConan.donnerLesSoins(50);
            System.Console.WriteLine("\n");




            System.Console.WriteLine("\nFin - Evenements");
        }

        // === Fin - partie sur les Evenements




        // === Début - partie sur les Génériques

        static void typeGenerique()
        {
            System.Console.WriteLine("Début - Générique\n");

            /*List<Hero> armeeDesHeros = new List<Hero>();
            List<Monstre> armeeMonstres = new List<Monstre>();

            foreach (int i in Enumerable.Range(0,30))
            {
                Hero a = new Hero("Soldat_" + i.ToString(), "prenom_" + i.ToString());
                Monstre b = new Monstre("Monstre" + i.ToString());

                a.eventAttaqueEpee += b.recevoirDesDegats;
                //  Fonction pas dev
                //b.eventContreAttaque += a.recevoirDesDegats;


                armeeDesHeros.Add(a);
                armeeMonstres.Add(b);
            }

            foreach (int i in Enumerable.Range(0, 30))
            {
                armeeDesHeros[i].attaquerEpee();
            }

    */

            GenericLivreDeSort<Sort> analyse = new GenericLivreDeSort<Sort>();
            analyse.analyserUnSort(new Sort { nom = "Sort de foudre", puissance = 30 });


            GenericLivreDeSort<Hero> analyse2 = new GenericLivreDeSort<Hero>();
            Hero heroConan = new Hero("conan","le barbar");
            analyse2.analyserUnSort(heroConan);




            System.Console.WriteLine("\nFin - Générique");
        }

        // === Fin - partie sur les Génériques
    }
}
