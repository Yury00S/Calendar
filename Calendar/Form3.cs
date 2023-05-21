using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        //см видео 16.04.23 59:05
        public string Name_Text
        {
            get
            {
                return textBox1.Text;
            }
        }

        public string Date_Text
        {
            get
            {
                return dateTimePicker1.Value.ToString("dd.MM.yyyy"); //???
            }
        }

        public string Info_Text
        {
            get
            {
                return textBox2.Text;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
