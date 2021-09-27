using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app6._0
{
    // Интерфейс может содержать
    // методы и свойства, но не поля
    interface IPegasus : IBird, IHorse
    {
        public new void Chirp()
        {
            this.Whinny();
        }
    }
}
