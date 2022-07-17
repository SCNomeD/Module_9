using System;

namespace Module_9_5
{
    #region start
    //class Program
    //{
    //    public delegate void Notify();  // делегат                
    //    public class ProcessBusinessLogic
    //    {
    //        public event Notify ProcessCompleted; // событие
    //    }
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Hello World!");
    //    }
    //}
    #endregion
    #region proceed
    //public delegate void Notify();  // делегат
    //public class ProcessBusinessLogic
    //{
    //    public event Notify ProcessCompleted; // событие

    //    public void StartProcess()
    //    {
    //        Console.WriteLine("Процесс начат!");
    //        OnProcessCompleted();
    //    }

    //    protected virtual void OnProcessCompleted() //protected virtual method
    //    {
    //        ProcessCompleted?.Invoke();
    //    }
    //}
    //class Program
    //{
    //    public static void Main()
    //    {
    //        ProcessBusinessLogic bl = new ProcessBusinessLogic();
    //        bl.ProcessCompleted += bl_ProcessCompleted; // регистрируем событие
    //        bl.StartProcess();
    //    }

    //    // перехватчик событий
    //    public static void bl_ProcessCompleted()
    //    {
    //        Console.WriteLine("Процесс завершён!");
    //    }
    //}
    #endregion
    #region screencast
    class Program
    {
        static void Main(string[] args)
        {
            NumberReader numberReader = new NumberReader();
            numberReader.NumberEnteredEvent += ShowNumber;
            while (true)
            {
                try
                {
                    numberReader.Read();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введено некорректное значение");
                }
            }
        }
        static void ShowNumber(int number)
        {
            switch (number)
            {
                case 1: Console.WriteLine("Введено значение: 1"); break;
                case 2: Console.WriteLine("Введено значение: 2"); break;
            }
        }
    }
    class NumberReader
    {
        public delegate void NumberEnteredDelegate(int number);
        public event NumberEnteredDelegate NumberEnteredEvent;
        public void Read()
        {
            Console.WriteLine();
            Console.WriteLine("необходимо ввести значение: либо 1, либо 2");

            int number = Convert.ToInt32(Console.ReadLine());

            if (number != 1 && number != 2) throw new FormatException();

            NumberEntered(number);
        }

        protected virtual void NumberEntered (int number)
        {
            NumberEnteredEvent?.Invoke(number);
        }
    }
    #endregion
}
