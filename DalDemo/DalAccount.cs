using ModelDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalDemo
{
    public interface IDalAccount
    {
        public bool ValidateUser(User user);
    }

    public class DalAccount : IDalAccount
    {
        public bool ValidateUser(User user)
        {
            if (user.UserName == "Demo" && user.Password == "Demo")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
