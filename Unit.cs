

namespace ConsoleApp1
{
    internal class Unit
    {
        private float _health;
        
        public float Armor { get; set; }
        public string Name { get; }
        public int Damage { get; }

        public float Health => _health;

        public Unit(int damage=5, float armor=0.6f)
        {
            Damage = damage;
            Armor = armor;
        }

        public Unit() : this("Unknown Unit")
        {
        }

        public Unit(string name) { 
            Name = name;
        }

        public float GetRealHealth()
        {
            return Health * (1f + Armor);
        }

        public bool SetDamage(int damage)
        {
            _health = Health - damage * Armor;

            if(Health <= 0f)
            {
                return true; 
            }
            else
            {
                return false;
            }
        }
    }
}
