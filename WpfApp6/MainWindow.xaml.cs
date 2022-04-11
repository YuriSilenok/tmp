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

namespace WpfApp6
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            UpfdateDG();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (Model1Container context = new Model1Container())
            {
                context.Entity1Set.Add(new Entity1()
                {
                    Property1 = p1.Text,
                    Property2 = p2.Text
                });
                context.SaveChanges();
            }
            UpfdateDG();
        }

        public void UpfdateDG()
        {
            using (Model1Container context = new Model1Container())
            {
                dg.ItemsSource = context.Entity1Set.ToList();
            }
        }

    }
}
