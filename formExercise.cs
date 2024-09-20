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
    public partial class formExercise : Form
    {
        public formExercise()
        {
            InitializeComponent();
        }

        private void formExercise_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            listView1.Columns.Add("Exercise Type", 300);
            listView1.Columns.Add("Time Duration", 300);
            listView1.Columns.Add("Date", 215);
            listView1.Columns.Add("Details", 300);

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            ListViewItem newitem = new ListViewItem(exerciseTypeText.Text);
            newitem.SubItems.Add(durationText.Text);
            newitem.SubItems.Add(dateTimePicker1.Value.ToString());
            newitem.SubItems.Add(additionalInfoText.Text);
            listView1.Items.Add(newitem);
        }



        private void newBtn_Click_1(object sender, EventArgs e)
        {
            exerciseTypeText.Text = "";
            durationText.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            additionalInfoText.Text = "";

        }

        private void listView1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                exerciseTypeText.Text = listView1.SelectedItems[0].SubItems[0].Text;
                durationText.Text = listView1.SelectedItems[0].SubItems[1].Text;

                // Convert the string to DateTime before assigning
                if (DateTime.TryParse(listView1.SelectedItems[0].SubItems[2].Text, out DateTime selectedDate))
                {
                    dateTimePicker1.Value = selectedDate;
                }

                additionalInfoText.Text = listView1.SelectedItems[0].SubItems[3].Text;
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.SelectedItems[0].SubItems[0].Text = exerciseTypeText.Text;
                listView1.SelectedItems[0].SubItems[1].Text = durationText.Text;

                // Assign dateTimePicker1.Value back to listView subitem
                listView1.SelectedItems[0].SubItems[2].Text = dateTimePicker1.Value.ToString();

                listView1.SelectedItems[0].SubItems[3].Text = additionalInfoText.Text;
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);

            }
        }

        private void removeAllBtn_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void workoutResourcesBtn_Click(object sender, EventArgs e)
        {
            formWorkoutPlans workoutPlans = new formWorkoutPlans();
            workoutPlans.Show();
        }

        private void workoutResourcesBtn2_Click(object sender, EventArgs e)
        {
            formWorkoutVideos workoutVideos = new formWorkoutVideos();
            workoutVideos.Show();
        }
    }
}

