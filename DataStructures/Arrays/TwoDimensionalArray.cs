using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    public class TwoDimensionalArray<T>
    {
        private readonly T[,] _array;
        private readonly int _size;
        private readonly int _rowSize;
        private readonly int _columnSize;
        public TwoDimensionalArray(int numRows, int numColumns)
        {
            _array = new T[numRows,numColumns];
            _rowSize = numRows;
            _columnSize = numColumns;
        }

        public T[,] GetArray()
        {
            return _array;
        }
        public T[,] PopulateArray(List<List<T>> inputData)
        {
            // N^2 Complexity
            for(int i =0; i < inputData.Count; i++)
            {
                for(int j = 0; j < inputData[i].Count; j++)
                {
                    _array[i,j] = inputData[i][j];
                }
            }
            return _array;
        }
        public int GetSize()
        {
            return _array.Length;
        }
        public int GetRowSize()
        {
            return _rowSize;
        }
        public int GetColumnSize()
        {
            return _columnSize;
        }

        public T GetValue(int row, int column)
        {
            return _array[row, column];
        }

        public int[] Find(T value)
        { 
            for(int i = 0; i< _rowSize; i++)
            {
                for(int j = 0; j<_columnSize; j++)
                {                    
                        if (_array[i, j].Equals(value))
                            return [i, j];
                }
            }
            return [-1, -1];
        }
    }
}
