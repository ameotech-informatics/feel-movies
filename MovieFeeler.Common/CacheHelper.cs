using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;

namespace MovieFeeler.Common
{
    public class CacheHelper
    {
        private MemoryCache _memCache = MemoryCache.Default;
        private CacheItemPolicy _cachePolicy = null;
        
        public CacheHelper(CacheItemPolicy cachePolicy)
        {
            _cachePolicy = cachePolicy;
        }
        /// <summary>
        /// Get object from cache
        /// </summary>
        /// <param name="cacheName"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Object Get(string key)
        {
            return _memCache.Get(key);
        }

        /// <summary>
        /// Add object to cache
        /// </summary>
        /// <param name="cacheName"></param>
        /// <param name="key"></param>
        /// <param name="o"></param>
        public void Add(string key, Object o)
        {
            _memCache.Add(new CacheItem(key, o), _cachePolicy);
        }

        public void Add(CacheItem item)
        {
            _memCache.Add(item, _cachePolicy);
        }


        /// <summary>
        /// Reset cache
        /// </summary>
        /// <param name="cacheName"></param>
        public void Reset()
        {
            List<string> cacheKeys = MemoryCache.Default.Select(kvp => kvp.Key).ToList();
            foreach (string cacheKey in cacheKeys)
            {
                MemoryCache.Default.Remove(cacheKey);
            }
        }
    }
}
