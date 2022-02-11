namespace jogorpg.src.Model
{
    public class SimpleHeroDisplay: IDisplay
    {
        public string Display(string Name, int Level, string TypeHero)
        {
            return "Meu Hero: " + Name + " " + Level + " " + TypeHero;
        }

    }
}
