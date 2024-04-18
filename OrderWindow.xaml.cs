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

namespace chistyakovexemen
{
    /// <summary>
    /// Логика взаимодействия для OrderWindow.xaml
    /// </summary>
    public partial class OrderWindow : Window
    {
        string[] xlebarr = { "Серый - 10р", "Белый - 5р", "Ржаной - 15р" };
        string[] ord = { };
        int count = 0;

        public OrderWindow()
        {
            InitializeComponent();
            for (int i = 0; i < xlebarr.Length; i++)
            {
                Xleb.Items.Add(xlebarr[i]);
            } 
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();   
            mainWindow.Show();
            this.Close();
        }

        private void Sklad_Click(object sender, RoutedEventArgs e)
        {
            SkladWindow skladWindow = new SkladWindow();
            skladWindow.Show();
            this.Close();
        }

        private void sumBtn_Click(object sender, RoutedEventArgs e)
        {
            int x = count + Convert.ToInt32(kolvo.Text);
            switch (Xleb.SelectedIndex)
            {
                case 0:
                    txt.Text = $"Итого с вас - {x * 10}р";
                    count = x;
                    break; 
                case 1:
                    txt.Text = $"Итого с вас - {x * 5}р";
                    count = x;
                    break;
                case 2:
                    txt.Text = $"Итого с вас - {x * 15}р";
                    count = x;
                    break;
            }
            
        }
    }
}
