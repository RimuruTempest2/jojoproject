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
    /// Логика взаимодействия для Zaayvky.xaml
    /// </summary>
    public partial class Zaayvky : Page
    {
        jojoEntities ex = new jojoEntities();

        public Zaayvky()
        {
            InitializeComponent();
            Zavav.ItemsSource = ex.Zayavky.ToList();
        }

        private void Prin_Click(object sender, RoutedEventArgs e)
        {
            Dialog dl = new Dialog();
            dl.Show();
        }

        private void Otkl_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Nazad_Click(object sender, RoutedEventArgs e)
        {
            Content = null;
        }
    }
}
