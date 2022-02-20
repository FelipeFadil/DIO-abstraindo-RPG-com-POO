namespace RPG_usando_POO.src.Entities
{
    public abstract class Hero
    {
        public Hero(string Name, int Level, string HeroType, int HealthPoint, int MagicPoint)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HealthPoint = HealthPoint;
            this.MagicPoint = MagicPoint;
        }

        public Hero()
        {
            
        }

        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }
        public int HealthPoint { get; set; }
        public int MagicPoint { get; set; }

        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType;
        }

        public virtual string Attack()
        {
            return this.Name + " atacou com a espada";
        }
    }
}