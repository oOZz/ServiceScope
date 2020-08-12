using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Manager
{
    public class UserManager : IUserManager
    {
        private string _guid;
        public UserManager()
        {
            _guid = Guid.NewGuid().ToString();
        }
         
        public string GetGuid()
        {
            return _guid;
        }

        public string GetUserName(int id)
        {
            return string.Empty;
        }
    }
}
