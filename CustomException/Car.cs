using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    class Car
    {
        //field variable
        public const int MaxSpeed = 50;
        private bool CarIsDead;//is the car dead
        // properties
        public int CurrSpeed { get; set; } = 0;
        public string PetName { get; set; } = "";
        //constructors
        public Car()
        {

        }
        public Car(string name,int speed)
        {
            PetName = name;
            CurrSpeed = speed;
        }

        // this Car has a Radio(containment/delegation-inheritance)
      private  Radio carRadio = new Radio();

       //methods
       public void CrankTunes(bool state)
        {
            //delegate request to  inner object
            carRadio.RadioOn(state);
        }
        // throw the custom carIsdeadException
        public void Accelerate(int delta)
        {
            
                    CarIsDeadException ex=
                     new CarIsDeadException($"{PetName} has overheated","You have a lead foot",
                     DateTime.Now);
                    ex.HelpLink = "http://www.CarRUs.com";

                    
                    throw ex;
                     
             
        }
    }
}
