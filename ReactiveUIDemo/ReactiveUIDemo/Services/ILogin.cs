using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ReactiveUIDemo.Services
{
    public interface ILogin
    {
        Task<bool> Login(string username, string password);
    }
}
