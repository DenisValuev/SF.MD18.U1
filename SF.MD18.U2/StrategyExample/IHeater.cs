using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF.MD18.U2.StrategyExample
{
    /// <summary>
    /// Общий интерфейс отопительных котлов
    /// </summary>
    interface IHeater
    {
        //Нагрев
        void Heat();
    }
}
