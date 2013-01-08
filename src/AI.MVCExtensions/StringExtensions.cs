using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AI.MVCExtensions
{
    public static class StringExtensions
    {
        public static string TakeTop(this String input, int amountToTake,bool addEllipses)
        {
            string trail = (addEllipses) ? "..." : String.Empty;

            return new String(input.Take(amountToTake).ToArray()) + trail;
        }

        public static string TakeBottom(this String input, int amountToTake, bool addEllipses)
        {
            string head = (addEllipses) ? "..." : String.Empty;
            var skip = input.Length - amountToTake;
            return head + new String(input.Skip(skip).Take(amountToTake).ToArray());
            
        }

        public static bool IsEmail(this String input)
        {
            return Regex.IsMatch(input, RegExFormulas.Email);
        }

        public static bool HasHtml(this String input)
        {
            return Regex.IsMatch(input, RegExFormulas.Html);
        }

        public static string RemoveHtml(this String input)
        {
            return Regex.Replace(input, RegExFormulas.Html, String.Empty);
        }

        public static bool IngoreCaseCompare(this String input, String input2)
        {
            if (input == null || input2 == null)
                return false;
            if (input == null && input2 == null)
                return true;

            return input.ToLower().Trim() == input2.Trim().ToLower();

        }

        public static bool IsCardNumberValid(this String cardNumber)
        {
            int i, checkSum = 0;

            for (i = cardNumber.Length - 1; i >= 0; i -= 2)
                checkSum += (cardNumber[i] - '0');

            // Now take digits not included in first checksum, multiple by two,
            // and compute checksum of resulting digits
            for (i = cardNumber.Length - 2; i >= 0; i -= 2)
            {
                int val = ((cardNumber[i] - '0') * 2);
                while (val > 0)
                {
                    checkSum += (val % 10);
                    val /= 10;
                }
            }

            // Number is valid if sum of both checksums MOD 10 equals 0
            return ((checkSum % 10) == 0);
        }

        private static IList<char[]> Unzip(this String input, int joinDistance)
        {
            int i = -1;
            Func<int,int> getCount = a => a++;
                  
            var query = from c in input select new {Position = getCount(i), Value = c};
            var results = new Dictionary<int, char[]>();
            var setToPull = 2;
            while (setToPull <= joinDistance)
            {
                results[setToPull] = (from items in query where items.Position%setToPull == 0 select items.Value).ToArray();
            }

            return results.Values.ToArray();

        }


        
    }
}
