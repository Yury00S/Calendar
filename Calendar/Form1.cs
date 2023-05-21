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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 about_program = new Form2();
            about_program.ShowDialog();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 add = new Form3();
            add.ShowDialog();
            /* коряво но работает
             Items содержит коллекцию ListViewItem (это как раз столбцы на форме).
            Нам же нужно обратиться к этим столбцам и добавить в них информацию.
            Т.е. нужны подстолбцы (SubItems). И уже в них занести массив
            непонятно как?...

             Прописать логическую цепочку listView.Items.SubItem.AddRange()
             */
            string[] arr = new string[4];
            arr[0]=null;
            arr[1]=add.Name_Text;
            arr[2]=add.Date_Text;
            arr[3]=add.Info_Text;
            ListViewItem item;
            item=new ListViewItem(arr);
            listView1.Items.Add(item);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            { 
                label3.Text=$"Наименование: {item.SubItems[1].Text}\n" +
                            $"Дата выполнения: {item.SubItems[2].Text}\n" +
                            $"Описание:  {item.SubItems[3].Text}\n\n" +
                            $"Статус задачи: {(item.Checked? "выполнено" : "не выполнено")}";

            }
        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {
            
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
