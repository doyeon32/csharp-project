namespace TextRPG
{
    class Player : Character
    {
        public Player(string name)
            : base(name, 100, 15)
        {

        }
        
        public void Heal()
        {
            HP += 10;

            if(HP > 100)
                HP = 100;

            Console.WriteLine("회복했습니다!");
        }
    }
}