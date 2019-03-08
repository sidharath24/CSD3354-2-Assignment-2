using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExcercise
{
    public class DelegrateExcercise
    {
        static void Main(string[] args) => MyDelegate.Method1();

        public delegate void MyDelegate();
        void Method1()
        {
            Console.WriteLine("Method 1");
            Console.ReadLine();
        }
        public void Method2()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            myDelegate();
        }
    }
}
