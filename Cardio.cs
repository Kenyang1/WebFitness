using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//All written by M.D
namespace fitness
{
    internal class Cardio : exerciseClass
    {
        private
           int mDuration; //Seconds
        int mDistance; //Meters

        public Cardio() : base()
        {
            Duration = 0;
            Distance = 0;
        }

        public Cardio(string name, int duration, int distance)
        {
            ExcName = name;
            Duration = duration;
            Distance = distance;
        }

        //Getters and setters
        public int Duration
        {
            get { return mDuration; }
            set
            {
                //Duration cannot be negative
                if (value > 0) { mDuration = value; }
                else { mDuration = 0; }
            }
        }
        public int Distance
        {
            get { return mDistance; }
            set
            {
                //Distance cannot be negative
                if (value > 0) { mDistance = value; }
                else { mDistance = 0; }
            }
        }
    }
}
