using System;
using RedBlackTree;
namespace Work
{
    class Program
    {
        static void Main()
        {
            Tree T = new();
            Date dateToIncert = new();
            for (int month = 1; month <= 3; month++)
            {
                for (int day = 1; day <= 50; day++)
                {
                    dateToIncert.Set(day, month);
                    T.Add(dateToIncert);
                }
            }
            T.PrintTree();
            T.Clear();
            T.PrintTree();
            for (int month = 1; month <= 3; month++)
            {
                for (int day = 50; day >= 1; day--)
                {
                    dateToIncert = new(day, month);
                    T.Add(dateToIncert);
                }
            }
            T.PrintTree();
            for (int month = 1; month <= 3; month++)
            {
                for (int day = 100; day >= 1; day--)
                {
                    Date dateToDelete = new(day, month);
                    T.Delete(dateToDelete);
                }
            }
            T.PrintTree();
        }
    }
}

