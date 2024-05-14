using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryLibrary.library
{
    public class Toyota : Car
    {
        public override void Accelerate()
        {
            velocity += 5;
        }
        public Toyota()
        {
            CarType = CarTypes.Toyota;
        }

        public void ThrowException()
        {
            throw new InvalidOperationException();

        }
    }
}
