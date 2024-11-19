using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF.MD18.U2.Command
{
    /// <summary>
    /// Команда открытия ворот
    /// </summary>
    internal class GateOpenAction : IAction
    {
        Gate _gate;
        public GateOpenAction(Gate gateSet)
        {
            _gate = gateSet;
        }
        public void Run()
        {
            _gate.Open();
        }

        public void Undo()
        {
            _gate.Close();
        }
    }
}
