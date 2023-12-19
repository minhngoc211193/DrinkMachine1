using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkMachineLibrary
{
    public class CleanMachine: Cleanser
    {
        public int Time {  get; set; }
        public int Section;

        public CleanMachine() 
        { 
            Time = 0;
        }
        public string CleanMachine1(int section)
        {
            this.Section = section;
            this.CleanForMachine(500);
            for(int i=0; i<=section; i++)
            {
                 Console.Write("Turn left");
            }
            for (int i = 0; i<=section; i++)
            {
                Console.Write("Turn right");
            }
            return $"CleanMachine turn left " + section+ " time and turn right " +section+ " time";
        }
    }
}
