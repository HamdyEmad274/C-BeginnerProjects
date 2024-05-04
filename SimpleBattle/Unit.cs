namespace SimpleBattle
{
    internal class Unit
    {
        private int currentHealth;
        private int maxHealth;
        private int attackPower;
        private int healPower;
        private string unitName;
        private Random random;
        public int Hp { get { return currentHealth; } }
        public string UnitName { get { return unitName; } }
        public bool IsDead { get{return currentHealth <= 0;} }

        public Unit( int maxHealth, int attackPower, int healPower, string name )
        {
            this.currentHealth = maxHealth;
            this.maxHealth = maxHealth;
            this.attackPower = attackPower;
            this.healPower = healPower;
            this.unitName = name;
            this.random = new Random();
            
        }

        public void Attack(Unit target)
        {
            double rnd = random.NextDouble();
            rnd = rnd /2 + 0.75f;
            int rndDamage = (int)(attackPower * rnd);
            target.TakeDamage(rndDamage);
            Console.WriteLine($"{unitName} attacked {target.unitName} for {rndDamage} damage");
        }
        private void TakeDamage(int rndDamage)
        {
            currentHealth -= rndDamage;
            if (IsDead)
            {
                Console.WriteLine($"{unitName} has died");
            }
        }

        public void Heal()
        {
            double rnd = random.NextDouble();
            rnd = rnd / 2 + 0.75f;
            int rndHeal = (int)(healPower * rnd);
            currentHealth = Math.Min(currentHealth + rndHeal, maxHealth);
            Console.WriteLine($"{unitName} healed for {rndHeal} health");
        }

    }
}
