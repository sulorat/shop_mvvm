using ReactiveUI;

namespace shop_mvvm.ViewModels
{
    public class RegViewModel : ViewModelBase
    {
        private string _nameController="";
        private string _passController = "";

        public string PassController
        {
            get => _passController;
            set=>this.RaiseAndSetIfChanged(ref _passController, value);
        }

        public string NameController
        {
            get => _nameController;
            set => this.RaiseAndSetIfChanged(ref _nameController, value);
        }
    }
}
