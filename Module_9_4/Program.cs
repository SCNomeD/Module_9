using System;

namespace Module_9_4
{
    #region Ковариантность
    //class Car
    //{
    //    public string Model { get; set; }
    //}
    //class BMW : Car
    //{
    //    delegate Car CarDelegate(string name);
    //    static void Main(string[] args)
    //    {
    //        CarDelegate carDelegate;
    //        carDelegate = BuildBMW; // ковариантность
    //        Car c = carDelegate("X6");
    //        Console.WriteLine(c.Model);
    //        Console.Read();
    //    }
    //    private static BMW BuildBMW(string model)
    //    {
    //        return new BMW { Model = model };
    //    }
    //}
    #endregion
    #region Контравариантность
    //class Car
    //{
    //    public string Model { get; set; }
    //}
    //class BMW : Car { }
    //public class Program
    //{
    //    delegate void BwmInfo(BMW bwm);
    //    static void Main(string[] args)
    //    {
    //        BwmInfo bmwInfo = GetCarInfo; // контравариантность
    //        BMW bwm = new BMW
    //        {
    //            Model = "X6"
    //        };
    //        bmwInfo(bwm);
    //        Console.Read();
    //    }
    //    private static void GetCarInfo(Car p)
    //    {
    //        Console.WriteLine(p.Model);
    //    }
    //}
    #endregion
    #region 9.4.1 (ковариантность)
    //class Animal
    //{
    //    public string Name
    //    {
    //        get;
    //        set;
    //    }
    //}
    //class Penguin : Animal { }

    //public class Program
    //{

    //    delegate Animal AnimalDelegate(string name);
    //    static void Main(string[] args)
    //    {
    //        AnimalDelegate animalDelegate;
    //        animalDelegate = BuildPeguin;
    //        Animal animal = animalDelegate("Josh");
    //        Console.WriteLine(animal.Name);
    //        Console.Read();
    //    }
    //    private static Penguin BuildPeguin(string name)
    //    {
    //        return new Penguin
    //        {
    //            Name = name
    //        };
    //    }
    //}
    #endregion
    #region screen_cast
    //class Program
    //{
    //    public delegate Animal HandlerMethod();

    //    public static Animal AnimalHandler()
    //    {
    //        return null;
    //    }
    //    public static Dog DogHandler()
    //    {
    //        return null;
    //    }
    //    static void Main(string[] args)
    //    {
    //        HandlerMethod handlerMethod = AnimalHandler;
    //        HandlerMethod handlerDog = DogHandler; // ковариация - Хоть делегат и имеет класс возвращаемого значения Animal, в него успешно принимается класс возвращаемого значения Dog т.к. Dog уснаследован от Animal
    //    }
    //}
    //class Animal
    //{

    //}
    //class Dog : Animal
    //{

    //}
    #endregion
    #region screen_cast proceed
    //class Program
    //{
    //    public delegate Animal HandlerMethod();
    //    delegate void DogInfo(Dog dog);

    //    public static Animal AnimalHandler()
    //    {
    //        return null;
    //    }
    //    public static Dog DogHandler()
    //    {
    //        return null;
    //    }
    //    static void Main(string[] args)
    //    {
    //        DogInfo dogInfo = GetAnimalInfo;
    //        dogInfo.Invoke(new Dog());

    //        HandlerMethod handlerMethod = AnimalHandler;
    //        HandlerMethod handlerDog = DogHandler; // ковариация - Хоть делегат и имеет класс возвращаемого значения Animal, в него успешно принимается класс возвращаемого значения Dog т.к. Dog уснаследован от Animal

    //        Console.Read();
    //    }
    //    public static void GetAnimalInfo(Animal p)
    //    {
    //        Console.WriteLine(p.GetType());
    //    }
    //}
    //class Animal
    //{

    //}
    //class Dog : Animal
    //{

    //}
    #endregion
    #region 9.4.2 (ковариантность)
    //class Program
    //{
    //    public delegate Car HandlerMethod();
    //    public static Car CarHandler()
    //    {
    //        return null;
    //    }
    //    public static Lexus LexusHandler()
    //    {
    //        return null;
    //    }
    //    static void Main(string[] args)
    //    {
    //        HandlerMethod handlerMethod = CarHandler;
    //        HandlerMethod handlerLexus = LexusHandler;

    //        Console.Read();
    //    }
    //}
    //class Car
    //{

    //}
    //class Lexus : Car
    //{

    //}
    #endregion
    #region 9.4.3 (контравариантность)
    //class Program
    //{
    //    public delegate Parent HandlerMethod();
    //    delegate void ChildInfo(Child child);
    //    public static Parent ParentHandler()
    //    {
    //        return null;
    //    }
    //    public static Child ChildHandler()
    //    {
    //        return null;
    //    }

    //    static void Main(string[] args)
    //    {
    //        ChildInfo childInfo = GetParentInfo;

    //        childInfo.Invoke(new Child());

    //        Console.Read();
    //    }
    //    public static void GetParentInfo(Parent p)
    //    {
    //        Console.WriteLine(p.GetType());
    //    }
    //}
    //class Parent
    //{

    //}
    //class Child : Parent
    //{

    //}
    #endregion
}
