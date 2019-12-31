using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WordNumberConverter
{
    public class NumWord
    {
        /// <summary>
        /// Само слово
        /// </summary>
        public string Line { get; private set; }

        /// <summary>
        /// Число
        /// </summary>
        public string Num { get; private set; }

        /// <summary>
        /// Полное число
        /// </summary>
        public string FullNumber { get; private set; }

        public NumWord(string line, string num, string fullNumber)
        {
            this.Line = line;
            this.Num = num;
            this.FullNumber = fullNumber;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}", this.Line, this.FullNumber);
        }

        public int GetIndexFirstNumber()
        {
            int result = -1;

            if (this.Num.Length > 0)
            {
                int num1 = this.Num[0] - '0';

                string alphabet = Common.GetAlphabetForNumber(num1).ToLower();

                result = this.Line.ToLower().IndexOfAny(alphabet.ToCharArray());
            }

            return result;
        }

    }
}
