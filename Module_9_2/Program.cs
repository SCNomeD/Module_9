using System;

namespace Module_9_2
{
    class Program
    {
        #region 9.2.2
        //static void Main(string[] args)
        //{

        //    try
        //    {
        //        throw new ArgumentOutOfRangeException("Сообщение об ошибке");
        //    }

        //    catch (ArgumentOutOfRangeException ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }

        //    finally
        //    {
        //        Console.Read();
        //    }
        //}
        #endregion
        #region 9.2.3
        static void Main(string[] args)
        {

            try
            {
                throw new RankException("Сообщение об ошибке");
            }

            catch (RankException ex)
            {
                Console.WriteLine(ex.GetType());
            }

            finally
            {
                Console.Read();
            }
        }
        #endregion
    }
}
