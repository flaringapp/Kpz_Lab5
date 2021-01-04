using Lab5.ViewModels;
using System.Windows;

namespace Lab5
{
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
