using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF.MD18.U2.Command
{
    /// <summary>
    /// Общий интерфей команд
    /// </summary>
    internal interface IAction
    {
        void Run();
        void Undo();
    }
}
