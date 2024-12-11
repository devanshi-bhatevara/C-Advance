using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_AdvancedPractice.Tasks
{
    public class Locks
    {
        private object _lock = new object(); //without locks it will behave undeterministicly, can be any reference type
        public int Value { get; private set; }
        public void Increment()
        {
            lock (_lock)
            {
                Value++;
            }
        }
        
        public void Decrement()
        {
            lock (_lock)
            {
                Value--;
            }
        }
    }
}
