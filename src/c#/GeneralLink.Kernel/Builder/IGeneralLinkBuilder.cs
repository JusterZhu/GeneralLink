using GeneralLink.Kernel.Provider;
namespace GeneralLink.Kernel.Builder
{
    internal interface IGeneralLinkBuilder
    {
        IGeneralLinkBuilder Use(ProviderAbstract provider);

        IGeneralLinkBuilder UseIf(ProviderAbstract provider);

        IGeneralLinkBuilder Remove(ProviderAbstract provider);
    }
}
