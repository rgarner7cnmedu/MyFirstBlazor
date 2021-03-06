﻿using System;

namespace MyFirstBlazor.Client.Services
{
    public class ScopedService : IDisposable
    {
        public Guid Guid { get; set; }
        public ScopedService()
        {
            Guid = Guid.NewGuid();
        }
        public virtual void Dispose()
        {
            Console.WriteLine($"{nameof(ScopedService)} disposed.");
        }
    }
}