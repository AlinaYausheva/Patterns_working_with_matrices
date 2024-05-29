using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_working_with_matrices
{
    public class CommandManager : ACommand
    {
        private static CommandManager instanse = null;
        private List<ICommand> list = new List<ICommand>();
        private bool block = false;
        private CommandManager(Form1 owner) : base(owner) { }


        public void Registory(ICommand command)
        {
            if (block) return;
            list.Add(command);
        }

        public void Undo()
        {
            if (list.Count == 1)
                return;
            block = true;
            list.RemoveAt(list.Count - 1);
            foreach (var i in list)
            {
                i.Execute();
            }
            block = false;
        }

        public static CommandManager Instance(Form1 owner)
        {
            if (instanse == null)
            {
                instanse = new CommandManager(owner);
            }
            return instanse;
        }

        protected override void doExecute()
        {

        }
    }
}
