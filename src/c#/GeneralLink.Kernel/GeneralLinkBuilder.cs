using GeneralLink.Kernel.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralLink.Kernel
{
    internal class GeneralLinkBuilder : GeneralLinkBuilderAbstract
    {
        internal GeneralLinkBuilder() { }

        internal GeneralLinkBuilder(BuildeParameter parameter) 
        {

        }

        internal GeneralLinkBuilder Builder() { return this; }
    }
}
