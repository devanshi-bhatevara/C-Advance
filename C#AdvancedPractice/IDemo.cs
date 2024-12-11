using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_AdvancedPractice
{
    public interface IDemo : IDemo1
    {
        void Display();
    }

    public interface IDemo1
    {
        void Display1();
    }

    public class Demo : IDemo
    {
        public void Display()
        {
            throw new NotImplementedException();
        }

        public void Display1()
        {
            throw new NotImplementedException();
        }
    }

    public abstract class Demo2 : IDemo
    {
        public abstract void Display(); //either mark it abstract or implement it

        public void Display1()
        {
            throw new NotImplementedException();
        }
    }
}
