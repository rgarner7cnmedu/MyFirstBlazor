using System;

namespace MyFirstBlazor.Client.Services
{
    public class SingletonService : IDisposable
    {
        public Guid Guid { get; set; }
        public SingletonService()
          => Guid = Guid.NewGuid();
        public virtual void Dispose()
          => Console.WriteLine($"{nameof(SingletonService)} disposed.");
    }
}
