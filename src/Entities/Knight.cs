namespace RPG_usando_POO.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType, int HealthPoint, int MagicPoint)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HealthPoint = HealthPoint;
            this.MagicPoint = MagicPoint;
        }
    }
}