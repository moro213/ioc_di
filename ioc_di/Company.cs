
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// 
/// Tight coupling - Company depends on events
/// 

//namespace ioc_di
//{
//    
//    public class Company
//    {
//        private Events _events;
//        public Company()
//        {
//            _events = new Events();
//        }

//        public void GetEvents()
//        {
//            _events.EventDetail();
//        }
//    }
//    public class Events
//    {  
//        public void EventDetail()
//        {
//            Console.WriteLine("Event details");
//        }    
//    }

//}

namespace ioc_di
{

    /// 
    ///Dependancy injection - Company depends on events
    ///Contstructor injection
    /// 

    public class Company
    {
        private IEvent _events = null;
        public Company(IEvent ie) //contstructor injection
        {
            _events = ie;
        }

        public void GetEvents()
        {
            _events.EventDetail();
        }
    }

}


//namespace ioc_di
//{

    /// 
    ///Dependancy injection - Company depends on events
    ///Property injection
    /// 

    //public class Company
    //{
    //    private IEvent _events = null;
        
    //    public IEvent MyEvent
    //    {
    //        set
    //        {
    //            _events = value;
    //        }           
    //    }

    //    public void GetEvents()
    //    {
    //        _events.EventDetail();
    //    }


    //}

//}


//namespace ioc_di
//{

//    /// 
//    ///Dependancy injection - Company depends on events
//    ///Method injection
//    /// 

//    public class Company
//    {
//        private IEvent _events = null;
//        

//        public void GetEvents(IEvent ie)
//        {
//           ie.EventDetail();
//        }
//    }

//}



