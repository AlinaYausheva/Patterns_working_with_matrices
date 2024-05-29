using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_working_with_matrices
{
    public class SparseMatrix<T> : SomeMatrix<T>
    {
        public SparseMatrix(int row, int column) : base(row, column) { }

        protected override IVector<T> CreatVector(int column)
        {
            return new SparseVector<T>(column);
        }
        public override bool DrawThisValue(IMatrixExt m, int row, int column)
        {
            if (m.rowNum > row && m.columnNum > column)
            {
                T mark = (T)Convert.ChangeType(0, typeof(T));
                T value = (T)Convert.ChangeType(m.readInfo(row, column), typeof(T));
                if (Comparer<T>.Default.Compare(value, mark) == 0)
                    return false;
                return true;
            }
            return false;
        }

    }
}
