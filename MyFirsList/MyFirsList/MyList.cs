using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;


namespace MyFirsList
{
    class MyList<T> : IList<T>
    {
        T[] _array;
        int _size;
        int _capasity;

        public MyList()
        {
            _array = new T[0];
            _size = 0;
            _capasity = 0;
        }

        public MyList(int capasity)
        {
            _array = new T[capasity];
            _size = 0;
            _capasity = capasity;
        }

        public MyList(T[]collection)
        {
            _array = new T[collection.Length];
            _size = collection.Length;
            _capasity = collection.Length;
            for (int i = 0; i<collection.Length;i++)
            {
                _array[i] = collection[i];
            }
            
        }

        public int Count => _size;
        public int Capasity => _capasity;

        public T this[int index] 
        { 
            get
            {
                if (index < 0 || index >= _size)
                    throw new IndexOutOfRangeException("Индекс выходит за границы массива!");
                return _array[index];
            }
            set
            {
                if (index < 0 || index >= _size)
                    throw new IndexOutOfRangeException("Индекс выходит за границы массива!");
                _array[index] = value;
            }

        }
      
        public bool IsReadOnly => false;

        public void Add(T item)
        {
            if(_size < _capasity)
            {
                _array[_size] = item;
                _size++;
            }
            else
            {
               
                T[] tmp = new T[(int)(_capasity*1.33+1)];

                for(int i = 0; i < _size;i++)
                {
                    tmp[i] = _array[i];
                }
                tmp[_size] = item;
                _size++;
                _array = tmp;
                _capasity = tmp.Length;
            }
        }

        public void Clear()
        {
            _size = 0;
        }

        public bool Contains(T item) => IndexOf(item) >= 0;
        

        public void CopyTo(T[]_array, int arrayIndex)
        {
            T[] mas = new T[0];
            int index = 0;
            mas = _array;
            for(int i = arrayIndex; i<_size;i++)
            {
                mas[i] = _array[index];
                index++;
            }
            _array = mas;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return (_array.GetEnumerator()as IEnumerator<T>);
        }

        public int IndexOf(T item)
        {
            int pos = -1;

            for(int i = 0; i <_size; i++)
            {
                if(_array[i].Equals(item))
                {
                    pos = i;
                    break;
                }
            }
            return pos;
        }
        public int LastIndexOf(T item)
        {
            int pos = -1;

            for (int i = _size-1; i >=0; i--)
            {
                if (_array[i].Equals(item))
                {
                    pos = i;
                    break;
                }
            }
            return pos;
        }

        public void Insert(int index, T item)
        {
            T[] mas = new T[_size + 1];
            mas[index] = item;


            if (_size <_capasity)
            {
                for(int i = 0; i <_size ; i++)
                {                  
                    if (i >= index)
                    {
                        mas[i+1] = _array[i];
                    }
                    else
                    {
                        mas[i] = _array[i];
                    }
                    
                }
                _array = mas;
            }
            else
            {
                T[] tmp = new T[_capasity + 1];

                for (int i = 0; i <= _size; i++)
                {
                    tmp[i] = _array[i];
                }
                tmp[_size] = item;
                _size++;
                _array = tmp;
                _capasity = tmp.Length;
            }
        }

        public bool Remove(T item)
        {
            for (int i = 0; i < _size; i++)
            {
                if (_array[i].Equals(item))
                {
                    for (int j = i; j < Count - 1; j++)
                    {
                        _array[j] = _array[j + 1];
                    }
                    _size--;
                    return true;
                }
            }
            return false; ;


        }

        public void RemoveAt(int index)
        {
            for(int i = 0; i<_size;i++)
            {
                if(i >= index)
                {
                    _array[i] = _array[i + 1];
                };
            }
        }

        public void RemovingNElementsFromEnd(int item)
        {
            

            for (int i = _size ; i<_size-item; i--)
            {
                _array[i] = _array[i - 1];
                _size--;
            }
        }
                                                   
        public void RemovingNElementsFromFirst(int item)       
        {                         
            for (int i = 0; i < item; i++)
            {
               for(int j = 0; j<_size;j++)
               {
                    _array[j] = _array[j + 1];
               }
                _size--;
            }
        }

        public void ChangeByIndex(int index, T item)
        {
            _array[index] = item;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _array.GetEnumerator();
        }

       

    }
}
