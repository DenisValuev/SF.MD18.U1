using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF.MD18.U1.Builder
{
    /// <summary>
    /// Реализация продукта - сложного объекта
    /// </summary>
    internal class Product
    {
        //Список частей, из которых состоит объект
        List<object> parts = new List<object>();

        //Метод для поэтапного процесса создания
        public void Add(string part)
        {
            parts.Add(part);
        }
    }
}
