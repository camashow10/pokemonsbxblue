using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon_Matheus
{
    public partial class Form2 : Form
    {
        Thread nt;
        static void Main(string[] args)
        {
            Application.Run(new Form2());
        }
        public Form2()
        {       
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "Matheus" && textBox2.Text == "Camacho")
            {
                MessageBox.Show("BEM VINDO A SUA POKÉDEX MATHEUS!!!");
                this.Close();
                nt = new Thread(novoform);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
            }
            else
            {
                MessageBox.Show("Login incorreto!");
            }
        }

        private void novoform(object? obj)
        {
            Application.Run(new Form1());
        }

    }
}
