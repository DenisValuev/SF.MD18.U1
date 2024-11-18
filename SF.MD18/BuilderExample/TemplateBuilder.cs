using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF.MD18.U1.BuilderExample
{
    /// <summary>
    /// Абстрактный класс шаблонизатора
    /// </summary>
    abstract class TemplateBuilder
    {
        public Template Template { get; private set; }
        public void CreateTemplate()
        { 
            Template = new Template();
        }

        //Метод для создания заголовка
        public abstract void BuildHeader();
        
        //Для тела письма
        public abstract void BuildBody();

        //Для подписи в нижней части рассылки
        public abstract void BuildFooter();

    }
}
