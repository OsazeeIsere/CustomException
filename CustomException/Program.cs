using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("fun with custom exception");
            Car myCar = new Car("Bitto", 90);
            try
            {
                //trip exception
                myCar.Accelerate(50);

            }
            catch(CarIsDeadException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.CauseOfError);
                Console.WriteLine(e.ErrorTimeStamp);

            }
            Console.ReadLine();

        }
    }
}
