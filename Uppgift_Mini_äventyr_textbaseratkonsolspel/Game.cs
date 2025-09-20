namespace Uppgift_Mini_äventyr_textbaseratkonsolspel
{
    public class Game
    {


        public static void PlayerStatus(Player player)
        {

            Console.WriteLine($"Name: {player.Name}");
            Console.WriteLine($"Class: {player.PlayerClass}");
            Console.WriteLine($"Hp: {player.Hp}");
            Console.WriteLine($"Damage: {player.Damage}");
            Console.WriteLine($"Gold: {player.Gold}");
            Console.WriteLine($"Mana: {player.Mana}");

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

        }


        public static void Adventure(Player player)
        {


            Enemy enemy = Enemy.CreateEnemy();



            while (enemy.Hp > 0 && player.Hp > 0)
            {

                Console.Clear();

                Console.WriteLine("===CHOOSE YOUR MOVE===");
                Console.WriteLine("[1]. Attack");
                Console.WriteLine("[2]. Rest");

                if (player.PlayerClass == "Mage")
                {
                    Console.WriteLine("[3]. Special Attack (50 mana)");
                    Console.WriteLine("[4]. Exit");

                }
                else
                {
                    Console.WriteLine("[3]. Exit");
                }

                int choice = int.Parse(Console.ReadLine());

                Console.WriteLine(" ");

                switch (choice)
                {
                    case 1:
                        Game.Battle(player, enemy);
                        break;

                    case 2:
                        Game.Rest(player);
                        break;

                    case 3:
                        if (player.PlayerClass == "Mage")
                        {

                            Game.SpecialAttack(player, enemy);

                        }
                        else
                        {
                            return;
                        }
                        break;

                    case 4:

                        if (player.PlayerClass == "Mage")
                        {
                            return;
                        }
                        break;
                }

            }





        }

        public static void Battle(Player player, Enemy enemy)
        {



            Console.WriteLine($"You have {player.Hp}/{player.MaxHp} Hp. Enemy has {enemy.Hp}/{enemy.MaxHp} Hp");
            Console.WriteLine(" ");

            Console.WriteLine($"You hit {enemy.EnemyType} for {player.Damage}");
            enemy.Hp -= player.Damage;
            Console.WriteLine($"Enemy Hp: {enemy.Hp}/{enemy.MaxHp}");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.WriteLine(" ");

            Console.WriteLine($"{enemy.EnemyType} hit back for {enemy.Damage}");
            player.Hp -= enemy.Damage;
            Console.WriteLine($"Player Hp: {player.Hp}/{player.MaxHp}");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.WriteLine(" ");

            if (enemy.Hp <= 0)
            {
                Console.WriteLine("You win");
                Console.WriteLine($"You gained {player.Gold += enemy.GoldReward} Gold");
                Console.WriteLine("Don´t forget to rest before next battle!");
                Console.WriteLine("Press any key to quit");
                Console.ReadKey();
                return;

            }

            if (player.Hp <= 0)
            {
                Console.WriteLine("GAME OVER");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Program.running = false;

                return;
            }



        }


        public static void Rest(Player player)
        {

            Console.WriteLine("You chose to rest");

            int heald = Math.Min(player.Hp + 10, player.MaxHp) - player.Hp;
            player.Hp += heald;

            int manaHeal = Math.Min(player.Mana + 50, player.MaxMana) - player.Mana;
            player.Mana += manaHeal;

            Console.WriteLine($"You gained {heald} Hp");
            Console.WriteLine($"You now have {player.Hp}/{player.MaxHp}");

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }



        public static void SpecialAttack(Player player, Enemy enemy)
        {
            int manaCost = 50;
            if (player.Mana >= manaCost)
            {
                int damage = 50;

                Console.WriteLine($"You unleashed a special attack on {enemy.EnemyType}");
                enemy.Hp -= damage;
                player.Mana -= manaCost;

                Console.WriteLine($"Enemy Hp: {enemy.Hp}/{enemy.MaxHp}");
                Console.WriteLine($"Your mana is now {player.Mana}/{player.MaxMana}");
                Console.WriteLine(" ");





                if (enemy.Hp > 0)
                {
                    Console.WriteLine($"{enemy.EnemyType} hit back for {enemy.Damage}");
                    player.Hp -= enemy.Damage;
                    Console.WriteLine($"Player Hp: {player.Hp}/{player.MaxHp}");

                }

            }
            else
            {
                Console.WriteLine("Not enough mana!");
            }

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();




        }

    }
}

