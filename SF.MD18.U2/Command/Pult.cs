using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF.MD18.U2.Command
{
    /// <summary>
    /// Отправитель команд
    /// </summary>
    internal class Pult
    {
        IAction _action;

        /// <summary>
        /// Инициализатор команд
        /// </summary>
        /// <param name="action"></param>
        public void SetAction(IAction action)
        {
            _action = action;
        }
        public void OpenButton()
        {
            _action.Run();
        }
        public void CloseButton()
        {
            _action.Undo();
        }
    }
}
