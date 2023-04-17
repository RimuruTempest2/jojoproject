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
using System.Windows.Shapes;

namespace Exam1
{
    /// <summary>
    /// Логика взаимодействия для Dialog.xaml
    /// </summary>
    public partial class Dialog : Window
    {

        jojoEntities ex = new jojoEntities();
        public Dialog()
        {
            InitializeComponent();

        }

       /* private void Canc_Click(object sender, RoutedEventArgs e)
        {

            Dialog dl = new Dialog();
            dl.Close();
            
        }*/

        private void Okk_Click(object sender, RoutedEventArgs e)
        {
          

            if (Sotr_v.Text != "" && Nomer_z.Text != "")
            {
                string name_s = Sotr_v.Text.ToString();
                string nomer_z = Nomer_z.Text.ToString();

                var Id_z = ex.Zapisi.Max(d => d.Id_zapis);

                int a = 0; 

                switch (Sotr_v.Text)
                {
                    case "Бородина Н.Л.":
                        a = 1;
                        break;

                    case "Борзова П.Р.":
                        a = 2;
                        break;
                    
                    case "Алексеева Л.Д.":
                        a = 3;
                        break;
                }

                switch (Nomer_z.Text)
                {

                    case "6":
                        Zapisi zp = new Zapisi { Id_zapis = Id_z + 1, FIO = "Валюев П.П.", Data_z = Convert.ToDateTime("16-04-2023"), Id_sotr = a, Name_usl = "Стрижка" };
                        ex.Zapisi.Add(zp);
                        ex.SaveChanges();
                        MessageBox.Show("Заявка одобрена!");
                        break;

                    case "7":
                        Zapisi zp1 = new Zapisi { Id_zapis = Id_z + 1, FIO = "Петрова А.А.", Data_z = Convert.ToDateTime("16-04-2023"), Id_sotr = a, Name_usl = "Маникюр" };
                        ex.Zapisi.Add(zp1);
                        ex.SaveChanges();
                        MessageBox.Show("Заявка одобрена!");
                        break;
                }
                    


            }
            else { MessageBox.Show("Заполните обязательные поля!"); }
        }
    }
}
