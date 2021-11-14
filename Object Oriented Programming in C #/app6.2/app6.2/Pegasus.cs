using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app6._2
{
    public class Pegasus : Horse
    {
        public virtual void Fly()
        {
            Console.Write("I can fly!!\n");
        }
        ~Pegasus() { }
    }
}
