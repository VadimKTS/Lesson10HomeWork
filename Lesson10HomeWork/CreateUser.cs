namespace Lesson10HomeWork
{
    public class CreateUser
    {
        static bool IsNumberContains(string input)
        {
            foreach (char c in input)
                if (Char.IsNumber(c))
                    return true;
            return false;
        }

        public static bool UserIsCorrect(string Login, string Password, string ConfirmPassword) 
        {
            bool result = false;
            try
            {
                if (Login.Length < 20 && !Login.Contains(' ')) { result = true; }
                else
                { result = false; throw new WrongLoginExeption("Неправильный login.");}

                if (Password.Length < 20 && !Password.Contains(' ') && IsNumberContains(Password)) // добавить условие is Digit
                { result = true; }
                else
                { result = false;  throw new WrongPasswordExeption("Неправильный password."); }

                if (ConfirmPassword.Equals(Password))
                { result = true; }
                else
                { result = false; throw new WrongPasswordExeption("Пароли не равны."); }
            }
            catch (Exception ex)
            { Console.Write($"Ошибка! {ex.Message} "); }
            
            return result;
        } 
    }
}