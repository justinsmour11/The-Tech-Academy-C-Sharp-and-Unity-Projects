using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public class Employee : Person, IQuittable
    {

        public override void SayName()
        {
            Console.WriteLine("{0} {1}", firstName, lastName);
        }
        public void Quit()
        {
            Console.WriteLine("{0} {1} quits the game", firstName, lastName);
        }
    }
}
