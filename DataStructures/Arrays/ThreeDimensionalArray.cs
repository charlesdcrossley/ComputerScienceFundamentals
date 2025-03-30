using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    public class ThreeDimensionalArray<T>
    {
        private T[,,] _array;
        private int _length;
        private int _width;
        private int _height;
        public ThreeDimensionalArray(int length, int width, int height)
        {
            int[][] array = new int[5][];
            array[0] = [1, 2, 3, 4];
            array[1] = [1, 2, 3];
            array[2] = [1, 2];
            array[3] = [1, 2, 3];
            array[4] = [1, 2];
            array[5] = [1];

            _array = new T[length, width, height];
            _length = length;
            _width = width;
            _height = height;
        }
        public T[,,] GetArray()
        {
            return _array;
        }
        public int GetLength()
        {
            return _length;
        }
        public int GetHeight()
        {
            return _height;
        }
        public int GetWidth()
        {
            return _width;
        }
        public T[,,] PopulateArray(List<List<List<T>>> inputData)
        {
            for(int i = 0; i < inputData.Count; i++)
            {
                for(int j = 0; j < inputData[i].Count; j++)
                {
                    for(int k = 0; k < inputData[i][j].Count; k++)
                    {
                        _array[i,j,k] = inputData[i][j][k]; 
                    }
                }
            }
            return _array;
        }

        // N^3 Cubic Complexity - How can I reduce ?
        public int[] Find<T>(T value)
        {
            for (int i = 0; i < _length; i++)
            {
                for (int j = 0; j < _width; j++)
                {
                    for(int k = 0; k< _height; k++)
                    {
                        if (_array[i, j, k].Equals(value))
                            return [i,j,k];
                    }
                }
            }
            return [ -1,-1];
        }
        public T GetValue(int length, int width, int height)
        {
            return _array[length, width, height];
        }

    }
}
