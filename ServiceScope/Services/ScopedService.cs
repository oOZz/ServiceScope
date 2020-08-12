using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceScope.Services
{
    public interface IScopeService : IService { }

    public class ScopedService : IScopeService
    {
        private string _guid;

        public ScopedService()
        {
            _guid = Guid.NewGuid().ToString();
        }

        public string GetGuid()
        {
            return _guid;
        }
    }
}
