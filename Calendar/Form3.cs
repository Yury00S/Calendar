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

        //private string[] Info = new string[3];

        //public string[] Informations { get
        //    {

        //        return  textBox1.Text, dateTimePicker1.Value.ToString("dd.MM.yyyy"), textBox2.Text
        //    }
        //}


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

        //если текст есть - кнопка активна, иначе нет
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0) button1.Enabled= true;
            else button1.Enabled= false;
        }
    }
}
