using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_wokr_8
{
    public class Dog : Animal
    {

        // Реализация абстрактного метода Eat
        public override void Eat()
        {
            Console.WriteLine("Dog is eating.");
        }
    }
}
