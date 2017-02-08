using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binary_gap
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Solution(1041);
            Console.WriteLine(result);
        }

        public static int Solution(int N)
        {
            List<int> gap_list = new List<int>();
            string bin = IntToBinary(N);

            int count = -1;

            for (int i = 0; i < bin.Length; i++)
            {
                if (bin[i] == '1')
                {
                    if (count > 0)
                    {
                        gap_list.Add(count);
                        count = -1;
                    }
                    else if (count < 0)
                    {
                        count = 0;
                    }
                }

                if (bin[i] == '0')
                {
                    if (count >= 0)
                    {
                        count++;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            if (gap_list.Count > 0)
            {
                int max = gap_list.Max();
                return max;
            }
            else
            {
                return 0;
            }
        }

        public static string IntToBinary(int value)
        {
            string binary = Convert.ToString(value, 2);
            return binary;
        }
    }
}
