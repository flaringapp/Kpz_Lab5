using System.ComponentModel;
using System.Windows;

namespace Lab5.Base
{
    class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private SimpleCommand _onClosing;
        public SimpleCommand OnClosing
        {
            get => _onClosing ?? (_onClosing = new SimpleCommand(o =>
            {
                Release();
                if (o is Window)
                {
                    CloseWindow((Window)o);
                }
            }));
        }

        protected virtual void Release() { }

        protected virtual void CloseWindow(Window window) { }
    }
}
