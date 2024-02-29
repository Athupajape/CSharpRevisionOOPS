using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRevisionOOPS
{
    public class Container
    {
        public static IServiceProvider ContainerConfig()
        {
            IServiceCollection collection = new ServiceCollection();
            collection.AddTransient<ISavingsAccount, SavingsAccount>();
            collection.AddTransient<IAccount,Account>();
            return collection.BuildServiceProvider();
        }
    }
}
