using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace WordNumberConverter
{
    public class WordComparer : IComparer
    {
        #region IComparer Members

        public int Compare(object x, object y)
        {
            if (x == null) { return 0; }

            if (y == null) { return 0; }

            if (!(x is NumWord)) { return 0; }

            if (!(y is NumWord)) { return 0; }

            NumWord num1 = x as NumWord;
            NumWord num2 = y as NumWord;

            // Многозначное число больше цифры
            if (num1.Num.Length != num2.Num.Length)
            {
                return num1.Num.Length > num2.Num.Length ? 1 : -1;
            }

            // Сортировка по числу
            {
                int comp = string.Compare(num1.Num, num2.Num, true);

                if (comp != 0)
                {
                    return comp;
                }
            }

            // Сортировка по длине полного числа
            if (num1.FullNumber.Length != num2.FullNumber.Length)
            {
                return num1.FullNumber.Length > num2.FullNumber.Length ? 1 : -1;
            }

            //{
            //    int comp = string.Compare(num1.FullNumber, num2.FullNumber, true);

            //    if (comp != 0)
            //    {
            //        return comp;
            //    }
            //}

            {
                int ind1 = num1.GetIndexFirstNumber();
                int ind2 = num2.GetIndexFirstNumber();

                if (ind1 != -1 && ind2 != -1 && ind1 != ind2)
                {
                    return ind1 > ind2 ? 1 : -1;
                }
            }


            {
                int comp = string.Compare(num1.Line, num2.Line, true);

                if (comp != 0)
                {
                    return comp;
                }
            }

            return 0;
        }

        #endregion
    }
}
