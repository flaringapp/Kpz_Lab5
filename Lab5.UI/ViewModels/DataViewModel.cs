using Lab5.Base;
using System.Collections.ObjectModel;

namespace Lab5.ViewModels
{
    class DataViewModel: BaseViewModel
    {

        private ObservableCollection<UserViewModel> _users;
        public ObservableCollection<UserViewModel> Users
        {
            get => _users;
            set
            {
                _users = value;
                OnPropertyChanged("Users");
            }
        }

    }
}
