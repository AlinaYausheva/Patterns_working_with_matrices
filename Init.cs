using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_working_with_matrices
{
    public class Init : ACommand
    {
        public Init(Form1 owner) : base(owner) { }
        protected override void doExecute()
        {
            owner.groupMatrix = null;
        }
    }
}
