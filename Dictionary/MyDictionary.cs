using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Dictionary
{
    public class MyDictionary<TKey, TValue>
    {
        TKey[] keys;
        TValue[] values;

        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];

        }
        public void Add(TKey key, TValue value)
        {
            TKey[] _tempKeys = keys;
            TValue[] _tempValue = values;

            keys = new TKey[_tempKeys.Length + 1];
            values = new TValue[_tempValue.Length + 1];

            for (int i = 0; i < _tempKeys.Length; i++)
            {
                keys[i] = _tempKeys[i];
                values[i] = _tempValue[i];
            }


            bool containsKey = keys.Contains(key);
            if (containsKey)
            {
                string msg = key + " nolu key eklenemez. Zaten tanımlı!";
                Exception ex = new Exception(msg);
                throw ex;
            }
            else
            {
                keys[keys.Length - 1] = key;
                values[values.Length - 1] = value;
            }
            Console.WriteLine("{0}, {1}", key, value);
        }

    }

}

