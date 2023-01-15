using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Pattern_MVC
{
    public static class Model
    {
        public static List<string> arifmetika = new List<string> { "Сложение", "Вычитание", "Умножение", "Деление" };
        public static List<string> znaki = new List<string> { "+", "-", "*", "/" };
        


        public static TextBlock rez;
        public static TextBlock tbCombo;
        public static TextBox per;
        public static TextBox vtor;
        public static int Rezultat
        {
            set
            {
                try
                {
                    string prev = per.Text;
                    double pervoe = Convert.ToDouble(prev);
                    string vtoro = vtor.Text;
                    double vtoroe = Convert.ToDouble(vtoro);
                    double rezul;
                    switch (value)
                    {
                        case 0:
                            rezul = pervoe + vtoroe;
                            rez.Text = rezul.ToString();
                            break;
                        case 1:
                            rezul = pervoe - vtoroe;
                            rez.Text = rezul.ToString();
                            break;
                        case 2:
                            rezul = pervoe * vtoroe;
                            rez.Text = rezul.ToString();
                            break;
                        case 3:
                            rezul = pervoe / vtoroe;
                            rez.Text = rezul.ToString();
                            break;
                    }
                }
                catch
                {
                    rez.Text = "Ошибка";
                }
            }
        }
        public static int Combo  // свойтсво для отображения фамилии в Combobox
        {
            set
            {
                tbCombo.Text = znaki[value];
            }
        }
    }
}
