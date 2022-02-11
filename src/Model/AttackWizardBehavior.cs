namespace jogorpg.src.Model
{
    public class AttackWizardBehavior : IAttack
    {
        public string Attack(string name)
        {
            return name + " Atacou com uma magia branca";
        }
    }
}
