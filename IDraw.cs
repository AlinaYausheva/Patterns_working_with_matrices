using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_working_with_matrices
{
    public interface IDraw
    {
        void StartDraw(IMatrixExt m);
        void DrawBorder(IMatrixExt m);
        void DrawValue(IMatrixExt m, int row, int column);
        void FinishDraw(IMatrixExt m);
    }
}
