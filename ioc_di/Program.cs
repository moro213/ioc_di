using System;

namespace ioc_di
{
    class Program
    {
        static void Main(string[] args)
        {
            Company cp = new Company();

            TechEvents Te = new TechEvents();
            CarEvents Ce = new CarEvents();
            RandomEvents Re = new RandomEvents();

            ///
            ///Tight coupling example
            ///

            //cp.GetEvents();

            //---------------------------------------------------------------------------------------

            ///
            ///Contstructor injection
            ///

            //Company c = new Company(Ce);
            //c.GetEvents();

            //---------------------------------------------------------------------------------------

            ///
            ///Property injection
            ///

            cp.MyEvent = new RandomEvents();
            cp.GetEvents();
            //---------------------------------------------------------------------------------------

            ///
            ///Method injection
            ///

            //cp.GetEvents(Te);

        }
    }
}
