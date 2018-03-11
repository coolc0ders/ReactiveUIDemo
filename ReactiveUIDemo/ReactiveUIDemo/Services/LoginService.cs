using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ReactiveUIDemo.Services
{
    class LoginService : ILogin
    {
        Dictionary<string, string> _userCredentials;

        public LoginService()
        {
            _userCredentials = new Dictionary<string, string>();
            _userCredentials.Add("us@sad.com", "aaaaaaaa");
            _userCredentials.Add("user2@sad.com", "Userabc123");
            _userCredentials.Add("user3@sad.com", "!A@3534");
        }

        public async Task<bool> Login(string username, string password)
        {
            if(_userCredentials.ContainsKey(username))
            {
                return _userCredentials[username] == password;
            }

            return false;
        }
    }
}
