using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_working_with_matrices
{
    public class ChangeMatrix : ACommand
    {
        IMatrixExt matrix;

        public ChangeMatrix(Form1 owner, IMatrixExt matrix) : base(owner)
        {
            this.matrix = matrix;
        }
        protected override void doExecute()
        {
            HorizontalGroupMatrix group = new HorizontalGroupMatrix();
            group.AddMatrix(matrix);
            owner.groupMatrix = group;
        }
    }
}
