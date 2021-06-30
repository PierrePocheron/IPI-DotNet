using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationDotNet
{
    class Program
    {

        struct evenement
        {
            public int[] jours;
            public string tache;
            public int duree;
        }
        enum semaine
        {
            lundi = 1,
            mardi,
            mercredi,
            jeudi,
            vendredi,
            samedi,
            dimanche
        }
        enum longueurTemps
        {
            tresCourt = 15,
            court = 30,
            moyen = 60,
            assezlong = 90,
            deuxheures = 120,
            treslong = 240
        }

        static void Main(string[] args)
        {
            exercice1();

            System.Console.ReadLine();
        }



        static void exemple13()
        {
            System.Console.WriteLine("Début - exemple1.3");

            //affiche Bonjour
            System.Console.WriteLine("Bonjour ");
            System.Console.WriteLine("aaaaaaaaaa");

            int var1 = 110;
            if (var1 is char)
            {
                System.Console.WriteLine("It's a char");
            }
            else
            {
                System.Console.WriteLine(var1.GetType());

            }

            System.Console.WriteLine("Fin - exemple1.3");

        }

        static void exemple213()
        {
            System.Console.WriteLine("Début - exemple2.1.3");

            // On déclare a de type int
            int a;
            int b = 5;
            a = 0;

            System.Console.WriteLine("a=\t" + a.ToString() + "\nb=\t" + b.ToString() + "\n");

            a += a + ++b; // b=b+1; a=a+a+b;
            System.Console.WriteLine("a=\t" + a.ToString() + "\nb=\t" + b.ToString() + "\n");

            a /= b; // a=a/b
            System.Console.WriteLine("a=\t" + a.ToString() + "\nb=\t" + b.ToString() + "\n");

            a -= 2 * b++ * a; // a=a-2*b*a; b+=1;
            System.Console.WriteLine("a=\t" + a.ToString() + "\nb=\t" + b.ToString() + "\n");

            System.Console.WriteLine("Fin - exemple2.1.3");
        }

        static void exemple214()
        {
            System.Console.WriteLine("Début - exemple2.1.4\n");

            int arg1 = 12;
            string arg2 = "bonjour";
            ulong arg3 = 1546471534;

            Console.WriteLine("arg1={0}\narg2={1}\narg3={2}", arg1, arg2, arg3);

            arg2 = string.Format("{0}, {1}, {2}", arg1, arg2, arg3);

            Console.WriteLine(arg2);
            

            System.Console.WriteLine("\nFin - exemple2.1.4");
        }

        static void exemple215()
        {
            System.Console.WriteLine("Début - exemple 2.1.5\n");

            
            uint? a = 2;
            System.Nullable<uint> b = 15;
            b = null;
            a += b; // a = null + 2 c’est à dire a = null
            b = 12;
            System.Console.WriteLine(b.ToString() + "-*-" + a.ToString() + "-*-" + (a ?? b).ToString());


            System.Console.WriteLine("\nFin - exemple 2.1.5");
        }

        static void exemple216()
        {
            System.Console.WriteLine("Début - exemple 2.1.6\n");


            int a = int.MaxValue;
            long b = long.MaxValue;
            long c = 15;
            Console.WriteLine("Valeures de base");
            Console.WriteLine("a = \t" + a);
            Console.WriteLine("b = \t" + b);
            Console.WriteLine("c = \t" + c + "\n");

            // cast implicite
            object o = c;

            // cast explicite necessaire
            a = (int)b; 
            //lève une overflowexeption si les dépassements sont contrôlés

            // cast implicite
            b = a;  
            //fonctionne

            // usage de as et de l'opérateur ??
            // IMPORTANT DE TESTER
            // long? -> le "?" permet d'utiliser les nullables
            b = (o as long?) ?? 0;
            Console.WriteLine(b);

            // équivau à l'instruction:
            //l'opérateur ternaire sera détaillé dans la partie qui suit.
            // ici, seuls "long" et "long?" fonctionnent pour le type dec
            b = ((o is long?) ? ((long?)o) : ((long?)null)) ?? 0;
            Console.WriteLine(b);


            System.Console.WriteLine("\nFin - exemple 2.1.6");
        }

        static void exemple221()
        {
            System.Console.WriteLine("Début - exemple 2.2.1 - If Else\n");


            int a;
            string b;
            System.Console.WriteLine("Entrez 2");
            a = int.Parse(System.Console.ReadLine());
            
            if (a ==10)
            {
                System.Console.WriteLine("a = {a}", a);
            }
            else if (a <= 100 && a >= 200)
            {
                System.Console.WriteLine("a = {a} est compris entre 100 et 200", a);
            }


            System.Console.WriteLine("\nFin - exemple 2.2.1");
        }

        static void exemple222()
        {
            System.Console.WriteLine("Début - exemple 2.2.2 - Switch\n");

            int a = int.Parse(System.Console.ReadLine());
            string b = "";


            switch (a)
            {
                case 2:// le switch saute à cette condition si a vaut 2
                    b = "Bien Joué !";
                    // puis exécute ses instruction
                    break;// Le break fait sortir du switch
                case 1:// en C# : pas de break = pas d’instructions
                case 3:
                    // le cas 1 vien exécuter les instructions du cas 3
                    b = "Pas loin";
                    break;// donc on sort du switch
                default:// default représente tous les autres cas
                    b = "bizarre";
                    break;
            }



            System.Console.WriteLine("\nFin - exemple 2.2.2 - Switch");
        }

        static void exemple223()
        {
            System.Console.WriteLine("Début - exemple 2.2.3 - Operateur terniaire\n");

            int a = int.Parse(System.Console.ReadLine());
            string b = "";

            // Méthode opérateur de retour conditionel
            b = (a == 2) ? "normal" : (a == 1 || a == 3) ? "Pas loin" : "bizarre";

            System.Console.WriteLine(b);

            System.Console.WriteLine("\nFin - exemple 2.2.3 - Operateur terniaire");
        }

        static void exemple231()
        {
            System.Console.WriteLine("Début - exemple 2.3.1 - While\n");


            int a = 2;
            int b = 15;
            int temp;

            while (b > 0)
            {
                if (a == 1)
                    a = 2;
                else
                    a = 1;
                System.Console.WriteLine("Tour du joueur "
                + a.ToString()
                + "\nil reste "
                + b.ToString()
                + " allumettes\nprenez un nombre d'allumettes entre 1 et 3 (defaut 3)");
               
                temp = int.Parse(System.Console.ReadLine());
                if (temp > 0 && temp < 4)
                    b -= temp;
                else
                    b -= 3;
            }
            System.Console.WriteLine("joueur " + a.ToString() + " a perdu");



            System.Console.WriteLine("\nFin - exemple 2.3.1 - While");
        }

        static void exemple232()
        {
            System.Console.WriteLine("Début - exemple 2.3.2 - Do while\n");

            // On passe au moins une fois dans la boucle -> contrairement a la boucle while
            int a = 0;
            do
            {
                System.Console.WriteLine(a++.ToString());
            }
            while (a > 0 && a < 12);
            System.Console.ReadKey();


    
            System.Console.WriteLine("\nFin - exemple 2.3.2 - Do while");
        }

        static void exemple233()
        {
            System.Console.WriteLine("Début - exemple 2.3.3 - For\n");


            int a = 2;
            int temp;
            for (int b = 15; b > 0; b -= (temp > 0 && temp < 4) ? temp : 3)
            {
                if (a == 1) a = 2;
                else
                    a = 1;
                System.Console.WriteLine("Tour du joueur " + a.ToString()
                + "\nil reste " + b.ToString()
                + " alumettes\nprenez un nombre d'allumettes entre 1 et 3 (defaut 3)");
                temp = int.Parse(System.Console.ReadLine());
            }
            System.Console.WriteLine("joueur " + a.ToString() + " a perdu");



            System.Console.WriteLine("\nFin - exemple 2.3.3 - For");
        }

        static void exemple234()
        {
            System.Console.WriteLine("Début - exemple 2.3.4 - Sortie de boucles : Break-Continue\n");


            int a = 2;
            int temp = 0;
            int b = 15;
            while (true)
            {
                if (a == 1)
                    a = 2;
                else
                    a = 1;
                System.Console.WriteLine("Tour du joueur " + a.ToString()
                + "\nil reste " + b.ToString()
                + " alumettes\nprenez un nombre d'allumettes entre 1 et 3 (defaut 3)");
                temp = int.Parse(System.Console.ReadLine());
                if (temp > 0 && temp < 4)
                    b -= temp;
                else
                    b -= 3;
                if (b > 0)
                    continue;

                break;
            }
            System.Console.WriteLine("joueur " + a.ToString() + " a perdu");



            System.Console.WriteLine("\nFin - exemple 2.3.4 - Sortie de boucles : Break-Continue");
        }

        static void exemple24()
        {
            System.Console.WriteLine("Début - exemple 2.4 - Array – ArrayList– enum – struct\n");


            int temp = 0;

            evenement[] cal = new evenement[]
            {
                // La syntaxe utilisée ci-dessous pour remplir les évènements
                new evenement
                {
                    jours= new int[] {(int)semaine.dimanche,(int)semaine.mercredi},
                    tache ="faire la vaiselle",
                    duree =(int)longueurTemps.court
                },

                new evenement
                {
                    jours =new int[7],
                    tache ="lire ses flux RSS",
                    duree =(int)longueurTemps.assezlong
                },

                new evenement
                {
                    jours = new int[] {(int)semaine.lundi, (int)semaine.mercredi},
                    tache = "prendre un bain",
                    duree = (int)longueurTemps.moyen
                }
            };

            cal[1].tache += " et suivre quelques liens";

            for (int i = 0; i < cal.Length; i++)
            {
                temp += cal[i].duree * cal[i].jours.Length;
                System.Console.WriteLine(((double)temp / 60).ToString() +
                " heures de ta semaine occupée (tâche ajouté: " + cal[i].tache + " )");
            }




            System.Console.WriteLine("\nFin - exemple 2.4 - Array – ArrayList– enum – struct");
        }

        static void exemple241()
        {
            System.Console.WriteLine("Début - exemple 2.4.1 - foreach\n");

            foreach (int e in Enumerable.Range(1, 10))
            {
                Console.WriteLine(e);
            }

            System.Console.WriteLine("\nFin - exemple 2.4.1 - foreach");
        }

        static void exemple242()
        {
            System.Console.WriteLine("Début - exemple 2.4.2 - ArrayList\n");

            // IMPORTANT -> Eviter les arrayList car ils melangent les types

            ArrayList numbers = new ArrayList();
            numbers.Add(2);
            numbers.Add(6.99);
            numbers.Add("Five");

            foreach (var i in numbers)
                Console.WriteLine(i);




            System.Console.WriteLine("\nFin - exemple 2.4.2 - ArrayList");
        }

        static void exemple251()
        {
            System.Console.WriteLine("Début - exemple 2.5.1 - List\n");

            /*
             METHODES SUR LES LISTES

            Count                   retourne le nombre d’element dans une liste
            Insert(Index, Object)   insérer un objet a un index donné
            Contains(Object)        vérifier si notre liste contient un objet donné
            Add(Object)             ajouter un objet
            Remove(Object)          supprimer un objet
            Clear()                 supprime tous les éléments dans une liste
            Exists(Predicate<T>)    rechere un ou plusieurs element avec un predicat
            Find(Predicate<T>)      trouve et retourne un element avec un predicat
            FindAll(Predicate<T>)   trouve et retourne l’ensemble des element avec un predicat
            FindIndex(Int32, Int32, Predicate<T>) trouve et retourne un element dans un interval d’index d’une liste
            Reverse()               inverser les éléments dans une liste
            Sort()                  trier une liste
             */
            List<int> numbers = new List<int>();
            numbers.Add(55);
            numbers.Add(2);
            numbers.Add(14);
            numbers.Add(78);
            numbers.Add(78);
            numbers.Add(78);

            //  Utilisataion de prélicats
            //  Si trouve retourne la valeur sinon retourne 0
            System.Console.WriteLine("\nAffiche prélicats de 14");
            Console.WriteLine(numbers.Find( i => i == 14));

            //  Utilisataion de FindAll et prélicats
            System.Console.WriteLine("\nAffiche tous les prélicats de 78");
            foreach (int i in numbers.FindAll(i => i == 78))
            {
                Console.WriteLine(i);
            }

            System.Console.WriteLine("\nAffiche la liste");
            foreach (var i in numbers)
                Console.WriteLine(i);

            Console.WriteLine("\nCount : {0}", numbers.Count());

            numbers.Sort();
            System.Console.WriteLine("\nAffiche la liste - Tirée");
            foreach (var i in numbers)
                Console.WriteLine(i);

            numbers.Reverse();
            System.Console.WriteLine("\nAffiche la liste - Reverse");
            foreach (var i in numbers)
                Console.WriteLine(i);



            List<string> numbersInString = new List<string>();
            numbersInString.Add("One");
            numbersInString.Add("Five");
            numbersInString.Add("Three");
            System.Console.WriteLine("\nAffiche la liste de String");
            foreach (var j in numbersInString)
                Console.WriteLine(j);

            //  Utilisataion de Find et prélicats
            System.Console.WriteLine("\nAffiche tous les prélicats de One");
            Console.WriteLine(numbersInString.Find(i => i == "One"));


            System.Console.WriteLine("\nFin - exemple 2.5.1 - List");
        }

        static void exemple252()
        {
            System.Console.WriteLine("Début - exemple 2.5.2 - Hashable\n");

            Hashtable my_hashtable = new Hashtable();
            my_hashtable.Add("A1", "Welcome");
            my_hashtable.Add("A2", "to");
            my_hashtable.Add("A3", "GeeksforGeeks");

            Console.WriteLine("Parcours du dictionnaire ");
            foreach (DictionaryEntry element in my_hashtable)
            {
                Console.WriteLine("Key:- {0} and Value:- {1} ", element.Key, element.Value);
            }

            System.Console.WriteLine("Fin - exemple 2.5.2 - Hashable\n");

        }

        static void exemple253()
        {
            System.Console.WriteLine("Début - exemple 2.5.3 - Dictionary\n");

            Dictionary<string, string> My_dict = new Dictionary<string, string>();
            My_dict.Add("a.01", "C");
            My_dict.Add("a.02", "C++");
            My_dict.Add("a.03", "C#");
            foreach (KeyValuePair<string, string> element in My_dict)
            {
                Console.WriteLine("Key:- {0} and Value:- {1}",
                element.Key, element.Value);
            }

            My_dict["a.03"] = "Java";

            Console.WriteLine("\nParcours du dictionnaire apres modification A3");
            foreach (KeyValuePair<string, string> element in My_dict)
            {
                Console.WriteLine("Key:- {0} and Value:- {1} ", element.Key, element.Value);
            }

            System.Console.WriteLine("\nFin - exemple 2.5.3 - Dictionary");
        }

        static void exemple254()
        {
            System.Console.WriteLine("Début - exemple 2.5.4 - Queue\n");

            /*
             * Méthode des Queue / file
             * 
                Count()             Obtient le nombre d'éléments contenus dans la file.
                Clear()             Supprime tous les objets de la file d'attente.
                Clone()             Crée une copie superficielle de la file d'attente.
                Contains(Object)    Détermine si un élément se trouve dans la file d'attente.
                CopyTo(Array, Int32) Copie les éléments Queue dans un tableau unidimensionnel existant, en commençant à l'index de tableau spécifié.
                Dequeue()           Supprime et renvoie l'objet au début de la file d'attente.
                Enqueue(Object)     Ajoute un objet à la fin de la file d'attente.
                Equals(Object)      Détermine si l'objet spécifié est égal à l'objet actuel.
                Peek()              Renvoie l'objet au début de la file d'attente sans le supprimer.
                ToArray()           Copie les éléments Queue dans un nouveau tableau.
                ToString()          Retourne une chaîne qui représente l'objet actuel. 

             
             */

            Queue myQueue = new Queue();
            myQueue.Enqueue("one");
            Console.Write("Totale d'element dans la queue : ");
            Console.WriteLine(myQueue.Count);
            myQueue.Enqueue("two");
            Console.Write("Totale d'element dans la queue : ");
            Console.WriteLine(myQueue.Count);
            myQueue.Enqueue("three");
            Console.Write("Totale d'element dans la queue : ");
            Console.WriteLine(myQueue.Count);
            myQueue.Enqueue("four");
            Console.Write("Totale d'element dans la queue : ");
            Console.WriteLine(myQueue.Count);
            myQueue.Enqueue("five");

            Console.Write("\nTotale d'element dans la queue avant : ");
            Console.WriteLine(myQueue.Count);
            var TeteDeFile = myQueue.Dequeue();//on va enlever la tete de la file
            Console.Write("Totale d'element dans la queue apres : ");
            Console.WriteLine(myQueue.Count);
            Console.WriteLine("La tete de file recuperé : ");
            Console.WriteLine(TeteDeFile);


            System.Console.WriteLine("\nFin - exemple 2.5.4 - Queue");
        }

        static void exemple255()
        {
            System.Console.WriteLine("Début - exemple 2.5.5 - Pile\n");

            /*
             *  METHODE DES PILES
             *  
             *  Count()             Obtient le nombre d'éléments contenus dans la pile.
                Clear()             Supprime tous les objets de la pile.
                Clone()             Crée une copie superficielle de la pile.
                Contains(Object)    Détermine si un élément se trouve dans la pile.
                CopyTo(Array, Int32) Copie la pile dans un tableau unidimensionnel existant, en commençant à l'index de tableau spécifié.
                Peek()              Renvoie l'objet en haut de la pile sans le supprimer.
                Pop()               Supprime et renvoie l'objet en haut de la pile.
                Push(Object)        Insère un objet en haut de la pile.
                ToArray()           Copie la pile dans une nouvelle baie.
                ToString()          Retourne une chaîne qui représente l'objet actuel.

             *  
             */
            Stack myStack = new Stack();
            myStack.Push("1st Element");
            myStack.Push("2nd Element");
            myStack.Push("3rd Element");
            myStack.Push("4th Element");
            myStack.Push("5th Element");
            myStack.Push("6th Element");

            Console.Write("Totale d'element dans la pile : ");
            Console.WriteLine(myStack.Count);

            Console.WriteLine("\nElement du haut : " + myStack.Peek());

            var elem = myStack.Pop();//on récupère le haut de la pile
            Console.WriteLine("Element du haut : " + myStack.Peek());
            Console.Write("\nTotale d'element dans la pile : ");
            Console.WriteLine(myStack.Count);

            System.Console.WriteLine("\nFin - exemple 2.5.5 - Pile");
        }

        static void exemple26()
        {
            System.Console.WriteLine("Début - exemple 2.6 - Try Catch\n");


            int a = 15;
            int b = 0;

            try
            {
                Console.WriteLine(a / b);
            }

            // Il est possible de créer des catch d'exceptions
            catch (System.DivideByZeroException e)
            {
                Console.WriteLine("Olalalaladivision par 0");
            }

            // Cette exception doit etre la dernière
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            //  S'éxecute toujours et en dernier
            finally
            {
                Console.WriteLine("Envoi de mail de l'erreur vers le développeur\n\n");
            }

            //uint a = 2; uint temp = 0; uint b = 15;
            //while (b > 0)
            //{
            //    if (a == 1) a = 2; else a = 1;
            //    System.Console.WriteLine("Tour du joueur " + a.ToString()
            //    + "\nil reste " + b.ToString()
            //    + " alumettes" +
            //    "\nprenez un nombre d'allumettes entre 1 et 3" +
            //    "\n(defaut 3, nombre négatif pour abandoner)");
            //    try
            //    {
            //        temp = uint.Parse(System.Console.ReadLine());
            //    }
            //    catch (System.Exception e)
            //    {
            //        System.Console.WriteLine(e.Message);
            //        if (e.GetType().Equals(typeof(System.ArgumentNullException)))
            //            System.Console.WriteLine("impossible: retour minimal= \"\" (non null)");
            //        else if (e is System.OverflowException) break;
            //        else System.Console.WriteLine("message non parsable");
            //        if (a == 1) a = 2; else a = 1; continue;
            //    }
            //    if (temp < 4) b -= temp; else b -= 3;
            //}
            //System.Console.WriteLine("joueur " + a.ToString() + " a perdu");


            System.Console.WriteLine("\nFin - exemple 2.6 - Try Catch");
        }

        static void exercice1()
        {
            System.Console.WriteLine("Début - Exercice1\n");

            // Exercice 1.1
            int unNombre = 12345;
            String uneChaine = unNombre.ToString();
            System.Console.WriteLine("Exercice 1.1");
            System.Console.WriteLine(uneChaine);
            System.Console.WriteLine("\n");

            // Exercice 1.2
            String uneChaine2 = "12345\n";
            int unNombre2 = Int32.Parse(uneChaine2);
            System.Console.WriteLine("Exercice 1.2");
            System.Console.WriteLine(unNombre2);
            System.Console.WriteLine("\n");


            // Exercice 1.3
            System.Console.WriteLine("Exercice 1.3");
            String s1 = System.Console.ReadLine();
            String s2 = System.Console.ReadLine();
            if (s1.Substring(0, 1) == s2.Substring(0, 1))
            {
                System.Console.WriteLine("\nCes deux chaines commencent par le même caractere !");
            }
            else
            {
                System.Console.WriteLine("Ces deux chaines ne commencent pas par le même caractere !");
            }
            System.Console.WriteLine("\n");


            // Exercice 1.4
            System.Console.WriteLine("Exercice 1.4");
            String s1bis = System.Console.ReadLine();
            String s2bis = System.Console.ReadLine();

            if (s1bis.Contains(s2bis))
            {
                int index;
                while ((index = s1bis.IndexOf(s2bis)) >= 0)
                {
                    s1bis = s1bis.Remove(index, s2bis.Length);
                }
                Console.WriteLine(s1bis);
            }
            else
            {
                Console.WriteLine(s1bis);
            }


            System.Console.WriteLine("\nFin - Exercice1");
        }

        static void exercice2()
        {
            System.Console.WriteLine("Début - Exercice2\n");

            String message = System.Console.ReadLine();

            int messageLength = message.Length;

            for(int i = 1; i < messageLength + 1; i++ )
            {
                System.Console.WriteLine(message.Substring(0,i));
            }


            System.Console.WriteLine("\nFin - Exercice2");
        }

        static void exercice3()
        {
            System.Console.WriteLine("Début - Exercice3\n");


            String uneChaine = System.Console.ReadLine().ToLower();
            uneChaine = uneChaine.Replace(" ", "");
            int chaineLenght = uneChaine.Length;
            

            char[] uneChaineArray = uneChaine.ToCharArray();

            
            Array.Reverse(uneChaineArray);
            String uneChaineInverse = new string(uneChaineArray);

            if (uneChaineInverse == uneChaine)
            {
                System.Console.WriteLine(uneChaine + " est un palindrome !");
            }
            else
            {
                System.Console.WriteLine(uneChaine + " n'est pas un palindrome !");
            }



            System.Console.WriteLine("\nFin - Exercice3");
        }

        static void exercice21()
        {
            System.Console.WriteLine("Début - Exercice 2.1\n");

            char[] alphabet = new char[26];
            for (int i = 0; i < 26; i++)
            {
                alphabet[i] = Convert.ToChar(65 + i);
            }
            for (int i = 0; i < 26; i++)
            {
                Console.WriteLine(alphabet[i]);
            }

            System.Console.WriteLine("\nFin - Exercice 2.1");
        }

        static void exercice22()
        {
            System.Console.WriteLine("Début - Exercice 2.2\n");

            Boolean temoin = false;
            int unIntUtilisateur;
            do
            {
                System.Console.WriteLine("\nEntrez un nombre compris entre 1 et 9 ");

                unIntUtilisateur = Convert.ToInt16(System.Console.ReadLine());

                if (unIntUtilisateur < 1 | unIntUtilisateur > 9)
                {
                    System.Console.WriteLine("Votre saisie n'est pas comprise entre 1 et 9 : " + unIntUtilisateur);
                    temoin = false;
                }
                else
                {
                    System.Console.WriteLine("Votre saisie est comprise entre 1 et 9 : " + unIntUtilisateur);
                    temoin = true;
                }
            }
            while (temoin == false);
             

            System.Console.WriteLine("\nFin - Exercice2.2");
        }

        static void exercice23()
        {
            System.Console.WriteLine("Début - Exercice 2.3\n");

            int[] tableau = new int[10];
            double moyenne;
            int somme = 0;

            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine("Saisir l'entier numéro : " + (i + 1));
                tableau[i] = Convert.ToInt16(System.Console.ReadLine());  
            }

            for (int i = 0; i < 10; i++)
            {
                somme += tableau[i];
            }

            moyenne = (Convert.ToDouble(somme) / 10); 

            System.Console.WriteLine("La moyenne est de : " + moyenne);
            System.Console.WriteLine("La somme est de : " + somme);


            System.Console.WriteLine("\nFin - Exercice2.3");
        }

        static void exercice24()
        {
            System.Console.WriteLine("Début - Exercice 2.4\n");

            int tailleTab = 10;
            string[] tableau = new string[tailleTab];

            for (int i = 0; i < tailleTab; i++)
            {
                System.Console.WriteLine("Saisir le caractère numéro: {0}", (i + 1));
                tableau[i] = System.Console.ReadLine();
            }

            for (int i = 0; i < tailleTab; i++)
            {
                Console.WriteLine("L'indice : {0} du tableau contient : {1}", (i + 1), tableau[i]);
            }

            int lettresMajuscules = 0;
            int lettresMinuscules = 0;
            int nbChiffres = 0;
            for (int i = 0; i < tailleTab; i++)
            {
                string uneChaine = tableau[i];
                if (char.IsLetter(Convert.ToChar(uneChaine)))
                {
                    if (uneChaine.Equals(uneChaine.ToUpper()))
                    {
                        lettresMajuscules += 1;
                    }
                    else
                    {
                        lettresMinuscules += 1;
                    }

                }
                else
                {
                    nbChiffres += 1;
                }
            }

            Console.WriteLine("Le nombre de majuscules est : "+ lettresMajuscules);
            Console.WriteLine("Le nombre de minuscules est : "+ lettresMinuscules);
            Console.WriteLine("Le nombre de chiffres est : "+ nbChiffres);


            System.Console.WriteLine("\nFin - Exercice2.4");
        }

        static void exercice25()
        {
            System.Console.WriteLine("Début - Exercice 2.5\n");

            int compteur = 0;
            int entierUsr = 0;
            int[] tableauEntierRandom = new int[21 - 12];

            Random randomO = new Random();

            for (int i = 0; i < 21 - 12; i++)
            {
                tableauEntierRandom[i] = randomO.Next(12, 21);
            }

            for (int i = 0; i < 21 - 12; i++)
            {
                Console.WriteLine(tableauEntierRandom[i] + " ");
            }

            System.Console.WriteLine("Recherchez un entier :");
            entierUsr = Convert.ToInt16(System.Console.ReadLine());
            for (int i = 0; i < 21 - 12; i++)
            {
                if (tableauEntierRandom[i] == entierUsr)
                {
                    compteur += 1;
                }
            }
            Console.WriteLine("\nL'entier {0} se répète : {1} fois", entierUsr, compteur);


            System.Console.WriteLine("\nFin - Exercice2.5");
        }
    }
}
