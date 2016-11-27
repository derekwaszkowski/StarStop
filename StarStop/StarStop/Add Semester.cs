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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string semester = semesterType.Text + " - " + 
                startDate.Text + " - " + endDate.Text;

            listBox.Items.Add(semester);

            DayUtility.updateDays(startDate.Value, endDate.Value, new List<DateTime>());


            //hide form upon button click
            this.Hide();
        }
    }
}
