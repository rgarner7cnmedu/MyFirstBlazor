﻿using System;

namespace MyFirstBlazor.Client.Services
{
    public class TransientService : IDisposable
    {
        public Guid Guid { get; set; }
        public TransientService()
        {
            Guid = Guid.NewGuid();
        }
        public virtual void Dispose()
        {
            Console.WriteLine($"{nameof(TransientService)} disposed.");
        }
    }
}
