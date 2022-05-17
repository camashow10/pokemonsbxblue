using Pokemon_Matheus.NovaPasta;
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
    public partial class Form3 : Form
    {
        ApiRequest api = new ApiRequest();

        public Form3()
        {
            InitializeComponent();
        }
        public Form3(string valor, string num)
        {
            InitializeComponent();
            label1.Text = valor;
            label3.Text = num;
            
            
        }

        public void dados()
        {
            PokeLista pokemon = new PokeLista();

            pokemon = api.ObterLista();

            foreach (var item in pokemon.Listapokemons)
            {
                flowLayoutPanel1.Controls.Add(new PokeVisual(item.NomePokemon, item.GetImagen()));
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
