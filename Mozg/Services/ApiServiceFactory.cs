using Microsoft.Extensions.DependencyInjection;
using Mozg.DB.Enums;
using Mozg.Interfaces;
using Mozg.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;

namespace Mozg.Services
{
    internal class ApiServiceFactory : IApiServiceFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public ApiServiceFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public IApi GetApiService(Platform platform)
        {
            return platform switch
            {
                Platform.Stepik => _serviceProvider.GetRequiredService<StepikService>(),
                Platform.LeedCode => _serviceProvider.GetRequiredService<LeetCodeService>(),
                _ => throw new ArgumentException("Unknown API type")
            };
        }
    }
}
