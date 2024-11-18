using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF.MD18.U1.Builder
{
    /// <summary>
    /// Реализация строителя конкретного продукта
    /// </summary>
    internal class ProductBuilder : IBuilder
    {
        Product product = new Product();
        //1-й этап
        public void FirstStage()
        {
            product.Add("Part one");
        }
        //2-й этап
        public void SecondStage()
        {
            Console.WriteLine("Part two");
        }
        //3-й этап
        public void ThirdStage()
        {
            Console.WriteLine("Part three");
        }
        //4-й этап
        public Product GetBuildingResult()
        {
            return product;
        }


    }
}
