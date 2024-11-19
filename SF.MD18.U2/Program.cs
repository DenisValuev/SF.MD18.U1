using SF.MD18.U2.Command;
using SF.MD18.U2.StrategyExample;

namespace SF.MD18.U2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Command
            Pult pult = new Pult();
            Gate gate = new Gate();

            pult.SetAction(new GateOpenAction(gate));
            pult.OpenButton();
            pult.CloseButton();

            #endregion

            Console.WriteLine();

            #region Strategy
            //Подключаем котел к газу
            var boiler = new Boiler(30, "Bosh", new GasHeater());
            //Запускаем
            boiler.Start();

            //Газ закончился. Переключаемся на электричество
            boiler.Heater = new ElectricHeater();
            //Запускаем
            boiler.Start();
            #endregion
        }
    }
}
