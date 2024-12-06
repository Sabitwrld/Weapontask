using Weapontask.Models;

namespace Weapontask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Weapon ak47 = new Weapon(30, 25, FireMode.Single);
            #region testing...
            //ak47.Shoot();
            //ak47.Fire();
            //ak47.Reload();
            //ak47.ShowInfo();
            //ak47.SetFireMode(FireMode.Burst);
            //ak47.Fire();
            //ak47.GetRemainBulletCount();
            //ak47.ShowInfo();
            //ak47.Edit(40, 30);
            //ak47.ShowInfo();
            #endregion

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Created By Sabit Jafarov");
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("0 - Show info");
                Console.WriteLine("1 - Shoot");
                Console.WriteLine("2 - Fire");
                Console.WriteLine("3 - Get remaining bullet count");
                Console.WriteLine("4 - Reload");
                Console.WriteLine("5 - Change fire mode");
                Console.WriteLine("6 - Exit");
                Console.WriteLine("7 - Edit weapon");
                Console.WriteLine("8 - Change Bullet Capacity");
                Console.WriteLine("9 - Change Magazine count");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "0":
                        ak47.ShowInfo();
                        break;
                    case "1":
                        ak47.Shoot();
                        break;
                    case "2":
                        ak47.Fire();
                        break;
                    case "3":
                        ak47.GetRemainBulletCount();
                        break;
                    case "4":
                        ak47.Reload();
                        break;
                    case "5":
                        Console.WriteLine("Enter fire mode (0 - Single, 1 - Burst, 2 - Auto)");
                        string fireModeInput = Console.ReadLine();
                        if (fireModeInput == "0")
                        {
                            ak47.SetFireMode(FireMode.Single);
                        }
                        else if (fireModeInput == "1")
                        {
                            ak47.SetFireMode(FireMode.Burst);
                        }
                        else if (fireModeInput == "2")
                        {
                            ak47.SetFireMode(FireMode.Auto);
                        }
                        else
                        {
                            Console.WriteLine("Invalid fire mode.");
                        }
                        break;

                    case "6":
                        exit = true;
                        break;
                    case "7":
                        Console.WriteLine("Enter new Bullet Capacity:");
                        int newBulletCapacity = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter new Magazine:");
                        int newMagazine = int.Parse(Console.ReadLine());
                        ak47.Edit(newBulletCapacity, newMagazine);
                        break;
                    case "8":
                        Console.WriteLine("Enter new Bullet Capacity:");
                        int newBulletCapacityOnly = int.Parse(Console.ReadLine());
                        ak47.Edit(newBulletCapacityOnly, ak47.Magazine);
                        break;
                    case "9":
                        Console.WriteLine("Enter new Magazine count:");
                        int newMagazineCount = int.Parse(Console.ReadLine());
                        ak47.Edit(ak47.BulletCapacity, newMagazineCount);
                        break;
                    default:
                        throw new InvalidFireModeException("Invalid fire mode. Try again!");
                }
            }
        }
    }
}
