using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_working_with_matrices
{
    public class HorizontalGroupMatrix : IMatrixExt
    {
        private List<IMatrixExt> matrices;

        public HorizontalGroupMatrix()
        {
            matrices = new List<IMatrixExt>();
        }
        public int rowNum => matrices.Max(m => m.rowNum);

        public int columnNum => matrices.Sum(m => m.columnNum);

        public bool DrawThisValue(IMatrixExt m, int row, int column)
        {
            int columnIndex = 0;
            int rowIndex = 0;
            
            foreach (IMatrixExt matrix in matrices)
            {
                if (column < columnIndex + matrix.columnNum)
                {
                    return matrix.DrawThisValue(matrix, row, column-columnIndex);
                }
                columnIndex += matrix.columnNum;
            }
            
            foreach (IMatrixExt matrix in matrices)
            {
                if (row < rowIndex + matrix.rowNum)
                {
                    return matrix.DrawThisValue(matrix, row - rowIndex, column);
                }
                rowIndex += matrix.rowNum;
            }
            return false;
            throw new IndexOutOfRangeException();
        }

        public object readInfo(int row, int column)
        {
            int columnIndex = 0;
            int rowIndex = 0;
            foreach (IMatrixExt matrix in matrices)
            {
                if (column < columnIndex + matrix.columnNum)
                {
                    return matrix.readInfo(row, column - columnIndex);
                }
                columnIndex += matrix.columnNum;
            }
            foreach (IMatrixExt matrix in matrices)
            {
                if (row < rowIndex + matrix.rowNum)
                {
                    return matrix.readInfo(row - rowIndex, column);
                }
                rowIndex += matrix.rowNum;
            }
            throw new IndexOutOfRangeException();
            //return (T)Convert.ChangeType(0, typeof(T));
        }

        public void writeInfo(int row, int column, object value)
        {
            int columnIndex = 0;
            foreach (IMatrixExt matrix in matrices)
            {
                if (column < columnIndex + matrix.columnNum)
                {
                    matrix.writeInfo(row, column - columnIndex, value);
                    return; 
                }
                columnIndex += matrix.columnNum;
            } 
        }

        public void AddMatrix(IMatrixExt matrix)
        {
            matrices.Add(matrix);
        }
    }
}
