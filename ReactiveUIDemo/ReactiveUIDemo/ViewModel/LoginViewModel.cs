using ReactiveUI;
using ReactiveUIDemo.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReactiveUIDemo.ViewModel
{
    public class LoginViewModel : ViewModelBase
    {
        ILogin _loginService;

        private string _userName;
        public string UserName
        {
            get => _userName;
            //Notify when property user name changes
            set => this.RaiseAndSetIfChanged(ref _userName, value);
        }

        private string _password;
        public string Password
        {
            get => _password;
            set => this.RaiseAndSetIfChanged(ref _password, value);
        }

        public ReactiveCommand LoginCommand { get; private set; }

        public LoginViewModel(IScreen hostScreen = null) : base(hostScreen)
        {
            _loginService = new LoginService();
            LoginCommand = ReactiveCommand.CreateFromTask(async () =>
            {
            });
        }
    }
}
