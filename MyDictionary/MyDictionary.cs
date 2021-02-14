using System;
namespace MyDictionary
{
    public class MyDictionary<T1,T2>
    {
        T1[] _keys;
        T2[] _values;
        

        public MyDictionary()
        {
            _keys = new T1[0];
            _values = new T2[0];
        }

        public void Add(T1 key, T2 value)
        {
            T1[] _keysTemp = _keys;
            _keys = new T1[_keys.Length + 1];

            for (int i = 0; i < _keysTemp.Length - 1; i++)
            {
                _keys[i] = _keysTemp[i];
            }
            _keys[_keys.Length - 1] = key;

            T2[] _valuesTemp = _values;
            _values = new T2[_values.Length + 1];

            for (int i = 0; i < _valuesTemp.Length - 1; i++)
            {
                _values[i] = _valuesTemp[i];
            }
            _values[_values.Length - 1] = value;
        }

        
    }
}
