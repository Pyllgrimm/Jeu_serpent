internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Entrez le nombre de joueurs: ");
        string entreeUtilisateur = Console.ReadLine();
        int nombreJoueurs = int.Parse(entreeUtilisateur);
        
        string[] joueurs = new string[nombreJoueurs];
        int[] positions = new int[nombreJoueurs];        

        for (int i = 0; i < joueurs.Length; i++)
        {
            Console.WriteLine($"Entrez le prénom du joueur {i+1}");
            string prenom = Console.ReadLine();

            joueurs[i] = prenom;
            positions[i] = 0;
        }


        string vainqueur = "";

        while (vainqueur == "")
        {
            for (int i = 0; i < joueurs.Length; i++)
            {
                Separer();

                Console.WriteLine($" {joueurs[i]}");
                Console.WriteLine();
                Console.Write("Lancez le dé !\n<press entrer>");
                Console.ReadLine();

                Random aleatoire = new Random();
                int jet = aleatoire.Next(1, 7);

                Separer();
                
                Console.WriteLine(joueurs[i]);
                Console.WriteLine("~~~~~~");
                Console.WriteLine();
                Console.WriteLine($"Le dé donne : {jet}.");
                Console.WriteLine() ;
                positions[i] = Deplacer(positions[i], jet);
                Console.WriteLine($"{joueurs[i]} se déplace case {positions[i]}");

                Separer();

                if (positions[i] == 50)
                {
                    Console.WriteLine($"Le vainqueur est {joueurs[i]}");

                    vainqueur = $"{joueurs[i]}";

                    Console.WriteLine("Voulez vous rejouer ? o/n ");
                    string rejouer = Console.ReadLine();

                    if (rejouer == "o")
                        vainqueur = "";
                    break;
                }
                Thread.Sleep(5000);
                Console.Clear();
            }
            /*Thread.Sleep(750);
            Console.Clear();*/
        }
    }
    public static void Separer()
    {
        Console.WriteLine();
        Console.WriteLine("======================================");
        Console.WriteLine();
    }
    public static int Deplacer(int position, int jet)
    {
        
        position += jet;

        switch (position)
        {
            case 50:
                break;
            case > 50:
                position = 25;
                break;
            case 37:
                position = 12;
                break;
            case 14:
                position = 7;
                break;
            case 20:
                position = 35;
                break;
            case 2:
                position = 17;
                break;
            case 31:
                position = 43;
                break;

        }
        return position;
    }
}