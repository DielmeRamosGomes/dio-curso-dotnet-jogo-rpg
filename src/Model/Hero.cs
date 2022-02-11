namespace jogorpg.src.Model
{
    public class Hero
    {
        readonly IAttack attack;
        readonly IDisplay display;
        public string Name;
        public int Level;
        public string TypeHero;

        public Hero(string Name, int Level, string TypeHero, IAttack attack, IDisplay display)
        {
            this.Name = Name;
            this.Level = Level;
            this.TypeHero = TypeHero;
            this.attack = attack;
            this.display = display;
        }

        public override string ToString()
        {
            return this.display.Display(this.Name, this.Level, this.TypeHero);
        }

        public string Attack()
        {
            return this.attack.Attack(this.Name);
        }


    }
}
