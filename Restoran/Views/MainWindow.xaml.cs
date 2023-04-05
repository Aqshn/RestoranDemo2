using Restoran.Commands;
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

namespace Restoran.Views
{
    /// <summary>
    /// Interaction logic for View.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }
        public ICommand ShowCommand { get; set; }


        public void Click(object sender, RoutedEventArgs e)
        {
            ShowCommand = new RelayCommand(ExecuteShowCommand1, CanExecuteShowCommand1);
        }

        void ExecuteShowCommand1(object? parametr)
        {
            
        }
        bool CanExecuteShowCommand1(object? parametr)
            => btn1.Background == new SolidColorBrush(Colors.Green);
    }

}
