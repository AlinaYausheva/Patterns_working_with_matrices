using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_working_with_matrices
{
    class RenumberingDecorator : IMatrixExt
    {
        private int[] columns;
        private int[] rows;
        IMatrixExt matrix;
        public RenumberingDecorator(IMatrixExt m)
        {
            matrix = m;
            this.rowNum = m.rowNum;
            this.columnNum = m.columnNum;
            this.columns = new int[columnNum];
            this.rows = new int[rowNum];
            for (int i = 0; i < columnNum; i++)
            {
                columns[i] = i;
            }
            for (int i = 0; i < rowNum; i++)
            {
                rows[i] = i;
            }            
        }
        public bool DrawThisValue(IMatrixExt m, int row, int column)
        {
            return matrix.DrawThisValue(m, rows[row], columns[column]);
        }

        public object readInfo(int row, int column)
        {
            return matrix.readInfo(rows[row],columns[column]);
        }
        public void writeInfo(int row, int column, object value)
        {
            matrix.writeInfo(rows[row], columns[column], value);
        }
        public int rowNum
        {
            get;
        }
        public int columnNum
        {
            get;
        }
        public void MixMatrix()
        {
            MixRows();
            MixColumns();
        }
        public void RestoreMatrix()
        {
            RestoreRows();
            RestoreColumns();
        }
        private void MixColumns()
        {
            Random rand = new Random();
            int column1 = rand.Next(0, columnNum);
            int column2 = column1;
            while (column1 == column2)
            {
                column2 = rand.Next(0, columnNum);
            }
            (columns[column1],columns[column2]) = (columns[column2], columns[column1]);
        }
        private void MixRows()
        {
            Random rand = new Random();
            int row1 = rand.Next(0, rowNum);
            int row2 = row1;
            while (row1 == row2)
            {
                row2 = rand.Next(0, rowNum);
            }
            (rows[row1], rows[row2]) = (rows[row2], rows[row1]);
        }
        private void RestoreColumns()
        {
            for (int i = 0; i < columnNum; i++)
            {
                columns[i] = i;
            }
        }
        private void RestoreRows()
        {
            for (int i = 0; i < rowNum; i++)
            {
                rows[i] = i;
            }
        }       
    }
}
