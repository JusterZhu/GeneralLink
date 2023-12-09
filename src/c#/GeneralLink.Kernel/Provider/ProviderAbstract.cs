namespace GeneralLink.Kernel.Provider
{
    internal abstract class ProviderAbstract : IProvider
    {
        ProviderAbstract IProvider.GetResult()
        {
            throw new NotImplementedException();
        }

        ProviderAbstract IProvider.Launch()
        {
            throw new NotImplementedException();
        }

        Task<ProviderAbstract> IProvider.LaunchTaskAsync()
        {
            throw new NotImplementedException();
        }

        ProviderAbstract IProvider.SetParameter<T>(T parameter)
        {
            throw new NotImplementedException();
        }
    }
}
