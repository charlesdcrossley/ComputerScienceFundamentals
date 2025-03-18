using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    public class JaggedArray<T>
    {
        private T[][] _array;
        private int _size;
        public JaggedArray(int size)
        {
            _size = size;
            _array = new T[size][];            
        }
        public T[][] GetArray()
        {
            return _array;
        }
        public T[] GetArray(int index)
        {
            return _array[index];
        }
        public T[][] AddArray(int index, T[] array)
        {
            _array[index] = array;
            return _array;
        }
        public T[][] AddArray(T[][] arrays)
        {
            for (int i = 0; i < arrays.Length; i++)
            {
                if (arrays[i] == null)
                {
                    _array[i] = null;
                    continue;
                }
                for (int j = 0; j < arrays[i].Length; j++)
                {
                    if (_array[i] == null)
                        _array[i] = new T[arrays[i].Length];

                    _array[i][j] = arrays[i][j];                    
                }
            }
                
            return _array;
        }

        public T GetValue(int indexA, int indexB)
        {
            return _array[indexA][indexB];
        }

        public int[] Find(T value)
        {
            for(int i=0; i< _array.Length; i++)
            {
                for(int j =0; j < _array[i].Length; j++)
                {
                    if (_array[i][j].Equals(value))
                        return [i,j];
                }
            }
            return [-1, -1];
        }        
    }
}
