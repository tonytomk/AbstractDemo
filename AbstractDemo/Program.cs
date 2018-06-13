using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo
{
    abstract class Iphone
    {
        //Non-Abstract Method   
        public void Call()
        {
            Console.WriteLine("Call Method: This method provides Calling features");
        }
        //Abstract Method kept as Private   
        public abstract void Model();

        public abstract void Color();
    }

    class Iphone4 :Iphone
    {
        //Abstract Method Implementation   
        public override void Model()
        {
            Console.WriteLine("Model: The model of this iPhone is iPhone4");
        }

        public override void Color()
        {
            Console.WriteLine("Color: The Color of this iPhone is RED");
        }

        //Derived Class Local Method   
        public void LaunchDate()
        {
            Console.WriteLine("Launch Date: This iPhone was launched on 20- September-2013");
        }

    }

    class Program
    {
       
        static void Main(string[] args)
        {
            Iphone4 iphone4 = new Iphone4();
            iphone4.Call();
            iphone4.Model();
            iphone4.LaunchDate();
            Console.ReadKey();

        }
    }
}
