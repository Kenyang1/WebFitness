using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//All written by M.D
namespace fitness
{
    internal class exerciseClass
    {
        
            protected
            string mExcName;
            string mExcDate;
            string mExcTime;
            int mCalsBurned;

        public exerciseClass()
        {
            mExcName = "BLANK";

            string date = DateTime.Now.ToString();
            mExcDate = date.Split(' ')[0];
            mExcTime = date.Split(' ')[1];

            mCalsBurned = 0;
        }

        public exerciseClass(string excName)
        {
            mExcName = excName;

            string date = DateTime.Now.ToString();
            mExcDate = date.Split(' ')[0];
            mExcTime = date.Split(' ')[1];

            mCalsBurned = 0;
        }

        //Getters and setters
        public string ExcName
        {
            get { return mExcName; }
            set 
            {
                //Name cannot be null
                if (value != null) { mExcName = value; }
                else { mExcName = "BLANK"; }
            }
        }
        public string ExcDate
        {
            get { return mExcDate; }
        }
        public string ExcTime
        {
            get { return mExcTime; }
        }
        public int CalsBurned
        {
            get { return mCalsBurned; }
            set 
            {
                //Calories burned cannot be negative
                if (value > 0) { mCalsBurned = value; }
                else { mCalsBurned = 0; }
            }
        } 
    }
}
