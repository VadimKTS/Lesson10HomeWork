namespace Lesson10HomeWork
{
    internal class WrongPasswordExeption : Exception
    {
        public WrongPasswordExeption() { }
        public WrongPasswordExeption(string message) : base(message) { }
    }
}