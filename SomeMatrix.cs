using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_working_with_matrices
{
    public abstract class SomeMatrix<T> : Matrix<T>
    {
        private IVector<T>[] matrix;
        public SomeMatrix(int row, int column)
        {
            this.rowNum = row;
            this.columnNum = column;
            this.matrix = new IVector<T>[row];

            for (int i = 0; i < row; i++)
            {
                matrix[i] = CreatVector(column);
            }
        }

        protected abstract IVector<T> CreatVector(int column);
        public abstract bool DrawThisValue(IMatrixExt m, int row, int column);

        public T readInfo(int row, int column)
        {
            if (row < matrix.Length)
                return matrix[row].readInfo(column);
            else return (T)Convert.ChangeType(0, typeof(T));
        }
        public void writeInfo(int row, int column, T value)
        {
            if (row < matrix.Length)
                matrix[row].writeInfo(column, value);
        }
        public int rowNum
        {
            get;
        }
        public int columnNum
        {
            get;
        }
    }
}
