using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_working_with_matrices
{
    class UsualVector<T> : IVector<T>
    {
        private T[] vector;
        public UsualVector(int size)
        {
            this.vectorSize = size;
            vector = new T[size];
        }

        public int vectorSize
        {
            get;
        }
        public T readInfo(int index)
        {
            //return vector[index];
            if (vector.Length > index)
                return vector[index];
            else return (T)Convert.ChangeType(0, typeof(T));
        }
        public void writeInfo(int index, T value)
        {
            vector[index] = value;
        }
    }
}
