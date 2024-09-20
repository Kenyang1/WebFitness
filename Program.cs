namespace fitness
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new login());
        }
    }

    //M.D: Mimics the use of global variables and functions to use across all project files
    public static class Globals
    {
        public static nav navRef = new nav();
        public static string accFile = "AccountInfo.txt";
        public static string trackingFile = "TrackingInfo.txt";
        public static string waterTrackingFile = "WaterTracking.txt";
        public static string sleepTrackingFile = "SleepTracking.txt";
        public static string calorieTrackingFile = "CalorieTracking.txt";
        public static Account currentAcc = new Account();

        //M.D: Edits a specified line in a file
        public static void editLine(string filePath, int line, string newText)
        {
            string[] arrLine = File.ReadAllLines(filePath);
            arrLine[line - 1] = newText;
            File.WriteAllLines(filePath, arrLine);
        }

        //M.D: Returns the first empty line in a file, or 0 if no empty lines are found
        public static int findEmptyLine(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            for (int i=0; i<lines.Length; i++)
            {
                if (string.IsNullOrEmpty(lines[i])) { return i + 1; }
            }
            return 0;
        }

        //M.D: Returns true if a specified username is taken, false if it is available
        public static bool isUserTaken(string filePath, string user)
        {
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines) 
            {
                string[] accAttributes = line.Split(' ');
                if (accAttributes[0] == user) { return true; }
            }
            return false;
        }

        //M.D: Updates user info from given account to all text files
        public static void updateInfo(Account acc)
        {
            string[] lines = File.ReadAllLines(accFile);
            for (int i=0; i<lines.Length; i++)
            {
                string[] accAttributes = lines[i].Split(' ');
                if (accAttributes[0] == acc.UserName)
                {
                    editLine(accFile, i + 1, acc.ConvertToString());
                }
            }
            lines = File.ReadAllLines(trackingFile);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] accAttributes = lines[i].Split(' ');
                if (accAttributes[0] == acc.UserName)
                {
                    editLine(trackingFile, i + 1, acc.UserName + " " + acc.Wellness.ConvertToString());
                }
            }
            lines = File.ReadAllLines(waterTrackingFile);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] accAttributes = lines[i].Split(' ');
                if (accAttributes[0] == acc.UserName)
                {
                    string line = acc.UserName;
                    if (acc.Wellness.WaterTracking.Count >= 1)
                    {
                        line += " " + acc.Wellness.WaterTrackingString();
                    }
                    editLine(waterTrackingFile, i + 1, line);
                }
            }
            lines = File.ReadAllLines(sleepTrackingFile);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] accAttributes = lines[i].Split(' ');
                if (accAttributes[0] == acc.UserName)
                {
                    string line = acc.UserName;
                    if (acc.Wellness.SleepTracking.Count >= 1)
                    {
                        line += " " + acc.Wellness.SleepTrackingString();
                    }
                    editLine(sleepTrackingFile, i + 1, line);
                }
            }
            lines = File.ReadAllLines(calorieTrackingFile);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] accAttributes = lines[i].Split(' ');
                if (accAttributes[0] == acc.UserName)
                {
                    string line = acc.UserName;
                    if (acc.Wellness.CalorieTracking.Count >= 1)
                    {
                        line += " " + acc.Wellness.CalorieTrackingString();
                    }
                    editLine(calorieTrackingFile, i + 1, line);
                }
            }
        }


        //M.D: Returns true if username matches password in text file, false if not
        public static bool validLogin(string filePath, string user, string pass)
        {
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] accAttributes = line.Split(' ');
                if (accAttributes[0] == user && accAttributes[1] == pass) 
                { 
                    return true;  
                }
            }
            return false;
        }

        //M.D: Returns account with given username from text file
        public static Account onloadAccount(string user)
        {
            Account acc = new Account();
            string[] lines = File.ReadAllLines(accFile);
            foreach (string line in lines)
            {
                string[] accAttributes = line.Split(' ');
                if (accAttributes[0] == user)
                {
                    //Account members
                    acc.UserName = accAttributes[0];
                    acc.Password = accAttributes[1];
                    acc.Age = Int32.Parse(accAttributes[2]);
                    acc.Height = Int32.Parse(accAttributes[3]);
                    acc.Gender = bool.Parse(accAttributes[4]);
                    acc.FilePath = accAttributes[5];

                    lines = File.ReadAllLines(trackingFile);
                    foreach (string l in lines)
                    {
                        accAttributes = l.Split(' ');
                        if (accAttributes[0] == user)
                        {
                            //Tracking members
                            acc.Wellness.WaterIntake = Int32.Parse(accAttributes[1]);
                            acc.Wellness.WaterIntakeGoal = Int32.Parse(accAttributes[2]);
                            acc.Wellness.AmountSleep = Int32.Parse(accAttributes[3]);
                            acc.Wellness.AmountSleepGoal = Int32.Parse(accAttributes[4]);
                            acc.Wellness.CalorieIntake = Int32.Parse(accAttributes[5]);
                            acc.Wellness.CalorieIntakeGoal = Int32.Parse(accAttributes[6]);
                            acc.Wellness.Weight = float.Parse(accAttributes[7]);
                            acc.Wellness.WeightGoal = float.Parse(accAttributes[8]);
                            acc.Wellness.Exercise = Int32.Parse(accAttributes[9]);
                            acc.Wellness.ExerciseGoal = Int32.Parse(accAttributes[10]);

                            lines = File.ReadAllLines(waterTrackingFile);
                            foreach (string l1 in lines)
                            {
                                accAttributes = l1.Split(' ');
                                if (accAttributes[0] == user)
                                {
                                    for (int i = 1; i < accAttributes.Length; i++)
                                    {
                                        acc.Wellness.WaterTracking.Add(Int32.Parse(accAttributes[i]));
                                    }
                                    lines = File.ReadAllLines(sleepTrackingFile);
                                    foreach (string l2 in lines)
                                    {
                                        accAttributes = l2.Split(' ');
                                        if (accAttributes[0] == user)
                                        {
                                            for (int i = 1; i < accAttributes.Length; i++)
                                            {
                                                acc.Wellness.SleepTracking.Add(accAttributes[i]);
                                            }

                                            lines = File.ReadAllLines(calorieTrackingFile);
                                            foreach (string l3 in lines)
                                            {
                                                accAttributes = l3.Split(' ');
                                                if (accAttributes[0] == user)
                                                {
                                                    for (int i = 1; i < accAttributes.Length; i++)
                                                    {
                                                        acc.Wellness.CalorieTracking.Add(Int32.Parse(accAttributes[i]));
                                                    }
                                                    return acc;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return acc;
        }
    }
}