using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF.MD18.U1.BuilderExample
{
    /// <summary>
    /// Строитель для создания рассылки о заказе
    /// </summary>
    class OrderTemplateBuilder : TemplateBuilder
    {
        public override void BuildHeader()
        {
            Template.Header = new Header { Text = "Здравствуйте, спасибо зазаказ!" };
        }
        public override void BuildBody()
        {
            Template.Body = new Body { Text = "Ваш номер заказа - 534" };
        }

        public override void BuildFooter()
        {
            Template.Footer = new Footer { Text = "ООО Лучший сервис, contact@bestservice.ru" };
        }
    }
}
