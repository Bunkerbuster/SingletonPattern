using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singelton
{
    public class MySingleton
    {
        private static MySingleton Instance = new MySingleton();

        private MySingleton() { }

        public static MySingleton Instance2
        {
            get { return Instance; }
        }

        public void DoSomething()
        {
            Console.WriteLine("Singleton class has been called");
        }

    }
}
