using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_working_with_matrices
{
    interface Matrix<T>
    {
        int rowNum
        {
            get;
        }
        int columnNum
        {
            get;
        }
        T readInfo(int row, int column);
        void writeInfo(int row, int column, T value);
    }
}
