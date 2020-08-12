using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Manager
{
    public class BaseManager : IBaseManager
    {
        public string GetGuid()
        {
            return Guid.NewGuid().ToString();
        }


    }
}
