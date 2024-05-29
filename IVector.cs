using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_working_with_matrices
{
    public interface IVector<T>
    {
        int vectorSize
        {
            get;
        }
        T readInfo(int index);
        void writeInfo(int index, T value);
    }
}
