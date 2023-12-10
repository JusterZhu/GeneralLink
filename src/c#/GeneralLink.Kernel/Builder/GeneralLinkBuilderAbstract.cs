using GeneralLink.Kernel.Provider;

namespace GeneralLink.Kernel.Builder
{
    internal abstract class GeneralLinkBuilderAbstract : IGeneralLinkBuilder
    {
        public IGeneralLinkBuilder Remove(IProvider provider)
        {
            throw new NotImplementedException();
        }

        public IGeneralLinkBuilder Use(IProvider provider)
        {
            throw new NotImplementedException();
        }

        public IGeneralLinkBuilder UseIf(IProvider provider)
        {
            throw new NotImplementedException();
        }
    }
}
