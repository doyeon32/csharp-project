using System;

namespace TextRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Text RPG ===");
            Console.Write("플레이어 이름 : ");
            string name = Console.ReadLine();

            Player player = new Player(name);
            Enemy enemy = new Enemy("Slime");

            Console.WriteLine();
            Console.WriteLine($"{enemy.Name} 등장!");

            while(true)
            {

                Console.WriteLine();
                Console.WriteLine($"{player.Name} HP : {player.HP}");
                Console.WriteLine($"{enemy.Name} HP : {enemy.HP}");

                Console.WriteLine();
                Console.WriteLine("1. 공격");
                Console.WriteLine("2. 상태 확인");
                Console.WriteLine("3. 회복");

                Console.Write("선택 : ");

                string input = Console.ReadLine();

                if(input == "1")
                {
                    player.Attack(enemy);

                    if(enemy.IsDead())
                    {
                        Console.WriteLine("승리!");
                        break;
                    }

                    enemy.Attack(player);

                    if(player.IsDead())
                    {
                        Console.WriteLine("패배...");
                        break;
                    }

                }

                else if(input == "2")
                {
                    Console.WriteLine(
                        $"{player.Name} HP : {player.HP}"
                    );

                    Console.WriteLine(
                        $"{enemy.Name} HP : {enemy.HP}"
                    );
                }

                else if(input == "3")
                {
                    player.Heal();
                }

                else
                {
                    Console.WriteLine("잘못된 입력입니다.");
                }
            }
            Console.WriteLine("게임 종료");
        }
    }
}