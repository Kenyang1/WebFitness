using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//All written by K.L
namespace fitness
{
    public partial class formSleep : Form
    {
        Account acc = Globals.currentAcc;
        public formSleep()
        {
            InitializeComponent();
            dateSleptPicker.Value = DateTime.Now.AddDays(-1); //Yesterday
            dateWakeUpPicker.Value = DateTime.Now; //Today

            //M.D: Add previous entries to table
            for (int i=0; i<acc.Wellness.SleepTracking.Count; i+=2)
            {
                string dateSlept = acc.Wellness.SleepTracking[i];
                ListViewItem newitem = new ListViewItem(dateSlept);
                newitem.SubItems.Add(DateTime.Parse(dateSlept).AddDays(1).ToString().Split(' ')[0]);
                newitem.SubItems.Add(((int)(float.Parse(acc.Wellness.SleepTracking[i+1]) / 60)).ToString());
                sleepLog.Items.Add(newitem);
            }
            
        }

        private void formSleep_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            sleepLog.Columns.Add("Date Slept:", 300);
            sleepLog.Columns.Add("Date Woken Up:", 300);
            sleepLog.Columns.Add("Hours Slept:", 300);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            //K.L: Add entry to listview
            ListViewItem newitem = new ListViewItem(dateSleptPicker.Value.ToString().Split(' ')[0]);
            newitem.SubItems.Add(dateWakeUpPicker.Value.ToString());
            newitem.SubItems.Add(hoursSleptText.Text);
            sleepLog.Items.Add(newitem);

            //M.D: Add to SleepTracking list
            acc.Wellness.SleepTracking.Add(dateSleptPicker.Value.ToString().Split(' ')[0]);
            acc.Wellness.SleepTracking.Add(((int)(((float.Parse(hoursSleptText.Text)) * 60))).ToString());
            Globals.updateInfo(acc);
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            dateSleptPicker.Value = DateTime.Now.AddDays(-1); //Yesterday
            dateWakeUpPicker.Value = DateTime.Now; //Today
            hoursSleptText.Text = "";
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            if (sleepLog.SelectedItems.Count > 0)
            {
                // Convert the string to DateTime before assigning
                if (DateTime.TryParse(sleepLog.SelectedItems[0].SubItems[0].Text, out DateTime selectedDate))
                {
                    dateSleptPicker.Value = selectedDate;
                }
                else if (DateTime.TryParse(sleepLog.SelectedItems[0].SubItems[1].Text, out DateTime selectedDate2)) // Rename to selectedDate2
                {
                    dateWakeUpPicker.Value = selectedDate2;
                }

                hoursSleptText.Text = sleepLog.SelectedItems[0].SubItems[2].Text;
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (sleepLog.SelectedItems.Count > 0)
            {
                sleepLog.SelectedItems[0].SubItems[0].Text = dateSleptPicker.Value.ToString();
                sleepLog.SelectedItems[0].SubItems[1].Text = dateWakeUpPicker.Value.ToString();
                sleepLog.SelectedItems[0].SubItems[2].Text = hoursSleptText.Text;
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (sleepLog.SelectedItems.Count > 0)
            {
                sleepLog.Items.Remove(sleepLog.SelectedItems[0]);

            }
        }

        private void removeAllBtn_Click(object sender, EventArgs e)
        {
            sleepLog.Items.Clear();
        }
    }
}
