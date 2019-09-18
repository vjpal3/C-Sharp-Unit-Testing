using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTDD
{
    public class RomanNumerals
    {
        public static readonly Dictionary<char, int> RomanValues = new Dictionary<char, int>()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
         };

        public static int ParseRomanNumeralsToDigits(string romanNumeral)
        {
            // //If roman string is in invalid format, this code throws exception
            int number = 0;
            for (var i = 0; i < romanNumeral.Length; i++)
            {
                if (i < romanNumeral.Length - 1 && IsSubtractive(romanNumeral[i], romanNumeral[i + 1]))
                {
                    number -= RomanValues[romanNumeral[i]];
                }
                else
                    number += RomanValues[romanNumeral[i]];
            }
            return number;

            //If roman string is in invalid format, this code returns 0
            //int number = 0;
            //for(var i = 0; i < romanNumeral.Length; i++)
            //{
            //    int currentVal = 0;
            //    if(RomanValues.TryGetValue(romanNumeral[i], out currentVal))
            //    {
            //        if (i < romanNumeral.Length - 1)
            //        {
            //            int nextVal = 0;
            //            if (RomanValues.TryGetValue(romanNumeral[i + 1], out nextVal))
            //            {
            //               if (currentVal < nextVal)
            //                    currentVal *= -1;
            //            }
            //            else
            //                return 0;
            //        }
            //        number += currentVal;
            //    }
            //    else
            //        return 0;
            //}
            //return number;
        }

        private static bool IsSubtractive(char v1, char v2)
        {
            return RomanValues[v1] < RomanValues[v2];
        }

        
    }
}
