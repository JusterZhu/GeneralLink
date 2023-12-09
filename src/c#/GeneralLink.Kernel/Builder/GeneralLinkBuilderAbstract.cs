using GeneralLink.Kernel.Provider;

namespace GeneralLink.Kernel.Builder
{
    internal abstract class GeneralLinkBuilderAbstract : IGeneralLinkBuilder
    {
        public IGeneralLinkBuilder Remove(ProviderAbstract provider)
        {
            throw new NotImplementedException();
        }

        public IGeneralLinkBuilder Use(ProviderAbstract provider)
        {
            throw new NotImplementedException();
        }

        public IGeneralLinkBuilder UseIf(ProviderAbstract provider)
        {
            throw new NotImplementedException();
        }
    }
}
