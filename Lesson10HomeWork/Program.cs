namespace Lesson10HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CreateUser.UserIsCorrect("Vadik", "qwerty1", "qwerty1"));  // true
            Console.WriteLine(CreateUser.UserIsCorrect("Vadik12345678901234567890", "qwerty1", "qwerty1")); // false неправильный логин
            Console.WriteLine(CreateUser.UserIsCorrect("Vadik", "qwerty1", "qwerty123")); // false пароли не равны
            Console.WriteLine(CreateUser.UserIsCorrect("Vadik", "qwerty", "qwerty")); // false неправильный пароль, цифры
            Console.WriteLine(CreateUser.UserIsCorrect("Vadik", "qwe rty1", "qwe rty1")); // false неправильный пароль, пробелы
        }
    }
}