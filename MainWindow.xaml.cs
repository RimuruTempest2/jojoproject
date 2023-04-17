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

namespace Exam1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        jojoEntities ex = new jojoEntities();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Vxod_Click(object sender, RoutedEventArgs e)
        {
            string a, b, c, d;
            
            a = login12.Text.ToString();
            b = Parol.Password.ToString();

            var zapr = ex.Sotrudnik.Single(s => s.Login == a);
            c = zapr.Login.ToString();
            d = zapr.Pass.ToString();

            if (a == "Alexs12" &&  b == d)
            {
                Perexod.Navigate(new Zapi());
                MessageBox.Show("Вы авторизованы в системе!");
            }

           else if (a == "Borod2" && b == d)
            {
                Perexod.Navigate(new Zapi());
                MessageBox.Show("Вы авторизованы в системе!");
            }

           else if (a == "Borz1" && b == d)
            {
                Perexod.Navigate(new Zapi());
                MessageBox.Show("Вы авторизованы в системе!");
            }

            else { MessageBox.Show("Пользователь не найден!"); }

        }
    }
}
