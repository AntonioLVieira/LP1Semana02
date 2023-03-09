using System;

namespace Specials
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte max_sb = sbyte.MaxValue;
            sbyte min_sb = sbyte.MinValue;
            double max_db = double.MaxValue;
            double min_db = double.MinValue;
            ulong max_ul = ulong.MaxValue;
            ulong min_ul = ulong.MinValue;
            Console.WriteLine("The max. Value for a sbyte is: " + max_sb + " and the min. Value is: " + min_sb);
            Console.WriteLine("The max. Value for a double is: " + max_db + " and the min. Value is: " + min_db);
            Console.WriteLine("The max. Value for a ulong is: " + max_ul + " and the min. Value is: " + min_ul);

        }
    }
}
