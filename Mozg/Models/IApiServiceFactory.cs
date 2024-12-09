using Mozg.DB.Enums;
using Mozg.Interfaces;

namespace Mozg.Models
{
    internal interface IApiServiceFactory
    {
        IApi GetApiService(Platform platform);
    }
}
