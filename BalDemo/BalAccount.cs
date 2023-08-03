using DalDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalDemo
{
    public class BalAccount
    {
        private readonly IDalAccount _dalAccount;
        public BalAccount()
        {
            _dalAccount = new DalAccount();
        }
        public bool ValidateUser(string username, string password)
        {
            return _dalAccount.ValidateUser(new ModelDemo.User
            {
                UserName = username,
                Password = password
            });
            
        }
    }
}
