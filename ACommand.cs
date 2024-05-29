using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_working_with_matrices
{
    public abstract class ACommand : ICommand
    {
        protected Form1 owner;
        public ACommand(Form1 owner)
        {
            this.owner = owner;
        }
        public void Execute()
        {
            CommandManager.Instance(owner).Registory(this);
            this.doExecute();
        }
        protected abstract void doExecute();
    }
}
