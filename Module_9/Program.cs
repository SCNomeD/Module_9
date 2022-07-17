using System;

namespace Module_9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Exception exception = new Exception("Собственное исключение.");
            exception.Data.Add("Дата создания исключения: ", DateTime.Now);
            exception.HelpLink = "www.google.com";
        }
    }
}
