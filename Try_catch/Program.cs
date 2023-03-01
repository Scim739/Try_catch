using System.Data;

namespace Try_catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program.Registration("asdghaisdgh;","135253456", "135253456");
        }

        public static bool Registration(string login, string password, string confirmPassword)
        {
            string GoodSymbol = "QWERTYUIOPASDFGHJKLZXCVBNMmnbvcxzlkjhgfdsapoiuytrewq1234567890_";
            int GoodLogin = 0;
            int GoodPassword = 0;
            try
            {
                if (login.Length < 20)
                {
                    foreach (var a in login)
                    {
                        foreach (var b in GoodSymbol)
                        {
                            if (a == b)
                            {
                                GoodLogin += 1;
                            }
                        }
                    }
                }
                else
                {
                    throw new WrongLoginException("Логмн слишком большой");
                }

                if (password.Length < 20 && password == confirmPassword)
                {
                    foreach (var a in password)
                    {
                        foreach (var b in GoodSymbol)
                        {
                            if (a == b)
                            {
                                GoodPassword += 1;
                            }
                        }
                    }
                }
                else
                {
                    throw new WrongPasswordException("Пароль слишком большой");
                }

                if (GoodLogin != login.Length)
                {
                    throw new WrongLoginException("В логине неразрешенные символы");
                }

                if (GoodPassword != password.Length)
                {
                    throw new WrongPasswordException("В пароле неразрешенные символы");
                }
                return true;
            }
            catch (WrongLoginException wle)
            { return false; }

            catch (WrongPasswordException wre)
            { return false; }

        }
    }
}