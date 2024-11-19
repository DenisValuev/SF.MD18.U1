using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF.MD18.U2.StrategyExample
{
    class Boiler
    {
        //Мощность
        protected int Power;

        //Модель
        protected string Model;

        //Интерфейс подключения отопителя
        public IHeater Heater { private get; set; }
        public Boiler(int power, string model, IHeater heater)
        {
            Power = power;
            Model = model;
            Heater = heater;
        }

        /// <summary>
        /// Запус отопителя
        /// </summary>
        public void Start()
        {
            Heater.Heat();
        }
    }
}
