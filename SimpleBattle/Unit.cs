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

        public Unit( int maxHealth, int attackPower, int healPower, string name )
        {
            this.currentHealth = maxHealth;
            this.maxHealth = maxHealth;
            this.attackPower = attackPower;
            this.healPower = healPower;
            this.unitName = name;
            this.random = new Random();
            
        }
        private void TakeDamage(int rndDamage)
        {
            currentHealth -= rndDamage;
        }

        public void Attack(Unit target)
        {
            double rnd = random.NextDouble();
            rnd = rnd /2 + 0.75f;
            int rndDamage = (int)(attackPower * rnd);
            target.TakeDamage(rndDamage);
            Console.WriteLine($"{unitName} attacked {target.unitName} for {rndDamage} damage");
        }

    }
}
