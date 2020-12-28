using Lab5.Base;
using Lab5.Data;

namespace Lab5.ViewModels
{
    class UserViewModel : BaseViewModel
    {

        private readonly string _id;
        
        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        private string _surname;
        public string Surname
        {
            get => _surname;
            set {
                _surname = value;
                OnPropertyChanged("Surname");
            }
        }

        private string _email;
        public string Email
        {
            get => _email;
            set
            {
                _email = value;
                OnPropertyChanged("Email");
            }
        }

        public UserViewModel(UserModel user)
        {
            _id = user.Id;
            _name = user.Name;
            _surname = user.Surname;
            _email = user.Email;
        }
    }
}
