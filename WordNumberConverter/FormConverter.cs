using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace WordNumberConverter
{
    public partial class FormConverter : Form
    {
        public FormConverter()
        {
            InitializeComponent();
        }

        private void tSBConvertToNumbers_Click(object sender, EventArgs e)
        {
            SortedList result = new SortedList(new WordComparer());

            foreach (string fileName in txtBFiles.Lines)
            {
                ArrayList list = Common.OperateDictionary(fileName);

                foreach (string line in list)
                {
                    string num = Common.GetNumber(line);

                    if (!string.IsNullOrEmpty(num))
                    {
                        if (num.Length > 1)
                        {
                            NumWord temp = new NumWord(line, num.Substring(0, 2), num);

                            result.Add(temp, temp);
                        }
                        else
                        {
                            NumWord temp = new NumWord(line, num, num);

                            result.Add(temp, temp);
                        }
                    }
                }
            }

            StringBuilder strBuilder = new StringBuilder();

            string currentNum = string.Empty;

            foreach (NumWord item in result.Values)
            {
                if (item.Num != currentNum)
                {
                    if (strBuilder.Length > 0)
                    {
                        strBuilder.AppendLine();
                        strBuilder.AppendLine();
                        strBuilder.AppendLine();
                    }

                    strBuilder.AppendLine(item.Num);
                    strBuilder.AppendLine();

                    currentNum = item.Num;
                }

                strBuilder.AppendLine(item.ToString());
            }

            txtBResult.Text = strBuilder.ToString();

            MessageBox.Show("Готово");
        }

        private void tSBGenerateNumbers_Click(object sender, EventArgs e)
        {
            StringBuilder strBuilder = new StringBuilder();

            for (int i = 0; i < 10; i++)
            {
                strBuilder.AppendLine(i.ToString());
            }

            for (int i = 0; i < 100; i++)
            {
                strBuilder.AppendLine(i.ToString("D2"));
            }

            txtBResult.Text = strBuilder.ToString();

            MessageBox.Show("Готово");
        }
    }
}
