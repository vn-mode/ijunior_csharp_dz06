using System;

namespace vn_mode_csharp_dz06
{
    class Program
    {
        static void Main(string[] args)
        {

            int countGold;
            int ourCrystals;
            int priceOneCrystal = 3;

            Console.Write("Сколько у вас в кошельке золота? : ");
            countGold = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Сегодня у нас акция и 1 кристалл  = {priceOneCrystal} золота.");
            Console.Write("Сколько кристаллов вы хотите купить? : ");
            ourCrystals = Convert.ToInt32(Console.ReadLine());

            countGold -= ourCrystals * priceOneCrystal;

            Console.WriteLine($"У вас в кошельке теперь {ourCrystals} кристаллов и {countGold} золота.");
        }
    }
}
