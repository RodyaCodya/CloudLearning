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

using CloudLearning.ServiceReference1;

namespace CloudLearning
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_test_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var x = new MyServiceClient();

                lbl_result.Content = x.CanEnter(new InputClass { x = double.Parse(tb_a.Text), y = double.Parse(tb_b.Text) });
            }
            catch { }
        }
    }
}
