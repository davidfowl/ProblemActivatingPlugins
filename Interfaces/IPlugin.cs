﻿namespace SimpleAssemblyLoadTestCase.Interfaces
{
    public interface IPlugin
    {
        public string Name { get; }
        public string Description { get; }

        public void Initialise();
    }
}
