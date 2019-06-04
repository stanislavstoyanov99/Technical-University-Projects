using System;

namespace enumExample
{
    class Program
    {
        static void Main(string[] args)
        {
            DaysOfWeek lectureDay;
            lectureDay = DaysOfWeek.Monday;

            DaysOfWeek.IsDefined(typeof(DaysOfWeek), 8);
        }
        enum DaysOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
