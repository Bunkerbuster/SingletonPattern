using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singelton
{
    public class MySingeltonLazyLoading
    {
        private static MySingeltonLazyLoading Instance = null;

        private MySingeltonLazyLoading() { }

        public static MySingeltonLazyLoading Instance2
        {
            get 
            {
                if(Instance == null)
                {
                    Instance = new MySingeltonLazyLoading();
                }
                return Instance; 
            }
        }

        public void DoSomething()
        {
            Console.WriteLine("Singleton class has been called");
        }

    }
}
