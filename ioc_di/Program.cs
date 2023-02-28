using Microsoft.Extensions.DependencyInjection;
using System;

namespace ioc_di
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dependancy injection - microsoft extension could use Autofac for example...
            ServiceCollection sc = new ServiceCollection();
            sc.AddSingleton<IEvent,TechEvents>();
            ServiceProvider sp = sc.BuildServiceProvider();

            //Company cp = new Company();

            //TechEvents Te = new TechEvents();
            //CarEvents Ce = new CarEvents();
            //RandomEvents Re = new RandomEvents();

            ///
            ///Tight coupling example
            ///

            //cp.GetEvents();

            //---------------------------------------------------------------------------------------

            ///
            ///Contstructor injection
            ///

            Company c = new Company(sp.GetService<IEvent>());
            c.GetEvents();

            //---------------------------------------------------------------------------------------

            ///
            ///Property injection
            ///

            //cp.MyEvent = new RandomEvents();
            //cp.GetEvents();
            //---------------------------------------------------------------------------------------

            ///
            ///Method injection
            ///

            //cp.GetEvents(Te);

        }
    }
}
