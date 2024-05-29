using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patterns_working_with_matrices
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            new Init(this).Execute();
        }

        Form2 info = new Form2();
        private bool drawBoarder = false;

        IMatrixExt matrix;
        public IMatrixExt lastMatrix = null;
        public HorizontalGroupMatrix groupMatrix;

        RenumberingDecorator renumbering;
        TransposeDecorator transpose;

        private void GenerationUsual_Click(object sender, EventArgs e)
        {
            info.ShowDialog();

            if (info.matrixType == typeof(Int32))
            {
                matrix = new IntMatrixAdapter(new UsualMatrix<int>(info.rowNum, info.columnNum));
                InitiatorMatrix<int>.FillMatrix(matrix, info.notNullEl, info.maxEl);
                new AddMatrix(this, matrix).Execute();
                DrawMatrix(groupMatrix);
            }
            else if (info.matrixType == typeof(Double))
            {
                matrix = new DoubleMatrixAdapter(new UsualMatrix<double>(info.rowNum, info.columnNum));
                InitiatorMatrix<double>.FillMatrix(matrix, info.notNullEl, info.maxEl);
                new AddMatrix(this, matrix).Execute();
                DrawMatrix(groupMatrix);
            }
        }

        private void GenerationSparse_Click(object sender, EventArgs e)
        {
            info.ShowDialog();

            if (info.matrixType == typeof(Int32))
            {
                matrix = new IntMatrixAdapter(new SparseMatrix<int>(info.rowNum, info.columnNum));
                InitiatorMatrix<int>.FillMatrix(matrix, info.notNullEl, info.maxEl);
                new AddMatrix(this, matrix).Execute();
                DrawMatrix(groupMatrix);
            }
            else if (info.matrixType == typeof(Double))
            {
                matrix = new DoubleMatrixAdapter(new SparseMatrix<double>(info.rowNum, info.columnNum));
                InitiatorMatrix<double>.FillMatrix(matrix, info.notNullEl, info.maxEl);
                new AddMatrix(this, matrix).Execute();
                DrawMatrix(groupMatrix);
            }
        }
        private void Renumber_Click(object sender, EventArgs e)
        {
            renumbering = new RenumberingDecorator(lastMatrix);
            renumbering.MixMatrix();
            new ChangeMatrix(this, renumbering).Execute();
            DrawMatrix(renumbering);
            
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            CommandManager.Instance(this).Undo();
            DrawMatrix(groupMatrix);
        }

        private void Transpose_Click(object sender, EventArgs e)
        {
            transpose = new TransposeDecorator(groupMatrix);
            new ChangeMatrix(this, transpose).Execute();
            DrawMatrix(groupMatrix);
        }

        private void DrawBorder_CheckedChanged(object sender, EventArgs e)
        {
            drawBoarder = !drawBoarder;
            DrawMatrix(lastMatrix);
        }
        private void ClearForm()
        {
            panel1.Refresh();
            textBox1.Clear();
        }

        private void DrawMatrix(IMatrixExt matrix)
        {
            ClearForm();
            if (matrix == null)
                return;

            OutputConsole c = new OutputConsole(textBox1, drawBoarder);
            new Drawer(c, matrix).Draw();

            OutputForm f = new OutputForm(panel1, drawBoarder);
            new Drawer(f, matrix).Draw();

            lastMatrix = matrix;
        }
    }
}
