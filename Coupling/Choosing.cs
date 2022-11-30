using System;
using System.Collections.Generic;
using System.Text;

namespace Coupling
{
    public interface Choosing
    {
        public void start();
        public void drive();
        public void stop();
    }
    public class BMW : Choosing
    {
        
    }
}
