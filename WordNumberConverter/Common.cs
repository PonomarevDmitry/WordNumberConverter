using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;

namespace WordNumberConverter
{
    public static class Common
    {
        private static readonly string[] numberAlphabet = new string[] { "НЛ", "Р", "ДГ", "ТЗ", "ЧК", "ПБ", "ШЖЩ", "СЦ", "ВФ", "МХ" };

        public static string GetAlphabetForNumber(int num)
        {
            return numberAlphabet[num];
        }

        public static string GetNumber(string questionText)
        {
            StringBuilder strBilder = new StringBuilder(questionText.ToUpper());

            for (int i = 0; i < numberAlphabet.Length; i++)
            {
                string item = numberAlphabet[i];

                foreach (char ch in item)
                {
                    strBilder.Replace(ch, (char)('0' + i));
                }
            }

            StringBuilder resultBuilder = new StringBuilder();

            for (int i = 0; i < strBilder.Length; i++)
            {
                char ch = strBilder[i];

                if (char.IsDigit(ch))
                {
                    resultBuilder.Append(ch);
                }
            }

            return resultBuilder.ToString();
        }

        public static ArrayList OperateDictionary(string fileName)
        {
            ArrayList result = new ArrayList();

            if (File.Exists(fileName))
            {
                Hashtable table = new Hashtable();

                using (StreamReader stringReader = File.OpenText(fileName))
                {
                    if (stringReader != null)
                    {
                        while (!stringReader.EndOfStream)
                        {
                            string line = stringReader.ReadLine();
                            line = line.Trim().ToLower();

                            if (!string.IsNullOrEmpty(line))
                            {
                                line = line[0].ToString().ToUpper() + line.Substring(1);

                                if (!table.ContainsKey(line))
                                {
                                    table.Add(line, null);
                                    result.Add(line);
                                }
                            }
                        }

                        stringReader.Close();
                    }
                }
            }

            return result;
        }
    }
}
