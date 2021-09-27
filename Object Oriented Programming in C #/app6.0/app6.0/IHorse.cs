using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app6._0
{
    interface IHorse
    {
        // Интерфейс может содержать
        // методы и свойства, но не поля
        public virtual void Whinny()
        {
            Console.WriteLine("Whinny...");
        }
    }
}
