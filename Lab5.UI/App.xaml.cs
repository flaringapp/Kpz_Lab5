using Lab5.Data;
using Lab5.Data.Mock;
using System.Windows;

namespace Lab5
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private DataModel _data;

        public App()
        {
            _data = DataModel.Load();
            if (_data.Users.Count == 0)
            {
                _data = DataMock.Mock();
                _data.Save();
            }
            var window = new MainWindow { DataContext = _data  };
            window.Show();
        }

        protected override void OnExit(ExitEventArgs args)
        {
            try
            {
                _data.Save();
            } finally
            {
                base.OnExit(args);
            }
        }
    }
}
