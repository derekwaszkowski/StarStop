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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            holidayList = new List<DateTime>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string holiday = textBox1.Text + " - " + dateTimePicker1.Text;

            listBox1.Items.Add(holiday);
            holidayList.Add(dateTimePicker1.Value.Date);


            //clear data in textbox
            textBox1.Clear();
            
        }

        public List<DateTime> holidayList;

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
