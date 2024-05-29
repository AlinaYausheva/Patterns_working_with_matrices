using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_working_with_matrices
{
    class StatisticsMatrix<T>
    {
        public T sum { get; }
        public double average { get; }
        public T max { get; }
        public int notNull { get; }
        public StatisticsMatrix(IMatrixExt m)
        {
            this.sum = CountSum(m);
            this.average = CountAverage(m);
            this.max = CountMax(m);
            this.notNull = CountNotNull(m);
        }

        private T CountSum(IMatrixExt m)
        {
            T sum = (T)Convert.ChangeType(0, typeof(T));
            for (int i = 0; i < m.rowNum; i++)
                for (int j = 0; j < m.columnNum; j++)
                {
                    sum = (T)((dynamic)sum + m.readInfo(i, j));
                }
            return sum;
        }
        private double CountAverage(IMatrixExt m)
        {
            return ((dynamic)sum / (T)Convert.ChangeType(m.rowNum * m.columnNum, typeof(T)));
        }
        private T CountMax(IMatrixExt m)
        {
            T max = (T)Convert.ChangeType(0, typeof(T));
            T value;
            for (int i = 0; i < m.rowNum; i++)
                for (int j = 0; j < m.columnNum; j++)
                {
                    value = (T)Convert.ChangeType(m.readInfo(i, j), typeof(T));
                    if (Comparer<T>.Default.Compare(value, max) >= 0)
                        max = value;
                }
            return max;
        }
        private int CountNotNull(IMatrixExt m)
        {
            int num = 0;
            T mark = (T)Convert.ChangeType(0, typeof(T));
            T value;
            for (int i = 0; i < m.rowNum; i++)
                for (int j = 0; j < m.columnNum; j++)
                {
                    value = (T)Convert.ChangeType(m.readInfo(i, j), typeof(T));
                    if (Comparer<T>.Default.Compare(value, mark) != 0)
                        num++;
                }
            return num;
        }
    }
}
