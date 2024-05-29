using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_working_with_matrices
{
    public interface IMatrix
    {
        int rowNum
        {
            get;
        }
        int columnNum
        {
            get;
        }
        object readInfo(int row, int column);
        void writeInfo(int row, int column, object value);
    }
    public interface IMatrixExt : IMatrix
    {
        bool DrawThisValue(IMatrixExt m, int row, int column);
    }
}
