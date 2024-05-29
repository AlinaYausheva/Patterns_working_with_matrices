using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_working_with_matrices
{
    class SparseVector<T> : IVector<T>
    {
        private Dictionary<int, T> vector;
        public SparseVector(int size)
        {
            this.vectorSize = size;
            vector = new Dictionary<int, T>(size);
        }

        public int vectorSize
        {
            get;
        }

        public T readInfo(int index)
        {
            if (vector.ContainsKey(index))
                return vector[index];
            else return (T)Convert.ChangeType(0, typeof(T));
        }
        public void writeInfo(int index, T value)
        {
            vector[index] = value;
        }
    }
}
