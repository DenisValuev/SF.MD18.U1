using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF.MD18.U1.Builder
{
    internal class BuildManager
    {
        IBuilder Builder;
        public BuildManager(IBuilder builder)
        {
            Builder = builder;
        }
        public void StartBuildingProcess()
        {
            Builder.FirstStage();
            Builder.SecondStage();
            Builder.ThirdStage();
        }
    }
}
