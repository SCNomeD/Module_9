using System;

namespace Module_9_6_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Exception[] exceptions = { new ApplicationException(), new ArgumentException(), new ArgumentNullException(), new ArgumentOutOfRangeException(), new TestException() };

            try
            {
                throw new TestException();
            }
            catch (Exception ex) when (ex.GetType() == exceptions[0].GetType())
            {

            }
            catch (Exception ex) when (ex.GetType() == exceptions[1].GetType())
            {

            }
            catch (Exception ex) when (ex.GetType() == exceptions[2].GetType())
            {

            }
            catch (Exception ex) when (ex.GetType() == exceptions[3].GetType())
            {

            }
            catch (Exception ex) when (ex.GetType() == exceptions[4].GetType())
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
