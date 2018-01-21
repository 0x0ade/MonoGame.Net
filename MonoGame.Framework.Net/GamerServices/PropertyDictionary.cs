using System;
using System.Collections;
using System.Collections.Generic;

namespace Microsoft.Xna.Framework.GamerServices
{
    public class PropertyDictionary : IDictionary<string, object>, ICollection<KeyValuePair<string, object>>, IEnumerable<KeyValuePair<string, object>>, IEnumerable {
        private Dictionary<string,object> PropDictionary;

        public PropertyDictionary()
            : this(new Dictionary<string, object>()) {
        }
        public PropertyDictionary(Dictionary<string, object> inner) {
            PropDictionary = inner;
        }


        public ICollection<string> Keys {
            get {
                return ((IDictionary<string, object>) PropDictionary).Keys;
            }
        }

        public ICollection<object> Values {
            get {
                return ((IDictionary<string, object>) PropDictionary).Values;
            }
        }

        public int Count {
            get {
                return ((IDictionary<string, object>) PropDictionary).Count;
            }
        }

        public bool IsReadOnly {
            get {
                return ((IDictionary<string, object>) PropDictionary).IsReadOnly;
            }
        }

        public object this[string key] {
            get {
                return ((IDictionary<string, object>) PropDictionary)[key];
            }

            set {
                ((IDictionary<string, object>) PropDictionary)[key] = value;
            }
        }

        public int GetValueInt32 (string aKey)
        {
            return (int)PropDictionary[aKey];
        }

        public DateTime GetValueDateTime (string aKey)
        {
            return (DateTime)PropDictionary[aKey];
        }

        public void SetValue(string aKey, DateTime aValue)
        {
            if(PropDictionary.ContainsKey(aKey))
            {
                PropDictionary[aKey] = aValue;
            }
            else
            {
                PropDictionary.Add(aKey,aValue);
            }
        }

        public bool ContainsKey(string key) {
            return ((IDictionary<string, object>) PropDictionary).ContainsKey(key);
        }

        public void Add(string key, object value) {
            ((IDictionary<string, object>) PropDictionary).Add(key, value);
        }

        public bool Remove(string key) {
            return ((IDictionary<string, object>) PropDictionary).Remove(key);
        }

        public bool TryGetValue(string key, out object value) {
            return ((IDictionary<string, object>) PropDictionary).TryGetValue(key, out value);
        }

        public void Add(KeyValuePair<string, object> item) {
            ((IDictionary<string, object>) PropDictionary).Add(item);
        }

        public void Clear() {
            ((IDictionary<string, object>) PropDictionary).Clear();
        }

        public bool Contains(KeyValuePair<string, object> item) {
            return ((IDictionary<string, object>) PropDictionary).Contains(item);
        }

        public void CopyTo(KeyValuePair<string, object>[] array, int arrayIndex) {
            ((IDictionary<string, object>) PropDictionary).CopyTo(array, arrayIndex);
        }

        public bool Remove(KeyValuePair<string, object> item) {
            return ((IDictionary<string, object>) PropDictionary).Remove(item);
        }

        public IEnumerator<KeyValuePair<string, object>> GetEnumerator() {
            return ((IDictionary<string, object>) PropDictionary).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return ((IDictionary<string, object>) PropDictionary).GetEnumerator();
        }
    }

}

