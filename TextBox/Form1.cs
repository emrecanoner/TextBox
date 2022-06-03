using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        decimal jethız = 10;
        decimal hamacmahız = 15;
        decimal ramhız = 25;
        decimal kalitekontrolhız = 40;
        decimal baskıhız = 50;
        decimal fiskehız = 75;



        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Metre Girmeyi Unutmayınız", "UYARI", MessageBoxButtons.OK);
            textBox5.Text = Convert.ToString(jethız + "m/dk");
            textBox7.Text = Convert.ToString(hamacmahız + "m/dk");
            textBox8.Text = Convert.ToString(ramhız + "m/dk");
            textBox9.Text = Convert.ToString(kalitekontrolhız + "m/dk");
            textBox10.Text = Convert.ToString(baskıhız + "m/dk");
            textBox11.Text = Convert.ToString(fiskehız + "m/dk");          
        }


        private void spinEdit4_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }
    }
}
