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
            for(int i = 0; i <= inputData.Count-1; i++)
            {
                for(int j = 0; j <= inputData[i].Count-1; j++)
                {
                    for(int k = 0; k <= inputData[j].Count-1; k++)
                    {
                        _array[i,j,k] = inputData[i][j][k]; 
                    }
                }
            }
            return _array;
        }
    }
}
