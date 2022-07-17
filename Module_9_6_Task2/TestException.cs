using System;

namespace Module_9_6_Task2
{
    internal class TestException : Exception
    {
        public override string Message { get; }
        internal TestException() : base()
        {
            Message = "Ошибка: введено некорректное число!";
        }
    }
}