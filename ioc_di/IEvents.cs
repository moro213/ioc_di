
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ioc_di
{
    public interface IEvent
    {
        void EventDetail(); //Abstract method

    }

    public class TechEvents : IEvent
    {
        public void EventDetail()
        {
            Console.WriteLine("TechEvents details");
        }
    }

    public class CarEvents : IEvent
    {
        public void EventDetail()
        {
            Console.WriteLine("CarEvents details");
        }
    }

    public class RandomEvents : IEvent
    {
        public void EventDetail()
        {
            Console.WriteLine("RandomEvents details");
        }
    }


}
