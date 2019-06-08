using System;

class Program
{
    static void Main(string[] args)
    {
        int winingDoor = 0;
        int emptyDoor = 0;
        int secondChoiceDoor = 0;
        int firstChoiceDoor = 0;

        int wins = 0;
        int secondWins = 0;

        for (int count = 1; count <= 100; count++)
        {
            Random r = new Random((int)DateTime.Now.Ticks);
            firstChoiceDoor = r.Next(1, 4);
            if (winingDoor == firstChoiceDoor)
            {
                winingDoor = firstChoiceDoor;
                wins++;
            }
            else
            {
                winingDoor = secondChoiceDoor;
                wins++;
            }

            for (emptyDoor = 1; emptyDoor <= 3; emptyDoor++)
            {
                if (emptyDoor != firstChoiceDoor && emptyDoor != winingDoor)
                {
                    break;
                }
            }
            for (secondChoiceDoor = 1; secondChoiceDoor <= 3; secondChoiceDoor++)
            {
                if (secondChoiceDoor != firstChoiceDoor && secondChoiceDoor != winingDoor)
                {
                    secondWins++;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
