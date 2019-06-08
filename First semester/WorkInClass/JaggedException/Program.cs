using System;

namespace jaggedException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    try
                    {
                        throw new Exception();
                    }
                    catch (MyException e)
                    {
                        // 1
                    }
                    catch (Exception e)
                    {
                        // 2
                        throw new MyException(e.Message);
                    }
                }
                catch (Exception e)
                {
                    //3
                    throw;
                }
            }
            catch (MyException e)
            {
                //4
                throw;
            }
            catch (MyException e)
            {
                //5
            }
            catch (MyException e)
            {
                //6
            }
        }
    }
}
