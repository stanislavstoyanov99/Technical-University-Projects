using System;
using System.Collections.Generic;
using System.Threading;

namespace ProducerUser
{
    public class StartUp
    {
        public static int CAPACITY = 10;

        public static Queue<int> queue = new Queue<int>(CAPACITY);

        public static Semaphore semEmpty = new Semaphore(0, 10);
        public static Semaphore semFull = new Semaphore(CAPACITY, CAPACITY);
        public static Semaphore semExclude = new Semaphore(1, 1);

        public static void Main(string[] args)
        {

        }

        public static void Producer()
        {
            // TODO
            while (true)
            {
                queue.Enqueue(new Random().Next());
            }
        }

        public static void Consumer()
        {
            while (true)
            {
                semEmpty.WaitOne();
                semExclude.WaitOne();

                queue.Dequeue();

                semExclude.Release();
                semEmpty.Release();
            }
        }
    }
}
