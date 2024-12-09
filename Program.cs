namespace CoffeeTypes
{
    public class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Добро пожаловать в кофейню, у нас есть пять видов кофе, сделайте свой выбор нажав цифры от 1 до 5: \n" +
                                  "1 - Чёрный\n" +
                                  "2 - Американо\n" +
                                  "3 - Капучино\n" +
                                  "4 - Раф\n" +
                                  "5 - Фраппе");

                int cofe = Convert.ToInt32(Console.ReadLine());
                switch (cofe)
                {
                    case 1:
                        var cofe1 = new FiveCofe();
                        break;
                    case 2:
                        var cofe2 = new FiveCofe(true);
                        break;
                    case 3:
                        var cofe3 = new FiveCofe(true, "moloko");
                        break;
                    case 4:
                        var cofe4 = new FiveCofe(true, true, "moloko");
                        break;
                    case 5:
                        var cofe5 = new FiveCofe(true, true, "moloko", true);
                        break;
                    default:
                        Console.WriteLine("Вы ввели неверное значение");
                        break;
                }

                Console.ReadLine();
            }
        }
    }
};