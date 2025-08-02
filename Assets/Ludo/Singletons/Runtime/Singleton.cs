using System;

namespace Ludo.Singletons
{
    /// <summary>
    /// Thread-safe singleton base class for POCO objects
    /// </summary>
    public abstract class Singleton<T> where T : class, new()
    {
        private static readonly Lazy<T> _instance = new(() => 
        {
            var instance = new T();
            if (instance is Singleton<T> singleton)
                singleton.Initialize();
            return instance;
        });
        
        public static T Instance => _instance.Value;
        
        protected Singleton() { }
        
        /// <summary>
        /// Called once when the singleton instance is created
        /// </summary>
        protected virtual void Initialize() { }
    }
}