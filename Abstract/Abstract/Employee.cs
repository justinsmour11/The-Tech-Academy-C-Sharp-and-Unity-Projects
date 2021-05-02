using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public class Employee<T> : Person, IQuittable
    {

        public override void SayName()
        {
            Console.WriteLine("{0} {1}", firstName, lastName);
        }
        public void Quit()
        {
            Console.WriteLine("{0} {1} quits the game", firstName, lastName);
        }

        //public static bool operator ==(Employee emp1, Employee emp2)
        //{
        //    if (emp1.EmpID == emp2.EmpID)
        //    {
        //        return true;
        //    }
        //    return false;
        //}

        //public static bool operator !=(Employee emp1, Employee emp2)
        //{
        //    if (emp1.EmpID != emp2.EmpID)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        public int EmpID { get; set; }
        public List<T> things { get; set; }


    }
}
