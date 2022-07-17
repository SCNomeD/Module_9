using System;

namespace Module_9_6_Task1
{
    internal class TestException : Exception
    {
        public override string Message { get; }
        internal TestException() : base()
        {
            Message = "Сработала ошибка";
        }
    }
}
