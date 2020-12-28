using Lab5.Data;
using Lab5.Data.Mock;
using Lab5.ViewModels;
using System.Windows;

namespace Lab5
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            var viewModel = new UsersViewModel();
            var window = new MainWindow { DataContext = viewModel };
            window.Show();
        }
    }
}
