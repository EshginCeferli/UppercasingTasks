using System;
using Upcastin2.Models;

namespace Upcastin2
{
    class Program
    {
        static void Main(string[] args)
        {

            ExpMerc exp1 = new ExpMerc();
            ExpMerc exp3 = new ExpMerc();
            CheapBmw cheap1  = new CheapBmw();
            Cars cheap2 = new CheapBmw();


            Cars exp2 = exp1;

            Cars[] cars = { cheap1, exp1, cheap2, exp3, cheap2 };
            foreach (var item in cars)
            {
                item.CarSpeed();
            }


        }
    }
}
