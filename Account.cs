using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Configuration;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace fitness
{
    
    public class Account
    {
        public static string defaultPfpPath = "defaultPfp.jpg";

        //Account information
        private string mUserName;
        private string mPassword;
        private string mfilePath;
        private int mAge; //Years
        private int mHeight; //Centimeters
        private double mBMI;
        private bool mGender; //false = male, true = female
        private string mGenderString;
        private Tracking mWellness;

        //Default dummy values
        public Account()
        {
            UserName = "BLANK";
            Age = 0;
            Gender = false; //Male
            mWellness = new Tracking(Age, Gender);
            Height = 0;       
        }

        //Initialize with all known values
        public Account(string userName, string password, int age, int height, bool gender)
        {
            UserName = userName;
            Password = password;
            Age = age;
            Gender = gender;
            mWellness = new Tracking(Age, Gender);
            Height = height;
            FilePath = defaultPfpPath;
        }

        //Getters and setters
        public string UserName
        {
            get { return mUserName; }
            set
            {
                //Username cannot be blank
                if (string.IsNullOrWhiteSpace(value))
                {
                    mUserName = "BLANK";
                }
                else { mUserName = value; }
            }
        }
        public string Password
        {
            get { return mPassword; }
            set
            {
                //Password cannot be blank
                if (string.IsNullOrWhiteSpace(value))
                {
                    mPassword = "BLANK";
                }
                else { mPassword = value; }
            }
        }
        public string FilePath
        {
            get { return mfilePath; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    mfilePath = defaultPfpPath;
                }
                else
                {
                    mfilePath = value;
                }
            }
        }

        public int Age
        {
            get { return mAge; }
            set
            {
                //Age cannot be negative
                if (mAge < 0)
                {
                    mAge = 0;
                }
                else { mAge = value; }
            }
        }
        public int Height
        {
            get { return mHeight; }
            set
            {
                //Height cannot be negative
                if (value > 0) 
                {
                    mHeight = value;
                    if (Wellness.Weight > 0)
                    {
                        mBMI = (Wellness.Weight / Math.Pow(mHeight, 2)) * 10000; //Update BMI
                    }
                    else { mBMI = 0; }
                    
                }
                else { mHeight = 0; }
            }
        }
        public double BMI
        {
            //mBMI is read only
            get { return mBMI; }
        }
        public bool Gender
        {
            get { return mGender; }
            set 
            {
                mGender = value;
                if (mGender) { mGenderString = "Female"; }
                else { mGenderString = "Male"; }
            }
        }
        public string GenderString
        {
            //mGenderString is read only
            get { return mGenderString; }
        }
        public Tracking Wellness
        {
            get { return mWellness; }
            set { mWellness = value; }
        }

        public string ConvertToString()
        {
            var str = new StringBuilder();
            str.Append(mUserName + " ");
            str.Append(mPassword + " ");
            str.Append(mAge.ToString() + " ");
            str.Append(mHeight.ToString() + " ");
            str.Append(mGender.ToString() + " ");
            str.Append(mfilePath); // Include the FilePath
            return str.ToString();
        }
    }
}
