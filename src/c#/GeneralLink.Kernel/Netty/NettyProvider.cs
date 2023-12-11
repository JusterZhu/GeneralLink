using GeneralLink.Kernel.Builder;
using GeneralLink.Kernel.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralLink.Kernel.Netty
{
    internal class NettyProvider : ProviderAbstract<NettyProvider, BuildeParameter>
    {
        internal override NettyProvider GetResult()
        {
            return this;
        }

        internal override NettyProvider Launch()
        {
            return this;
        }

        internal override Task<NettyProvider> LaunchTaskAsync()
        {
            throw new NotImplementedException();
        }

        internal override NettyProvider SetParameter(BuildeParameter parameter)
        {
            return this;
        }
    }
}
