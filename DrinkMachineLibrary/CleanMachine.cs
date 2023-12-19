using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkMachineLibrary
{
    public class CleanMachine
    {
        public int Section;
        private bool TurnOn = false;
        private int Water;
        public CleanMachine() 
        { 
            TurnOn  = false;
            Section = 0;
            Water = 0;
        }
        public bool On()
        {
            TurnOn= true;
            return TurnOn;
        }
        public string CleanForMachine(int water)
        {
            this.On();
            this.Water = water;
            return $"Bump " + water + " ml water into DrinkMachine";
        }
        public string CleanMachine1(int section)
        {
            this.Section = section;
            this.CleanForMachine(500);
            for(int i=0; i<=section; i++)
            {
                 Console.Write("Turn left =>");
            }
            for (int i = 0; i<=section; i++)
            {
                Console.Write(" Turn right =>");
            }
            return $" CleanMachine turn left " + section+ " time and turn right " +section+ " time";
        }
        public bool Off()
        {
            TurnOn= false;
            Section = 0;
            return TurnOn;
        }
    }
}
