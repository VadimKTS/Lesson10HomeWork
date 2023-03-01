namespace Lesson10HomeWork
{
    internal class WrongLoginExeption : Exception
    {
        public WrongLoginExeption() { }
        public WrongLoginExeption(string message) : base(message) { }
    }
}