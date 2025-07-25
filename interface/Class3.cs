using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @interface
{
    public class Class3:Class1,Class2
    {
        public void method1(int a,int d)
        {
            int sum = a + d;
            Console.WriteLine(sum);

        }
        public void method2()
        {
            Console.WriteLine("this is method 2");
        }
        public void method3()
        {
            Console.WriteLine("this is mehtod 3");
        }
        public void method4()
        {
            Console.WriteLine("this is mehtod 4");
        }


    }
}
