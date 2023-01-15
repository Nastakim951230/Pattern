using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pattern_MVC
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Model.tbCombo = Znac;
            Model.rez = Rezultat;
            Model.per = Pervoe;
            Model.vtor = Vtoroe;
            arifmetika.ItemsSource = Model.arifmetika;
            arifmetika.SelectedIndex = 0;
          
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Model.Rezultat = arifmetika.SelectedIndex;
        }

        private void arifmetika_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Model.Combo = arifmetika.SelectedIndex;
        }
    }
}
