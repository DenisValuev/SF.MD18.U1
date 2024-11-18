using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF.MD18.U1.Builder
{
    /// <summary>
    /// Абстрактный интерфейс строителя
    /// </summary>
    internal interface IBuilder
    {
        void FirstStage();
        void SecondStage();
        void ThirdStage();
        Product GetBuildingResult();
    }
}
