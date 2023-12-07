using GeneralLink.Kernel.Provider;
namespace GeneralLink.Kernel.Builder
{
    internal interface IGeneralLinkBuilder
    {
        IGeneralLinkBuilder Use(IProvider provider);

        IGeneralLinkBuilder UseIf(IProvider provider);

        IGeneralLinkBuilder Remove(IProvider provider);
    }
}
