using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практическая_работа__1_КИС
{

    public partial class Form1 : Form
    {
        public void DontTouch()
        {
            MessageBox.Show("Не трогай бобра!");
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCreateOtter(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxOtter.Text))
            {
                MessageBox.Show("Вы еще не дали выдре имя!", "Ой!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string otterName = textBoxOtter.Text;
                Otter otter = new Otter(otterName);
            }
        }

        private void pictureBoxBeaver1Click(object sender, EventArgs e)
        {
            DontTouch();
        }

        private void pictureBoxBeaver2Click(object sender, EventArgs e)
        {
            DontTouch();
        }

        private void pictureBoxBeaver3Click(object sender, EventArgs e)
        {
            DontTouch();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCreateCat(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCat.Text))
            {
                MessageBox.Show("Вы еще не дали кошке имя!","Ой!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string catName = textBoxCat.Text;
                Cat cat = new Cat(catName);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonClear(object sender, EventArgs e)
        {
            textBoxCat.Clear();
            textBoxOtter.Clear();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxCat.Clear();
            textBoxOtter.Clear();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Справка form2 = new Справка();
            form2.Show();
        }

        private void создатьКошкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCat.Text))
            {
                MessageBox.Show("Вы еще не дали кошке имя!", "Ой!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string catName = textBoxCat.Text;
                Cat cat = new Cat(catName);
            }
        }

        private void создатьВыдруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxOtter.Text))
            {
                MessageBox.Show("Вы еще не дали выдре имя!", "Ой!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string otterName = textBoxOtter.Text;
                Otter otter = new Otter(otterName);
            }
        }
    }
}
