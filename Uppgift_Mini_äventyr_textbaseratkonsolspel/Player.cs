

namespace Uppgift_Mini_äventyr_textbaseratkonsolspel
{
    public class Player
    {

        public string Name;
        public string PlayerClass;
        public int Hp;
        public int MaxHp;
        public int Damage;
        public int Mana;
        public int Gold;
        public int SpecialAttack;
        public int MaxMana;


        public static Player CreatePlayer()
        {


            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine(" ");

            Console.WriteLine("Choose a class: ");
            Console.WriteLine("[1] Warrior");
            Console.WriteLine("[2] Samurai");
            Console.WriteLine("[3] Mage");
            Console.WriteLine(" ");
            int playerClass = int.Parse(Console.ReadLine());

            Player playerToAdd = new Player
            {


                Name = name,


            };

            switch (playerClass)
            {

                case 1:
                    playerToAdd.PlayerClass = "Warrior";
                    playerToAdd.Hp =120;
                    playerToAdd.MaxHp =120;
                    playerToAdd.Damage =25;
                    playerToAdd.Mana = 0;
                    playerToAdd.MaxMana = 0;
                    break;

                case 2:
                    playerToAdd.PlayerClass = "Samurai";
                    playerToAdd.Hp =100;
                    playerToAdd.MaxHp =100;
                    playerToAdd.Damage =20;
                    playerToAdd.Mana = 0;
                    playerToAdd.MaxMana = 0;
                    break;

                case 3:
                    playerToAdd.PlayerClass = "Mage";
                    playerToAdd.Hp =80;
                    playerToAdd.MaxHp =80;
                    playerToAdd.Damage =15;
                    playerToAdd.Mana = 50;
                    playerToAdd.MaxMana = 50;
                    playerToAdd.SpecialAttack = 50;

                    break;


                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }


            return playerToAdd;

        }



    }
}
