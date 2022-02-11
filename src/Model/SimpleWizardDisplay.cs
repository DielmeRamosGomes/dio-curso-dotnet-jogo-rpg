namespace jogorpg.src.Model
{
    public class SimpleWizardDisplay: IDisplay
    {
        public string Display(string Name, int Level, string TypeHero)
        {
            return "Minha White Wizard: " + Name + " " + Level + " " + TypeHero;
        }
    }
}
