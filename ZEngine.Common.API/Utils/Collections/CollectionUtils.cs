using System;
using System.Collections.Generic;

namespace ZEngine.Common.Utils.Collections
{
    public static class CollectionUtils
    {
        /// <summary>
        /// Checks if the <see cref="IDictionary{K, V}"/> contains an element for the given key. 
        /// If not a new value is computed, added and returned.
        /// </summary>
        /// <param name="supplier">Supplies a value based on a key</param>
        public static V PutIfAbsent<K,V>(this IDictionary<K,V> dict, K key, Func<K,V> supplier)
        {
            if (!dict.TryGetValue(key, out V currentValue))
            {
                currentValue = supplier.Invoke(key);
                dict.Add(key, currentValue);
            }

            return currentValue;
        }
    }
}
