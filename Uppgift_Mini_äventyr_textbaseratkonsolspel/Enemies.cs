



namespace Uppgift_Mini_äventyr_textbaseratkonsolspel
{
    public class Enemy
    {


        public string EnemyType;
        public int Hp;
        public int MaxHp;
        public int Damage;
        public int GoldReward;


        public static Enemy CreateEnemy()
        {

            Enemy enemy = new Enemy();

            string[] enemyType = { "Goblin", "Skeleton", "Bandit" };

            Random rnd = new Random();
            int numb = rnd.Next(enemyType.Length);

            switch (numb)
            {

                case 0:
                    enemy.EnemyType = "Goblin";
                    enemy.Hp = 50;
                    enemy.MaxHp = 50;
                    enemy.Damage = 10;
                    enemy.GoldReward = 20;

                    break;

                case 1:
                    enemy.EnemyType = "Skeleton";
                    enemy.Hp = 70;
                    enemy.MaxHp = 70;
                    enemy.Damage = 15;
                    enemy.GoldReward = 30;

                    break;

                case 2:
                    enemy.EnemyType = "Bandit";
                    enemy.Hp = 90;
                    enemy.MaxHp = 90;
                    enemy.Damage = 20;
                    enemy.GoldReward = 40;

                    break;

            }


            return enemy;

        }



    }
}
