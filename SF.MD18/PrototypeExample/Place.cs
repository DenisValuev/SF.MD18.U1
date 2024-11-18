using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF.MD18.U1.PrototypeExample
{
    /// <summary>
    /// Известное место на карте
    /// </summary>
    class Place : ILocation
    {
        string Address;
        public Place(string addres)
        {
            Address = addres;
        }

        public ILocation Clone()
        {
            return new Place(Address);
        }

        public void GetInfo()
        {
            Console.WriteLine($"Новый объект по адресу {Address}.");
        }
    }
}
