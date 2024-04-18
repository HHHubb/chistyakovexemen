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
    /// Логика взаимодействия для SkladWindow.xaml
    /// </summary>
    public partial class SkladWindow : Window
    {
        public SkladWindow()
        {
            InitializeComponent();
        }

        private void Sklad_Click(object sender, RoutedEventArgs e)
        {
            SkladWindow skladWindow = new SkladWindow();    
            skladWindow.Show();
            this.Close();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
