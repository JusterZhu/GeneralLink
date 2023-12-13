using GeneralLink.Kernel.Builder;
using GeneralLink.Kernel.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralLink.Kernel.Netty
{
    internal class NettyClientProvider : ProviderAbstract<NettyClientProvider, BuildeParameter>
    {
        internal override NettyClientProvider GetResult()
        {
            return this;
        }

        internal override NettyClientProvider Launch()
        {
            return this;
        }

        internal override Task<NettyClientProvider> LaunchTaskAsync()
        {
            throw new NotImplementedException();
        }

        internal override NettyClientProvider SetParameter(BuildeParameter parameter)
        {
            return this;
        }
    }
}
