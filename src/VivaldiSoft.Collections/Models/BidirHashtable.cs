using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace VivaldiSoft.Collections
{
    /// <summary>
    /// Represents a collection of key/value pairs that are organized based on both hash code.
    /// </summary>
    public class BidirHashtable
    {
        private Hashtable _htFwd = new Hashtable();
        private Hashtable _htBkwd = new Hashtable();

        static readonly object _locker = new object();


        /// <summary>
        /// Adds an element with the specified key and value into the BidirHashtable.
        /// </summary>
        /// <param name="key">The key of the element to add.</param>
        /// <param name="val">The value of the element to add.</param>
        /// <example>
        /// <code lang="csharp">
        /// var bidirHashtable = new BidirHashtable();
        /// bidirHashtable.Add("key", "value");
        /// </code>
        /// </example>
        public void Add(object key, object val)
        {
            lock (_locker)
            {
                _htFwd.Add(key, val);
                _htBkwd.Add(val, key);
            }
        }

        /// <summary>
        /// Removes all elements from the BidirHashtable.
        /// </summary>
        /// <example>
        /// <code lang="csharp">
        /// var bidirHashtable = new BidirHashtable();
        /// bidirHashtable.Add("key", "value");
        /// bidirHashtable.Clear();
        /// </code>
        /// </example>
        public void Clear()
        {
            lock (_locker)
            {
                _htFwd.Clear();
                _htBkwd.Clear();
            }
        }

        /// <summary>
        /// Determines whether the BidirHashtable contains a specific key.
        /// </summary>
        /// <param name="key">The key to locate in the BidirHashtable.</param>
        /// <returns>True if the BidirHashtable contains an element with the specified key; otherwise, false.</returns>
        /// <example>
        /// <code lang="csharp">
        /// var bidirHashtable = new BidirHashtable();
        /// bidirHashtable.Add("key", "value");
        /// var result = bidirHashtable.Contains("key");
        /// 
        /// /*
        /// result is true
        /// */
        /// </code>
        /// </example>
        public bool Contains(object key)
        {
            lock (_locker)
            {
                return _htFwd.Contains(key);
            }
        }

        /// <summary>
        /// Determines whether the BidirHashtable contains a specific value.
        /// </summary>
        /// <param name="val">The value to locate in the BidirHashtable.</param>
        /// <returns>True if the BidirHashtable contains an element with the specified value; otherwise, false.</returns>
        /// <example>
        /// <code lang="csharp">
        /// var bidirHashtable = new BidirHashtable();
        /// bidirHashtable.Add("key", "value");
        /// var result = bidirHashtable.ContainsValue("value");
        /// 
        /// /*
        /// result is true
        /// */
        /// </code>
        /// </example>
        public bool ContainsValue(object val)
        {
            lock (_locker)
            {
                return _htBkwd.Contains(val);
            }
        }

        /// <summary>
        /// Gets the number of key/value pairs contained in the BidirHashtable.
        /// </summary>
        /// <returns>The number of key/value pairs contained in the BidirHashtable.</returns>
        /// <example>
        /// <code lang="csharp">
        /// var bidirHashtable = new BidirHashtable();
        /// bidirHashtable.Add("key", "value");
        /// bidirHashtable.Add("key2", "value2");
        /// var result = bidirHashtable.Count();
        /// 
        /// /*
        /// result is 2
        /// */
        /// </code>
        /// </example>
        public int Count()
        {
            lock (_locker)
            {
                return _htFwd.Count;
            }
        }

        /// <summary>
        /// Gets the value associated with the specified key.
        /// </summary>
        /// <param name="key">The key whose value to get.</param>
        /// <returns>The value associated with the specified key.</returns>
        /// <example>
        /// <code lang="csharp">
        /// var bidirHashtable = new BidirHashtable();
        /// bidirHashtable.Add("key", "value");
        /// var result = bidirHashtable.Get("key");
        /// 
        /// /*
        /// result is "value"
        /// */
        /// </code>
        /// </example>
        public dynamic Get(object key)
        {
            lock (_locker)
            {
                return _htFwd[key];
            }
        }

        /// <summary>
        /// Gets the key associated with the specified value.
        /// </summary>
        /// <param name="val">The value whose key to get.</param>
        /// <returns>The key associated with the specified value.</returns>
        /// <example>
        /// <code lang="csharp">
        /// var bidirHashtable = new BidirHashtable();
        /// bidirHashtable.Add("key", "value");
        /// var result = bidirHashtable.GetKey("value");
        /// 
        /// /*
        /// result is "key"
        /// */
        /// </code>
        /// </example>
        public dynamic GetKey(object val)
        {
            lock (_locker)
            {
                return _htBkwd[val];
            }
        }

        /// <summary>
        /// Sets the value associated with the specified key.
        /// </summary>
        /// <param name="key">The key whose value to set.</param>
        /// <param name="val">The value of the element to set.</param>
        /// <example>
        /// <code lang="csharp">
        /// var bidirHashtable = new BidirHashtable();
        /// bidirHashtable.Add("key", "value");
        /// bidirHashtable.Set("key", "foo");
        /// var result = bidirHashtable.Get("key");
        /// 
        /// /*
        /// result is "foo"
        /// */
        /// </code>
        /// </example>
        public void Set(object key, object val)
        {
            lock (_locker)
            {
                _htFwd[key] = val;
                _htBkwd[val] = key;
            }
        }

        /// <summary>
        /// Removes the element with the specified key from the BidirHashtable.
        /// </summary>
        /// <param name="key">The key of the element to remove.</param>
        /// <example>
        /// <code lang="csharp">
        /// var bidirHashtable = new BidirHashtable();
        /// bidirHashtable.Add("key", "value");
        /// bidirHashtable.Remove("key");
        /// </code>
        /// </example>
        public void Remove(object key)
        {
            lock (_locker)
            {
                object val = _htFwd[key];
                _htFwd.Remove(key);
                _htBkwd.Remove(val);
            }
        }

        /// <summary>
        /// Removes the element with the specified value from the BidirHashtable.
        /// </summary>
        /// <param name="val">The value of the element to remove.</param>
        /// <example>
        /// <code lang="csharp">
        /// var bidirHashtable = new BidirHashtable();
        /// bidirHashtable.Add("key", "value");
        /// bidirHashtable.RemoveValue("value");
        /// </code>
        /// </example>
        public void RemoveValue(object val)
        {
            lock (_locker)
            {
                object key = _htBkwd[val];
                _htFwd.Remove(key);
                _htBkwd.Remove(val);
            }
        }
    }
}
