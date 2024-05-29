using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_working_with_matrices
{
    class Drawer
    {
        private IDraw draw;
        private IMatrixExt matrix;
        public Drawer(IDraw draw, IMatrixExt matrix)
        {
            this.draw = draw;
            this.matrix = matrix;
        }
        public void Draw()
        {
            draw.StartDraw(matrix);
            draw.DrawBorder(matrix);
            for (int i = 0; i < matrix.rowNum; i++)
            {
                for (int j = 0; j < matrix.columnNum; j++)
                {
                    if (matrix.DrawThisValue(matrix, i, j))
                    {
                        draw.DrawValue(matrix, i, j);
                    }
                }
            }
            draw.FinishDraw(matrix);
        }
    }
}
