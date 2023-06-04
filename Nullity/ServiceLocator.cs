using System;
using System.Collections.Generic;
namespace nullity
{
    public static class ServiceLocator
    {
        private static Dictionary<Type, object> list = new Dictionary<Type, object>();
        public static void Register<T>(T services)
        {
        list[typeof(T)] = services;
        }

        public static T Get<T>()
        {
            if(list.ContainsKey(typeof(T)))
                return (T)list[typeof(T)];
            return default(T);
        }
    }
}
