namespace RPG_usando_POO.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType, int HealthPoint, int MagicPoint)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HealthPoint = HealthPoint;
            this.MagicPoint = MagicPoint;
        }

        public override string Attack()
        {
            return this.Name + " lançou uma shuriken";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + " lançou uma shuriken super efetiva com bonus de " + Bonus;
            }
            else
            {
                return this.Name + " lançou uma shuriken com força fraca com bonus de " + Bonus;
            }
        }
    }
}