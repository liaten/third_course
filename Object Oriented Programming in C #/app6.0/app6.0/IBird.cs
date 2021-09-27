using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app6._0
{
    interface IBird
    {
        // Интерфейс может содержать
        // методы и свойства, но не поля
        public virtual void Chirp()
        {
            Console.WriteLine("Chirp..");
        }
        public virtual void Fly()
        {
            Console.WriteLine("I can fly!");
        }
    }
}
