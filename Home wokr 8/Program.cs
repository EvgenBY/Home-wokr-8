using System.Text;

namespace Home_wokr_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            // Спросим у пользователя имя собаки
            Console.WriteLine("Введите имя собаки: ");
            string dogName = Console.ReadLine();


            // Создаем объект типа Dog
            Dog dog = new Dog();


            //Устанавливаем имя и выводим его
            dog.SetName(dogName);
            Console.WriteLine($"Имя собаки: {dog.GetName()}");

            //Вызываем метод Eat
            dog.Eat();
        }
    }
}
