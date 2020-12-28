using Lab5.Base;

namespace Lab5.ViewModels
{
    class InputViewModel: BaseViewModel
    {
        public InputViewModel(string initialInput = "")
        {
            _input = initialInput;
        }

        private string _input = "";
        public string Input
        {
            get => _input;
            set
            {
                _input = value;
                OnPropertyChanged("Input");
            }
        }
    }
}
