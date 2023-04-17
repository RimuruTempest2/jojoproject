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
    /// Логика взаимодействия для Zapi.xaml
    /// </summary>
    public partial class Zapi : Page

    {
        jojoEntities ex = new jojoEntities ();

        public Zapi()
        {
            InitializeComponent();
            Zap.ItemsSource = ex.Zapisi.ToList();
            
        }

        private void Zay_Click(object sender, RoutedEventArgs e)
        {
            Perexod.Navigate(new Zaayvky());
        }

        private void Prosmotr_Click(object sender, RoutedEventArgs e)
        {
            Perexod.Navigate(new F1());
        }
    }
}
