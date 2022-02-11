namespace jogorpg.src.Model
{
    public class AttackHeroBehavior : IAttack
    {
        public string Attack(string name)
        {
            return name + " Atacou com sua espada";
        }

    }
}
