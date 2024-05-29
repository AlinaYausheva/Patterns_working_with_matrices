using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_working_with_matrices
{
    public class IntMatrixAdapter : IMatrixExt
    {
        private SomeMatrix<int> matrix;

        public IntMatrixAdapter(SomeMatrix<int> matrix)
        {
            this.matrix = matrix;
        }
        public int rowNum => matrix.rowNum;

        public int columnNum => matrix.columnNum;

        public bool DrawThisValue(IMatrixExt m, int row, int column)
        {
            return matrix.DrawThisValue(m, row, column);
        }
        public object readInfo(int row, int column)
        {
            return matrix.readInfo(row, column);
        }

        public void writeInfo(int row, int column, object value)
        {
            matrix.writeInfo(row, column, (int)value);
        }
    }
}
