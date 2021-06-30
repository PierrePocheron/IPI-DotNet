using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationDotNetPOO
{
    class Hero : Druide
    {
        //  Etape 1 - Declaration delegate
        public delegate void DelegateAttaqueEpee(int puissance, string message);

        //  Etape 2 - Declaration d'évenement
        public event DelegateAttaqueEpee eventAttaqueEpee;

        //  Etape 3 - Quelquechose qui propage l'évenement 

        public event EventHandler<HeroEventArgs> eventHandlerHero;

        public void recevoirSoin(object sender,HeroEventArgs args)
        {
            Console.WriteLine("Le type du sender : " + sender.GetType());
            Console.WriteLine("Je recois des soins de : " + args.nomComplet + " puissance de soin : " + args.soin.ToString());
        }

        public void donnerLesSoins(int puissance)
        {
            Console.WriteLine(NomComplet + " est entrain de donner des soins");
            if (this.eventHandlerHero != null)
            {
                this.eventHandlerHero(this, new HeroEventArgs { soin = 30, nomComplet = this.NomComplet});
            }
        }






        public void attaquerEpee()
        {
            Console.WriteLine($"Le Hero : {NomComplet} attaque a l'épee");
            if (eventAttaqueEpee != null)
            {
                eventAttaqueEpee(10, this.NomComplet);
            }
        }





        //  Propriétés
        private string nom = "inconnu";
        private string prenom   { get; set; }   = string.Empty;
        List<string> equipements;
        public static string clan;
        public override int ManaVert
        {
            get => manaVert;
            set => this.manaVert = value;
        }



        // Constructeur
        public Hero() { }
        public Hero(string nom, string prenom)
        {
            this.nom = nom;
            this.prenom = prenom;
        }

        // Constructeur alternatif pour les propriétés static
        static Hero()
        {
            clan = "Ecole des héros";
        }



        // Getters Setters
        public string Nom
        {
            get { return nom; }
            set { nom = value.ToUpper(); }
        }

        public string Prenom
        {
            get { return prenom; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Prénom vide interdit");
                nom = value;
            }
        }




        // Fontion et Methodes
        public string NomComplet
        {
            get
            {
                //  Plusieurs manières de faire :
                // return this.nom + " " + this.prenom;
                // return string format("{0} {1}", nom, prenom);
                return $"{nom} {prenom}";
            }
        }


        public void marcher()
        {
            Console.WriteLine($"Le hero : {NomComplet} est entrain de marcher");
        }

        public void courrir(int vitesse)
        {
            Console.WriteLine($"Le hero : {NomComplet} est entrain de courrir a la vitesse de {vitesse} km/h");
        }

        public virtual void voyager()
        {
            Console.WriteLine($"Le hero : {NomComplet} va monter sur sa monture");
        }

        public int defendre()
        {
            Random rnd = new Random();
            return rnd.Next(0, 1);
        }

        public void recupererUnePotion(
            int puissance, 
            string nom = " potion rouge ", 
            int lvl = 10)
        {
            Console.WriteLine($"{NomComplet} récupere une potion");
            Console.WriteLine($"Puissance : {puissance}");
            Console.WriteLine($"Nom : {nom}");
            Console.WriteLine($"lvl : {lvl}");
            Console.WriteLine("\n");

        }

        //public void attaquerEpee()
        //{
        //    Console.WriteLine($"{NomComplet} donne un coup d'épee !");
        //}

        public override void planterArbre(int nombreArbre)
        {
            Console.WriteLine($"Le hero {NomComplet} est entrain de planter {nombreArbre} arbres");
        }



        public override string ToString()
        {
            return $"Nom : {NomComplet}\nMana : {ManaVert}\nClan : {Hero.clan}\n\n";
        }




        //  Destructeur
        ~Hero()
        {
            this.equipements = null;
        }

    }
}
