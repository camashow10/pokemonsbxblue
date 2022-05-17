using Pokemon_Matheus.Modelo;
using Pokemon_Matheus.NovaPasta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon_Matheus
{
    public partial class PokeVisual : UserControl
    {
        ApiRequest api = new ApiRequest();
        string num;

        public PokeVisual(string nome , Image imagem)
        {
            InitializeComponent();
            this.nome.Text = nome;
            this.imagem.Image = imagem;
            
        }
        

        private void PokeVisual_Load(object sender, EventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 formdestino = new Form3(nome.Text, num);
            formdestino.Show();
        }
    }
}
