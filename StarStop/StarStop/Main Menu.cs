using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarStop
{
    public partial class Form1 : Form
    {
        public Label[] days;

        public Label[] nights;

        public Form1()
        {
            InitializeComponent();

            days = new Label[] {mondayDay, tuesdayDay, wednesdayDay,
                   thursdayDay, fridayDay, SaturdayDay};

            nights = new Label[] {mondayNight, tuesdayNight, wednesdayNight,
                     thursdayNight, fridayNight, SaturdayNight};

        }

        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //addSemester
            Form2 addSemester = new Form2();
            addSemester.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //modifySemester
            Form3 modifySemester = new Form3();
            modifySemester.Show();
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        // Calculate button on-click event
        private void button2_Click(object sender, EventArgs e)
        {
            // Check if the user has selected a semester first
            if (mondayDay.Text != "-")
            {
                int classTime = 0;

            }
            else
            {
                //To-do: Add message to the user to select a valid semester.
                MessageBox.Show("Please Add Valid Semester Type");
            }
        }
    }
}
