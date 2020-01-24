using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorUI
{
    public class CookieManager
    {
        public static CookieManager Instance { get; } = new CookieManager();

        private static int _nextId;
        private Dictionary<int, object> _cookiedObjects = new Dictionary<int, object>();
        private object _lock = new object();

        private CookieManager()
        {
        }

        public int CookieObject(object toCookie)
        {
            lock (_lock)
            {
                _nextId += 1;
                _cookiedObjects.Add(_nextId, toCookie);
                return _nextId;
            }
        }

        public void RemoveCookiedObject(object cookiedObject)
        {
            lock (_lock)
            {
                _cookiedObjects.Remove(_cookiedObjects.Where(kvp => kvp.Value == cookiedObject).First().Key);
            }
        }

        public T GetCookiedObject<T>(int cookie)
        {
            lock (_lock)
            {
                object result = default;
                if (_cookiedObjects.TryGetValue(cookie, out result))
                {
                    return (T)result;
                }
            }
            return default;
        }
    }
}
