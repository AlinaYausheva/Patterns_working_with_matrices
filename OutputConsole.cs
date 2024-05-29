using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patterns_working_with_matrices
{
    class OutputConsole : IDraw
    {
        private string[][] mConsol;
        private TextBox textBox;
        private bool drawBoarder;

        public OutputConsole(TextBox textBox, bool drawBoarder)
        {
            this.textBox = textBox;
            this.drawBoarder = drawBoarder;
        }

        public void StartDraw(IMatrixExt m)
        {
            int row = m.rowNum + 2;
            int column = m.columnNum + 2;
            mConsol = new string[row][];
            for (int i = 0; i < row; i++)
            {
                mConsol[i] = new string[column];
            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (j != 0 && j != column - 1)
                        mConsol[i][j] = "       ";
                    else
                        mConsol[i][j] = " ";
                }
            }
        }
        public void DrawBorder(IMatrixExt m)
        {
            if (!drawBoarder)
                return;
            int row = m.rowNum + 2;
            int column = m.columnNum + 2;
            DrawHorizontal(row, column);
            DrawVertical(row, column);
        }

        public void DrawValue(IMatrixExt m, int i, int j)
        {
            switch (m.readInfo(i, j).ToString().Length)
            {
                case 1:
                    mConsol[i + 1][j + 1] = "   " + m.readInfo(i, j).ToString() + "   ";
                    break;
                case 2:
                    mConsol[i + 1][j + 1] = "  " + m.readInfo(i, j).ToString() + "   ";
                    break;
                case 3:
                    mConsol[i + 1][j + 1] = "  " + m.readInfo(i, j).ToString() + "  ";
                    break;
                case 4:
                    mConsol[i + 1][j + 1] = " " + m.readInfo(i, j).ToString() + "  ";
                    break;
                case 5:
                    mConsol[i + 1][j + 1] = " " + m.readInfo(i, j).ToString() + " ";
                    break;
            }
        }
        public void FinishDraw(IMatrixExt m)
        {
            
            textBox.Text = InText(m.rowNum + 2, m.columnNum + 2);
        }
        private void DrawHorizontal(int row, int column)
        {
            for (int j = 1; j < column-1; j++)
            {
                mConsol[0][j] = "-------";
                mConsol[row-1][j] = "-------";
            }
        }
        private void DrawVertical(int row, int column)
        {
            for (int i = 0; i < row; i++)
            {
                mConsol[i][0] = "|";
                mConsol[i][column-1] = "|";
            }
        }
        private string InText(int row, int column)
        {
            string text = "";
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    text += mConsol[i][j];
                }
                text += "\r\n";
            }
            return text;
        }
    }
}
