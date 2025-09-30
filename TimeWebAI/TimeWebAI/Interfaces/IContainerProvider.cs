using Autofac;

namespace TimeWebAI.Interfaces
{
    internal interface IContainerProvider
    {
        IContainer Container { get; }
    }
}
