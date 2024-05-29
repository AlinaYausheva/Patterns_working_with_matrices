using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_working_with_matrices
{
    class InitiatorMatrix<T>
    {
        public static IMatrixExt FillMatrix(IMatrixExt m, int notNull, int max)
        {
            Random rand = new Random();
            T mark = (T)Convert.ChangeType(0, typeof(T));
            while (notNull > 0)
            {
                int row = rand.Next(0, m.rowNum);
                int column = rand.Next(0, m.columnNum);
                T value = (T)Convert.ChangeType(Math.Round(rand.NextDouble() * max, 2), typeof(T));
                T mValue = (T)Convert.ChangeType(m.readInfo(row, column), typeof(T));
                if ((Comparer<T>.Default.Compare(value, mark) != 0)
                    && (Comparer<T>.Default.Compare(mValue, mark) == 0))
                {
                    m.writeInfo(row, column, value);
                    notNull--;
                }
            }
            return m;

        }
    }
}
