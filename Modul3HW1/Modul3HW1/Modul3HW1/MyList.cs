using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3HW1
{
    public class MyList<T> : IReadOnlyCollection<T>
    {
        private int _capacity = 4;
        private int _counter = 0;
        private T[] _arr;

        public MyList()
        {
            _arr = new T[_capacity];
        }

        public int Count => _counter;

        public void Add(T value)
        {
            if (_arr.Length == _counter)
            {
                _capacity *= 2;
                Array.Resize(ref _arr, _capacity);
            }

            _arr[_counter++] = value;
        }

        public void AddRange(IEnumerable<T> range)
        {
            foreach (var item in range)
            {
                Add(item);
            }
        }

        public bool Remove(T item)
        {
            for (var index = 0; index < _arr.Length; index++)
            {
                if (_arr[index].Equals(item))
                {
                    RemoveAt(index);
                    return true;
                }
            }

            return false;
        }

        public void RemoveAt(int index)
        {
            _arr[index] = default(T);
            _counter--;
        }

        public void RemoveEmptiness()
        {
            var newList = new T[Count];
            var countForEmpty = 0;
            for (var i = 0; i < _arr.Length; i++)
            {
                if (!_arr[i].Equals(default(T)))
                {
                    newList[countForEmpty++] = _arr[i];
                }
            }

            _arr = newList;
        }

        public void Sort()
        {
            Array.Sort(_arr);
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            for (var i = 0; i < _counter; i++)
            {
                yield return _arr[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (var i = 0; i < _counter; i++)
            {
                yield return _arr[i];
            }
        }
    }
}
