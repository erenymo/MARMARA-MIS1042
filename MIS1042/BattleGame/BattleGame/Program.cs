namespace BattleGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fire(10, 100, true);
        }

        static void Fire(int weaponType, float enemyHealth, bool penalty)
        {
            // 5 types of weapons

            int projectileEnergyLevel = 0;

            // switch statements

            switch (weaponType)
            {
                case 0:
                    Console.WriteLine("Weapon type 0");
                    break;
                case 1:
                    Console.WriteLine("Weapon type 1");
                    break;
                case 2:
                    Console.WriteLine("Weapon type 2");
                    break;
                case 3:
                    Console.WriteLine("Weapon type 3");
                    break;
                case 4:
                    Console.WriteLine("Weapon type 4");
                    break;
                default:
                    Console.WriteLine($"There is no such thing as weapon type {weaponType}");
                    Console.WriteLine("Pick one of weapons between 0 to 4");
                    break;

            }
        }
    }
}