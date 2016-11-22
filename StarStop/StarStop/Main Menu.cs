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

        private void button4_Click(object sender, EventArgs e)
        {
            //Manage Classes
            Form4 manageClasses = new Form4();
            manageClasses.Show();
        }
    }
}
