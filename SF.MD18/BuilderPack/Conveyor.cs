﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF.MD18.U1.BuilderPack
{
    /// <summary>
    /// Абстрактный клас строителя
    /// </summary>
    abstract class Conveyor
    {
        protected Product _product;
        public Product Product 
        {
            get { return _product; }
        }

        //Методы для постройки составных частей
        public abstract void BuildFrame();
        public abstract void BuildEngine();
        public abstract void BuildWheels();
        public abstract void BuildDoors();
    }
}
