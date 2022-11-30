using System;
using System.Collections.Generic;
using System.Text;

namespace Coupling
{
    //tight coupling
    public class Owner
    {
        public void start() {
            Console.WriteLine("started the car");
        }
        public void drive() {
            Console.WriteLine("driving the car");
        }
        public void stop() {
            Console.WriteLine("stopped the car");
        }

    }
    public class BMW
    {
        Owner Owner = new Owner();

        public void StartBMW() {
            Owner.start();
        }
    }
    public class RR
    {
        Owner Owner = new Owner();
    }
    public class Ambassador
    {
        Owner Owner = new Owner();
    }

}
//if owner decides to rum BMW (code in program.cs)