using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_working_with_matrices
{
    class AddMatrix : ACommand
    {
        IMatrixExt matrix;

        public AddMatrix(Form1 owner, IMatrixExt matrix) : base(owner)
        {
            this.matrix = matrix;
        }
        protected override void doExecute()
        {
            if (owner.groupMatrix == null)
                owner.groupMatrix = new HorizontalGroupMatrix();
            owner.groupMatrix.AddMatrix(matrix);
        }
    }
}
