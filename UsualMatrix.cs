using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_working_with_matrices
{
    public class UsualMatrix<T> : SomeMatrix<T>
    {
        public UsualMatrix(int row, int column) : base(row, column) { }

        protected override IVector<T> CreatVector(int column)
        {
            return new UsualVector<T>(column);
        }
        public override bool DrawThisValue(IMatrixExt m, int row, int column)
        {
            if(m.rowNum > row && m.columnNum > column)
                return true;
            return false;
        }
        
    }
}
