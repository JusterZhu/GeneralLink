namespace GeneralLink.Kernel.Provider
{
    internal abstract class ProviderAbstract<TProvider, TParameter> : IProvider
    {
        internal abstract TProvider SetParameter(TParameter parameter);

        internal abstract TProvider Launch();

        internal abstract Task<TProvider> LaunchTaskAsync();

        internal abstract TProvider GetResult();
    }
}