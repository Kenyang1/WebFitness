using Calorie_Tracker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Calorie_Tracker.formCalDefCalculator;

//All written by M.D
namespace fitness
{
    public class Tracking
    {
        //Wellness tracking and goals
        private int mWaterIntake;
        private int mWaterIntakeGoal;
        private int mCalorieIntake;
        private int mCalorieIntakeGoal;
        private int mAmountSleep;
        private int mAmountSleepGoal;
        private float mWeight;
        private float mWeightGoal;
        private int mExercise;
        private int mExerciseGoal;
        private List<int> mWaterTracking = new List<int>();
        private List<string> mSleepTracking = new List<string>();
        private List<int> mCalorieTracking = new List<int>();

        //Default dummy values
        public Tracking()
        {
            mCalorieIntake = 0;
            mCalorieIntakeGoal = 0;

            //Milliliters
            mWaterIntake = 0;
            mWaterIntakeGoal = 0;

            //Minutes
            mAmountSleep = 0;
            mAmountSleepGoal = 0;
            mExercise = 0;
            mExerciseGoal = 0;

            //Kilograms
            mWeight = 0;
            mWeightGoal = mWeight;
        }

        //Initialize with age and gender to set reccomended goals
        public Tracking(int age, bool gender)
        {
            mWaterIntake = 0;
            mCalorieIntake = 0;
            mCalorieIntakeGoal = 2000;
            mAmountSleep = 0;
            mWeight = 0;
            mWeightGoal = mWeight;
            mExercise = 0;


            //Adult
            if (age >= 18)
            {
                mAmountSleepGoal = 7 * 60; //7 hours
                mExerciseGoal = 20;
            }
            //Child
            else
            {
                mAmountSleepGoal = 9 * 60; //9 hours
                mExerciseGoal = 60;
            }

            //Female
            if (gender)
            {
                mWaterIntakeGoal = 2200; 
            }
            //Male
            else
            {
                mWaterIntakeGoal = 3000;
            }
        }

        //Setters and getters
        public int WaterIntake
        {
            get { return mWaterIntake; } 
            set { mWaterIntake=value; }
        }
        public int WaterIntakeGoal
        {
            get { return mWaterIntakeGoal; }
            set { mWaterIntakeGoal = value; }
        }
        public int AmountSleep
        {
            get { return mAmountSleep; }
            set { mAmountSleep = value; }
        }
        public int AmountSleepGoal
        {
            get { return mAmountSleepGoal; }
            set { mAmountSleepGoal = value; }
        }
        public int CalorieIntake
        {
            get { return mCalorieIntake; }
            set { mCalorieIntake = value; }
        }
        public int CalorieIntakeGoal
        {
            get { return mCalorieIntakeGoal; }
            set { mCalorieIntakeGoal = value; }
        }
        public float Weight
        {
            get { return mWeight; }
            set { mWeight = value; }
        }
        public float WeightGoal
        {
            get { return mWeightGoal; }
            set { mWeightGoal = value; }
        }
        public int Exercise
        {
            get { return mExercise; }
            set { mExercise = value; }
        }
        public int ExerciseGoal
        {
            get { return mExerciseGoal; }
            set { mExerciseGoal = value; }
        }
        public List<int> WaterTracking
        {
            get { return mWaterTracking; }
            set { mWaterTracking = value; }
        }
        public List<string> SleepTracking
        {
            get { return mSleepTracking; }
            set { mSleepTracking = value; }
        }
        public List<int> CalorieTracking
        {
            get { return mCalorieTracking; }
            set { mCalorieTracking = value; }
        }

        public int AverageWater
        {
            //Returns average daily water intake in ounces
            get
            {
                int total = 0;
                foreach (int day in mWaterTracking)
                {
                    total += day;
                }
                if (mWaterTracking.Count > 0)
                {
                    return total / mWaterTracking.Count;
                }
                else { return 0; }
            }
        }
        public int AverageSleep
        {
            //Returns average daily sleep in minutes
            get
            {
                int total = 0;
                for (int i=1; i< mSleepTracking.Count; i+=2)
                {
                    total += Int32.Parse(mSleepTracking[i]);
                }
                if (mSleepTracking.Count > 0)
                {
                    return (int)(total / (0.5 * mSleepTracking.Count));
                }
                else { return 0; }
            }
        }
        public int AverageCalories
        {
            //Returns average daily calorie intake
            get
            {
                int total = 0;
                foreach (int day in mCalorieTracking)
                {
                    total += day;
                }
                if (mCalorieTracking.Count > 0)
                {
                    return total / mCalorieTracking.Count;
                }
                else { return 0; }
            }
        }

        //Converts tracking information to a string
        public string ConvertToString()
        {
            var str = new StringBuilder();
            str.Append(mWaterIntake + " ");
            str.Append(mWaterIntakeGoal + " ");
            str.Append(mAmountSleep + " ");
            str.Append(mAmountSleepGoal + " ");
            str.Append(mCalorieIntake + " ");
            str.Append(mCalorieIntakeGoal + " ");
            str.Append(mWeight + " ");
            str.Append(mWeightGoal + " ");
            str.Append(mExercise + " ");
            str.Append(mExerciseGoal + " ");
            return str.ToString();
        }

        //Converts a list of past daily water intakes to a string
        public string WaterTrackingString()
        {
            var str = new StringBuilder();
            for (int i=0; i<mWaterTracking.Count; i++)
            {
                str.Append(mWaterTracking[i]);
                if (i < mWaterTracking.Count - 1)
                {
                    str.Append(" ");
                }
            }
            return str.ToString();
        }

        //Converts a list of past sleep entries and their dates to a string
        public string SleepTrackingString()
        {
            var str = new StringBuilder();
            for (int i = 0; i < mSleepTracking.Count; i++)
            {
                str.Append(SleepTracking[i]);
                if (i < mSleepTracking.Count - 1)
                {
                    str.Append(" ");
                }
            }
            return str.ToString();
        }

        //Converts a list of past daily water intakes to a string
        public string CalorieTrackingString()
        {
            var str = new StringBuilder();
            for (int i = 0; i < mCalorieTracking.Count; i++)
            {
                str.Append(mCalorieTracking[i]);
                if (i < mCalorieTracking.Count - 1)
                {
                    str.Append(" ");
                }
            }
            return str.ToString();
        }
    }
}
