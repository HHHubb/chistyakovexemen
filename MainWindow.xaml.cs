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

namespace chistyakovexemen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void PressBtn_Click(object sender, RoutedEventArgs e)
        {
            sum.Text = $"Ваше кол-во хлеба: {Convert.ToInt32(Weight.Text) * Convert.ToInt32(Price.Text)}";
        }

        private void Order_Click(object sender, RoutedEventArgs e)
        {
            OrderWindow orderWindow = new OrderWindow();
            orderWindow.Show();
            this.Close();
        }

        private void Sklad_Click(object sender, RoutedEventArgs e)
        {
            SkladWindow skladWindow = new SkladWindow();
            skladWindow.Show();
            this.Close();
        }
    }
}
