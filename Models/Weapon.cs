namespace Weapontask.Models
{
    public class Weapon
    {
        public int BulletCapacity { get; private set; }
        public int Magazine { get; private set; }
        public FireMode FireMode { get; private set; }

        public Weapon(int bulletCapacity, int magazine, FireMode fireMode)
        {
            if (bulletCapacity <= 0)
            {
                Console.WriteLine("Bullet capacity must be greater than 0.");
            }
            if (magazine < 0 || magazine > bulletCapacity)
            {
                Console.WriteLine("Magazine bullets must be between 0 and capacity.");
            }
            BulletCapacity = bulletCapacity;
            Magazine = magazine;
            FireMode = fireMode;
        }
        public void SetFireMode(FireMode fireMode)
        {
            FireMode = fireMode;
            Console.WriteLine($"Fire mode set to: {fireMode}");
        }
        public void Shoot()
        {
            if (Magazine <= 0)
            {
                Console.WriteLine("No bullets left. Reload before shooting.");
            }
            else
            {
                Magazine--;
                Console.WriteLine("Shoot...");
                Console.WriteLine($"Remaining bullets: {Magazine}");
            }
        }
        public void Fire()
        {
            if (Magazine <= 0)
            {
                Console.WriteLine("No bullets left. Reload before firing.");
            }
            else
            {
                switch (FireMode)
                {
                    case FireMode.Single:
                        Magazine--;
                        Console.WriteLine("Firing 1 bullet...");
                        break;
                    case FireMode.Burst:
                        Magazine = Magazine - 3;
                        Console.WriteLine("Firing 3 bullet...");
                        break;
                    case FireMode.Auto:
                        Console.WriteLine($"Firing all {Magazine} bullets...");
                        Magazine = 0;
                        break;
                    default:
                        throw new InvalidFireModeException("Invalid fire mode. Try again!");
                }

            }
        }
        public void Reload()
        {
            int count = BulletCapacity - Magazine;
            if (count == 0)
            {
                Console.WriteLine("Magazine is already full.");
            }
            else
            {
                Magazine = BulletCapacity;
                Console.WriteLine($"Reloaded {count} bullets. Magazine full.");
            }
        }
        public int GetRemainBulletCount()
        {
            int count = BulletCapacity - Magazine;
            Console.WriteLine($"Bullets needed to reload: {count}");
            return count;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Magazine/Bullet Capacity: {Magazine}/{BulletCapacity}, Mode: {FireMode}");
        }
        public void Edit(int newBulletCapacity, int newMagazine)
        {
            if (newBulletCapacity <= 0)
            {
                Console.WriteLine("Bullet capacity must be greater than 0.");
                return;
            }

            if (newMagazine < 0 || newMagazine > newBulletCapacity)
            {
                Console.WriteLine("Invalid Magazine size. Magazine cannot exceed Bullet Capacity.");
                return;
            }

            BulletCapacity = newBulletCapacity;
            Magazine = newMagazine;
            Console.WriteLine($"Updated Bullet Capacity to {newBulletCapacity} and Magazine to {newMagazine}");
        }
    }
}


