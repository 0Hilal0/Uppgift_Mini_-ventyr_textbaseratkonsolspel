


namespace Uppgift_Mini_äventyr_textbaseratkonsolspel
{
    internal class Program
    {


        public static bool running = true;

        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();

            Console.WriteLine("Welcome to the mini adventure!");

            Player myPlayer = Player.CreatePlayer();




            while (running)
            {

                Console.Clear();

                Console.WriteLine("===THE GAME===");
                Console.WriteLine("[1: Adventure]");
                Console.WriteLine("[2: Rest]");
                Console.WriteLine("[3: Stats]");
                Console.WriteLine("[4: Quit game]");

                int choice = int.Parse(Console.ReadLine());


                switch (choice)
                {
                    
                    case 1:
                        Game.Adventure(myPlayer);
                        break;

                    case 2:
                        Game.Rest(myPlayer);
                        break;

                    case 3:
                        Game.PlayerStatus(myPlayer);
                        break;

                    case 4:
                        Console.WriteLine("Hope you had fun!");
                        running = false;
                        break;

                    default:
                        break;
                }

            }


        }


    }

}

