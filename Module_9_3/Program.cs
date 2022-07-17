using System;

namespace Module_9_3
{
    #region start (старыми средствами)
    //public class MyClass
    //{
    //    public void Process()
    //    {
    //        Console.WriteLine("Процесс начат");
    //        Console.WriteLine("Процесс окончен");
    //    }
    //}

    //public class Test
    //{
    //    static void Main(string[] args)
    //    {
    //        MyClass myClass = new MyClass();
    //        myClass.Process();
    //        Console.ReadLine();
    //    }
    //}
    #endregion
    #region proceed (с помощью делегатов)
    //public class Program
    //{
    //    public delegate int SumDelegate(int a, int b, int c);

    //    static void Main(string[] args)
    //    {
    //        SumDelegate sumDelegate = Sum;
    //        sumDelegate.Invoke(1, 10, 50);
    //        Console.ReadKey();
    //    }

    //    static int Sum(int a, int b, int c)
    //    {
    //        return a + b + c;
    //    }
    //}
    #endregion
    #region 9.3.2 - 9.3.3
    //public class Program
    //{
    //    public delegate int DifDelegate(int a, int b);

    //    static void Main(string[] args)
    //    {
    //        DifDelegate difDelegate = Difference;
    //        int result = difDelegate.Invoke(10, 1);
    //        int result2 = difDelegate(10, 1);// аналог записи вызова делегата
    //        Console.WriteLine(result);
    //        Console.WriteLine(result2);
    //        Console.ReadLine();
    //    }

    //    static int Difference(int a, int b)
    //    {
    //        return a - b;
    //    }
    //}
    #endregion
    #region proceed (мультикастовые или многоадресные делегаты)
    //public class Program
    //{
    //    public delegate void ShowDelegate();
    //    static void Main(string[] args)
    //    {

    //        ShowDelegate showDelegate = ShowMessage1;
    //        showDelegate += ShowMessage2;
    //        showDelegate += ShowMessage3;
    //        showDelegate += ShowMessage4;

    //        showDelegate.Invoke();

    //        Console.ReadKey();
    //    }
    //    static void ShowMessage1()
    //    {
    //        Console.WriteLine("Метод 1");
    //    }
    //    static void ShowMessage2()
    //    {
    //        Console.WriteLine("Метод 2");
    //    }
    //    static void ShowMessage3()
    //    {
    //        Console.WriteLine("Метод 3");
    //    }
    //    static void ShowMessage4()
    //    {
    //        Console.WriteLine("Метод 4");
    //    }
    //}
    #endregion
    #region 9.3.4
    //public class Program
    //{
    //    public delegate void Delegate(int a, int b);
    //    static void Main(string[] args)
    //    {
    //        Delegate myDelegate = Sum;
    //        myDelegate += Difference;
    //        myDelegate(10, 1);
    //        Console.ReadLine();
    //    }
    //    static void Sum(int a, int b)
    //    {
    //        Console.WriteLine(a + b);
    //    }
    //    static void Difference(int a, int b)
    //    {
    //        Console.WriteLine(a - b);
    //    }
    //}
    #endregion
    #region proceed (удаление методов из делегата)
    //public class Program
    //{
    //    public delegate void ShowDelegate();
    //    static void Main(string[] args)
    //    {
    //        ShowDelegate showDelegate = ShowMessage1;
    //        showDelegate += ShowMessage2;
    //        showDelegate += ShowMessage3;
    //        showDelegate += ShowMessage4;

    //        showDelegate -= ShowMessage4;
    //        showDelegate -= ShowMessage3;
    //        showDelegate -= ShowMessage2;

    //        showDelegate.Invoke();

    //        Console.ReadKey();
    //    }
    //    static void ShowMessage1()
    //    {
    //        Console.WriteLine("Метод 1");
    //    }
    //    static void ShowMessage2()
    //    {
    //        Console.WriteLine("Метод 2");
    //    }
    //    static void ShowMessage3()
    //    {
    //        Console.WriteLine("Метод 3");
    //    }
    //    static void ShowMessage4()
    //    {
    //        Console.WriteLine("Метод 4");
    //    }
    //}
    #endregion
    #region 9.3.5
    //public class Program
    //{
    //    public delegate void Delegate(int a, int b);
    //    static void Main(string[] args)
    //    {
    //        Delegate myDelegate = Sum;
    //        myDelegate += Difference;
    //        myDelegate -= Difference;
    //        myDelegate(10, 1);
    //        Console.ReadLine();
    //    }
    //    static void Sum(int a, int b)
    //    {
    //        Console.WriteLine(a + b);
    //    }
    //    static void Difference(int a, int b)
    //    {
    //        Console.WriteLine(a - b);
    //    }
    //}
    #endregion
    #region proceed (объединение делегатов)
    //public class Program
    //{
    //    public delegate void ShowDelegate();
    //    static void Main(string[] args)
    //    {
    //        ShowDelegate showDelegate1 = ShowMessage1;
    //        showDelegate1 += ShowMessage2;

    //        ShowDelegate showDelegate2 = ShowMessage3;
    //        showDelegate2 += ShowMessage4;

    //        ShowDelegate showDelegate3 = showDelegate1 + showDelegate2;

    //        showDelegate3.Invoke();

    //        Console.ReadKey();
    //    }
    //    static void ShowMessage1()
    //    {
    //        Console.WriteLine("Метод 1");
    //    }
    //    static void ShowMessage2()
    //    {
    //        Console.WriteLine("Метод 2");
    //    }
    //    static void ShowMessage3()
    //    {
    //        Console.WriteLine("Метод 3");
    //    }
    //    static void ShowMessage4()
    //    {
    //        Console.WriteLine("Метод 4");
    //    }
    //}
    #endregion
    #region 9.3.7
    //public class Program
    //{
    //    delegate void ShowMessageDelegate();
    //    delegate int SumDelegate(int a, int b, int c);
    //    delegate bool CheckLengthDelegate(string _row);

    //    static void Main(string[] args)
    //    {
    //        ShowMessageDelegate showMessageDelegate = ShowMessage;
    //        showMessageDelegate.Invoke();

    //        SumDelegate sumDelegate = Sum;
    //        int result = sumDelegate.Invoke(1, 30, 120);
    //        Console.WriteLine(result);

    //        CheckLengthDelegate checkLengthDelegate = CheckLength;
    //        bool status = checkLengthDelegate.Invoke("skill_factory");
    //        Console.WriteLine(status);

    //        Console.ReadKey();
    //    }
    //    static void ShowMessage()
    //    {
    //        Console.WriteLine("Hello World!");
    //    }
    //    static int Sum(int a, int b, int c)
    //    {
    //        return a + b + c;
    //    }
    //    static bool CheckLength(string _row)
    //    {
    //        if (_row.Length > 3) return true;
    //        return false;
    //    }
    //}
    #endregion
    #region (делегат Func - используется всякий раз, когда ваш делегат возвращает какое-либо значение, независимо от того, принимает ли он какой-либо входной параметр или нет.)
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Func<int, int, int> Addition = AddNumbers;
    //        int result = Addition(10, 20);
    //        Console.WriteLine(result);
    //    }
    //    private static int AddNumbers(int param1, int param2)
    //    {
    //        return param1 + param2;
    //    }
    //}
    #endregion
    #region (делегат Action - используется, когда ваш делегат не возвращает никакого значения, независимо от того, принимает ли он какой-либо входной параметр или нет.)
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Action<string> action = new Action<string>(Display);
    //        action("Привет разработчик!");
    //        Console.Read();
    //    }
    //    static void Display(string message)
    //    {
    //        Console.WriteLine(message);
    //    }
    //}
    #endregion
    #region (делегат Predicate - используется в тех случаях, если ваш делегат возвращает только логическое значение (true или false), принимая только один входной параметр.)
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Predicate<string> CheckIfApple = IsApple;
    //        bool result = CheckIfApple("IPhone X");
    //        if (result) Console.WriteLine("Это IPhone X");
    //    }
    //    private static bool IsApple(string modelName)
    //    {
    //        if (modelName == "IPhone X") return true;
    //        else return false;
    //    }
    //}
    #endregion
    #region proceed 9.3.7
    //public class Program
    //{
    //    delegate void ShowMessageDelegate();
    //    delegate int SumDelegate(int a, int b, int c);
    //    delegate bool CheckLengthDelegate(string _row);

    //    static void Main(string[] args)
    //    {
    //        //Action в деле:
    //        //ShowMessageDelegate showMessageDelegate = ShowMessage;
    //        //showMessageDelegate.Invoke();
    //        Action showMessageDelegate = ShowMessage;
    //        showMessageDelegate.Invoke();

    //        //Func в деле:
    //        //SumDelegate sumDelegate = Sum;
    //        //int result = sumDelegate.Invoke(1, 30, 120);
    //        //Console.WriteLine(result);
    //        Func<int, int, int, int> sumDelegate = Sum;
    //        int result = sumDelegate.Invoke(1, 30, 120);
    //        Console.WriteLine(result);

    //        //Predicate в деле:
    //        //CheckLengthDelegate checkLengthDelegate = CheckLength;
    //        //bool status = checkLengthDelegate.Invoke("skill_factory");
    //        //Console.WriteLine(status);
    //        Predicate<string> checkLengthDelegate = CheckLength;
    //        bool status = checkLengthDelegate.Invoke("skill_factory");
    //        Console.WriteLine(status);

    //        Console.ReadKey();
    //    }
    //    static void ShowMessage()
    //    {
    //        Console.WriteLine("Hello World!");
    //    }
    //    static int Sum(int a, int b, int c)
    //    {
    //        return a + b + c;
    //    }
    //    static bool CheckLength(string _row)
    //    {
    //        if (_row.Length > 3) return true;
    //        return false;
    //    }
    //}
    #endregion
    #region proceed (анонимые методы)
    //public class AnonymousMethods
    //{
    //    public delegate string GreetingsDelegate(string name);
    //    public static string Greetings(string name)
    //    {
    //        return "Привет @" + name + "! Добро пожаловать на SkillFactory!";
    //    }

    //    static void Main(string[] args)
    //    {
    //        GreetingsDelegate gd = new GreetingsDelegate(AnonymousMethods.Greetings);
    //        string GreetingsMessage = gd.Invoke("Будущий гуру");
    //        Console.WriteLine(GreetingsMessage);
    //        Console.ReadKey();
    //    }
    //}

    //Аналог выше, но с использованием ананимного метода
    //public class AnonymousMethods
    //{
    //    public delegate string GreetingsDelegate(string name);

    //    static void Main(string[] args)
    //    {
    //        GreetingsDelegate gd = delegate (string name)
    //        {
    //            return "Привет @" + name + " и добро пожаловать на SkillFactory!";
    //        };
    //        string GreetingsMessage = gd.Invoke("Pranaya");
    //        Console.WriteLine(GreetingsMessage);
    //        Console.ReadKey();
    //    }
    //}
    #endregion
    #region proceed (анонимые методы - еще пример без использования отдельного метода Calculate)
    //class Program
    //{
    //    delegate int CalculateDelegate(int a, int b);
    //    static void Main(string[] args)
    //    {
    //        CalculateDelegate calculateDelegate = delegate (int a, int b)
    //        {
    //            return a + b;
    //        };

    //        int result = calculateDelegate.Invoke(50, 10);

    //        Console.WriteLine(result);
    //        Console.ReadKey();
    //    }
    //}
    #endregion
    #region proceed (анонимые методы !Это важно: анонимные методы имеют доступ к переменным во внешней среде.!)
    //public class AnonymousMethods
    //{
    //    public delegate string GreetingsDelegate(string name);

    //    static void Main(string[] args)
    //    {
    //        string Message = "добро пожаловать на SkillFactory!";
    //        GreetingsDelegate gd = delegate (string name)
    //        {
    //            return "Привет @" + name + " " + Message; //Несмотря на то что, переменная string Message объявлена ранее анонимного делегата, анонимный делегат успешно имеет к ней доступ. Это необходимо запомнить.
    //        };
    //        string GreetingsMessage = gd.Invoke("Будущий гуру");
    //        Console.WriteLine(GreetingsMessage);
    //        Console.ReadKey();
    //    }
    //}
    #endregion
    #region 9.3.12
    //class Program
    //{
    //    delegate void ShowMessageDelegate(string _message);
    //    static void Main(string[] args)
    //    {
    //        ShowMessageDelegate showMessageDelegate = delegate (string _message)
    //        {
    //            Console.WriteLine(_message);
    //        };
    //        showMessageDelegate.Invoke("Hello World!");
    //        Console.Read();

    //        //ShowMessageDelegate showMessageDelegate = ShowMessage;
    //        //showMessageDelegate.Invoke("Hello World!");
    //        //Console.Read();
    //    }
    //    //static void ShowMessage(string _message)
    //    //{
    //    //    Console.WriteLine(_message);
    //    //}
    //}
    #endregion
    #region 9.3.13
    //class Program
    //{
    //    delegate int RandomNumberDelegate();
    //    static void Main(string[] args)
    //    {
    //        RandomNumberDelegate randomNumberDelegate = delegate
    //        {
    //            return new Random().Next(0, 100);
    //        };
    //        int result = randomNumberDelegate.Invoke();
    //        Console.WriteLine(result);
    //        Console.Read();

    //        //RandomNumberDelegate randomNumberDelegate = RandomNumber;
    //        //int result = randomNumberDelegate.Invoke();
    //        //Console.WriteLine(result);
    //        //Console.Read();
    //    }
    //    //static int RandomNumber()
    //    //{
    //    //    return new Random().Next(0, 100);
    //    //}
    //}
    #endregion
    #region proceed (Лямбда выражения)
    //class Program
    //{
    //    delegate int Calculate(int a, int c);
    //    static void Main(string[] args)
    //    {
    //        Calculate calculation = (x, y) => x + y;
    //        Console.WriteLine(calculation(10, 20));
    //        Console.WriteLine(calculation(40, 20));
    //        Console.Read();
    //    }
    //}
    #endregion
    #region 9.3.14
    //class Program
    //{
    //    delegate void ShowMessageDelegate(string _message);
    //    static void Main(string[] args)
    //    {
    //        ShowMessageDelegate showMessageDelegate = (string _message) =>
    //        {
    //            Console.WriteLine(_message);
    //        };
    //        showMessageDelegate.Invoke("Hello World!");
    //        Console.Read();
    //    }
    //}
    #endregion
    #region 9.3.15
    class Program
    {
        delegate int RandomNumberDelegate();
        static void Main(string[] args)
        {
            RandomNumberDelegate randomNumberDelegate = () =>
            {
                return new Random().Next(0, 100);
            };
            int result = randomNumberDelegate.Invoke();
            Console.WriteLine(result);
            Console.Read();
        }
    }
    #endregion
}
