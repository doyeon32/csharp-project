using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("=== Number Guessing Game ===");
            Console.WriteLine("1. 게임 시작");
            Console.WriteLine("2. 종료");
            Console.Write("선택: ");

            string menu = Console.ReadLine();

            if (menu == "1")
            {
                PlayGame();
            }
            else if (menu == "2")
            {
                Console.WriteLine("게임을 종료합니다.");
                break;
            }
            else
            {
                Console.WriteLine("1 또는 2를 입력해주세요.");
            }

            Console.WriteLine();
        }
    }

    static void PlayGame()
    {
        Random random = new Random();
        int answer = random.Next(1, 101);
        int count = 0;

        while (true)
        {
            Console.Write("숫자를 입력하세요: ");
            int number = int.Parse(Console.ReadLine());

            count++;

            if (number < answer)
            {
                Console.WriteLine("UP!");
            }
            else if (number > answer)
            {
                Console.WriteLine("DOWN!");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("정답입니다!");
                Console.WriteLine("시도 횟수: " + count + "회");
                break;
            }
        }

        Console.WriteLine();
        Console.Write("다시 하시겠습니까? (Y/N): ");
        string restart = Console.ReadLine();

        if (restart == "Y" || restart == "y")
        {
            PlayGame();
        }
    }
}