﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF.MD18.U1.BuilderPack
{
    class ScooterConveyor : Conveyor
    {
        public ScooterConveyor()
        {
            _product = new Product("Скутер");
        }
        public override void BuildFrame()
        {
            _product["frame"] = "Рама скутера";
        }
        public override void BuildEngine()
        {
            _product["engine"] = "25 л.с.";
        }
        public override void BuildWheels()
        {
            _product["wheels"]= "2";
        }
        public override void BuildDoors()
        {
            _product["doors"] = "0"; 
        }
    }
}
