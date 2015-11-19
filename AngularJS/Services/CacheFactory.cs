using System;

namespace Bridge.AngularJS.Services
{
    /// <summary>
    /// A cache object used to store and retrieve data, primarily used by $http
    /// and the 'script' directive to cache templates and other data.
    /// </summary>
    [External]
    public class Cache
    {
        /// <summary>
        /// Inserts a named entry into the Cache object to be retrieved later,
        /// and incrementing the size of the cache if the key was not already
        /// present in the cache. If behaving like an LRU cache, it will also
        /// remove stale entries from the set.
        /// It will not insert undefined values into the cache.
        /// </summary>
        /// <param name="key">
        /// The key under which the cached data is stored.
        /// </param>
        /// <param name="value">
        /// The value to store alongside the key. If it is undefined, the key
        /// will not be stored.
        /// </param>
        public void Put(string key, object value)
        {
            return;
        }

        /// <summary>
        /// Retrieves named data stored in the Cache object.
        /// </summary>
        /// <param name="key">The key of the data to be retrieved.</param>
        public object Get(string key)
        {
            return default(object);
        }

        /// <summary>
        /// Removes an entry from the Cache object.
        /// </summary>
        /// <param name="key">The key of the entry to be removed.</param>
        public void Remove(string key)
        {
            return;
        }

        /// <summary>
        /// Clears the cache object of any entries.
        /// </summary>
        public void RemoveAll()
        {
            return;
        }

        /// <summary>
        /// Destroys the Cache object entirely, removing it from the
        /// $cacheFactory set.
        /// </summary>
        public void Destroy()
        {
            return;
        }

        /// <summary>
        /// Retrieve information regarding a particular Cache.
        /// </summary>
        public CacheInfo Info()
        {
            return default(CacheInfo);
        }

    }

    /// <summary>
    /// Cache info.
    /// </summary>
    [External]
    public class CacheInfo
    {
        /// <summary>
        /// The ID of the cache instance.
        /// </summary>
        public int CacheId;

        /// <summary>
        /// The number of entries kept in the cache instance.
        /// </summary>
        public int Size;

        /// <summary>
        /// Any additional properties from options object when creating the
        /// cache.
        /// </summary>
        public object AdditionalProperties;
    }
}

