using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySportCartFramework.Utilities
{
    static class RandomNumberAndStringGenerator
    {
        // RandomNumberAndStringGenerator.GenerateRandomNumber()
        // RandomNumberAndStringGenerator.GenerateRandomNumber(1,10)
        // RandomNumberAndStringGenerator.GenerateRandomNumber(100000,999999)
        public static int GenerateRandomNumber(int min = int.MinValue, int max = int.MaxValue)
        {
            Random random = new Random();
            int result=random.Next(min, max);
            // TODO: Repeats the same character
            return result;
        }

        // RandomNumberAndStringGenerator.GenerateRandomString(true, 10)   // GHJKLUYTBP
        // RandomNumberAndStringGenerator.GenerateRandomString(false, 10) // hgj23,,n34
        public static string GenerateRandomString(bool onlyAlpha = true, int length = 1)
        {
            StringBuilder sb = new StringBuilder();
            if (onlyAlpha)
            {
                for (int i = 0; i < length; i++)
                {
                    char ch = Convert.ToChar(GenerateRandomNumber(65, 90));
                    sb.Append(ch);
                }
            }
            else
            {
                for (int i = 0; i < length; i++)
                {
                    char ch = Convert.ToChar(GenerateRandomNumber(33, 126));
                    sb.Append(ch);
                }
            }

            return sb.ToString();
        }
        
    }
}
