using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralLink.Kernel.Provider
{
    internal interface IProvider
    {
        internal ProviderAbstract SetParameter<T>(T parameter);
        internal ProviderAbstract Launch();
        internal Task<ProviderAbstract> LaunchTaskAsync();
        internal ProviderAbstract GetResult();
    }
}
