using System;

namespace TextRPG
{
    class Character
    {
        public string Name;
        public int HP;
        public int AttackPower;

        public Character(string name, int hp, int attackPower)
        {
            Name = name;
            HP = hp;
            AttackPower = attackPower;
        }

        public void Attack(Character target)
        {
            Console.WriteLine($"{Name}의 공격!");

            target.HP -= AttackPower;

            Console.WriteLine($"{target.Name}에게 {AttackPower} 데미지!");
        }

        public bool IsDead()
        {
            return HP <= 0;
        }
    }
}