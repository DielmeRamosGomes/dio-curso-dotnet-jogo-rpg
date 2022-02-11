using jogorpg.src.Model;

namespace jogorpg
{
    public class Program
    {
        static void Main()
        {
            Hero hero = new("Arus", 23, "Knight", new AttackHeroBehavior(), new SimpleHeroDisplay());
            Hero wizard = new("Jessica", 23, "White Wizard", new AttackWizardBehavior(), new SimpleWizardDisplay());
            
            Console.WriteLine(hero.ToString());
            Console.WriteLine(hero.Attack());
            Console.WriteLine();
            Console.WriteLine(wizard.ToString());
            Console.WriteLine(wizard.Attack());
            
        }
    }
}
