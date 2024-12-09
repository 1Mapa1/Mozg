using Mozg.Models;

namespace Mozg.Interfaces
{
    internal interface IApi
    {
        public Information GetUserInfo();

        public bool HasUserExict();

        public int GetCountResolveTask();
    }
}
