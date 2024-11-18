using SF.MD18.U1.Builder;
using SF.MD18.U1.BuilderExample;
using SF.MD18.U1.BuilderPack;
using SF.MD18.U1.PrototypeExample;

namespace SF.MD18.U1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Builder
            //Инициализация строителя
            IBuilder builder = new ProductBuilder();
            //Создаем менеджера, который будет рулить процессами
            BuildManager buildManager = new BuildManager(builder);

            //Стартуем и получаем результат
            //buildManager.StartBuildingProcess();
            //Product product = builder.GetBuildingResult();
            #endregion

            Console.WriteLine();

            #region BuilderExample
            //Создадим движок шаблонизатора
            TemplaetEngine templateEngine = new TemplaetEngine();

            //Создаем шаблонизатор для приветственной рассылки
            TemplateBuilder tmpbuilder = new WelcomTemplateBuilder();
            //Генерируем приветственное письмо с текстом 
            Template greetingsTemplate = templateEngine.GenerateTemplate(tmpbuilder);
            Console.WriteLine(greetingsTemplate.ToString());

            //Переопределяем шаблонизатор для рассылки с номером заказа
            tmpbuilder = new OrderTemplateBuilder();
            //Генерируем письмо с номером заказа
            Template orderTemplate = templateEngine.GenerateTemplate(tmpbuilder);
            Console.WriteLine(orderTemplate.ToString());

            #endregion

            Console.WriteLine();

            #region BuilderTask
            //Продукт завода, который будет заниматься производством
            var carPlant = new CarPlant();

            //Производство скутеров
            Conveyor builderConv = new ScooterConveyor();
            carPlant.Construct(builderConv);
            builderConv.Product.Show();

            //Производство автомобиля
            builderConv = new CarConveyor();
            carPlant.Construct(builderConv);
            builderConv.Product.Show();

            //Производство мотоциклов
            builderConv = new MotoConveyor();
            carPlant.Construct(builderConv);
            builderConv.Product.Show();
            #endregion

            Console.WriteLine();

            #region PrototypeExample
            //Создаем точку
            ILocation location = new Point(30.245, 40.954);

            //Клонируем точку (получаем новую точку с теми же координатами)
            ILocation cloneLacation = location.Clone();

            location.GetInfo();
            cloneLacation.GetInfo();

            //Создаем место
            location = new Place("Улица пушкина, дом Колотушкина");
            //Клонируем место (получаем новое место по тому же адресу)
            //пример использования - нам надо обозначить новый магазин в том же самом торговом центре
            cloneLacation = location.Clone();

            location.GetInfo();
            cloneLacation.GetInfo();
            #endregion
        }
    }
}
