using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Patterns_working_with_matrices
{
    class OutputForm : IDraw
    {
        private Graphics g;
        private bool drawBoarder;
        public OutputForm(Panel p, bool drawBoarder)
        {
            this.g = p.CreateGraphics();
            this.drawBoarder = drawBoarder;
        }
        public void StartDraw(IMatrixExt m)
        {
            g.TranslateTransform(5, 5);
        }
        public void DrawBorder(IMatrixExt m)
        {
            if (!drawBoarder)
                return;
            Pen pen = new Pen(Color.Black, 4);
            g.DrawRectangle(pen, 0, 0, m.columnNum*50, m.rowNum*20);
        }

        public void DrawValue(IMatrixExt m, int i, int j)
        {
            Pen pen = new Pen(Color.Black, 1);
            g.DrawString(m.readInfo(i,j).ToString(), new Font("Magneto", 10), Brushes.Black, j*50, i*20);
        }
        public void FinishDraw(IMatrixExt m)
        {
            g.Dispose();
        }
    }
}
