using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_working_with_matrices
{
    class TransposeDecorator : IMatrixExt
    {
        private IMatrixExt matrix;

        public TransposeDecorator(IMatrixExt matrix)
        {
            this.matrix = matrix;
        }
        public int rowNum => matrix.columnNum;

        public int columnNum => matrix.rowNum;

        public bool DrawThisValue(IMatrixExt m, int row, int column)
        {
            return matrix.DrawThisValue(m, column, row);
        }

        public object readInfo(int row, int column)
        {
            return matrix.readInfo(column, row);
            /*if (row < matrix.rowNum && column < matrix.columnNum)
                return matrix.readInfo(column, row);
            return (T)Convert.ChangeType(0, typeof(T));*/
        }

        public void writeInfo(int row, int column, object value)
        {
            matrix.writeInfo(column, row, value);
        }
    }
}
