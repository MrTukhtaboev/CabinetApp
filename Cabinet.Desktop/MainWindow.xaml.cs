using Cabinet.Desktop.ServiceLayer.Person.Concrete;
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

namespace Cabinet.Desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            personService = new PersonService();
        }
        private readonly PersonService personService;
        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            (await personService.GetAllAsync()).ToList().ForEach(async item =>
            {
                await Task.Run(() =>
                {
                    this.Dispatcher.Invoke(() =>
                    {
                        btnList.Children.Add(new Button()
                        {
                            Content = item.FirstName
                        });
                    });
                    
                });
                
            });
        }
    }
}