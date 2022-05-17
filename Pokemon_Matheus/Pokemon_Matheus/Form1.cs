using Pokemon_Matheus.Modelo;
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
    public partial class Form1 : Form
    {
        ApiRequest api = new ApiRequest();
        Thread nt;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = "R$" + "300.000,00";
            carregardados();
        }

        public void carregardados()
        { 
            flowLayoutPanel1.Controls.Clear();

            PokeLista pokemon = new PokeLista();

            pokemon = api.ObterLista();

            foreach (var item in pokemon.Listapokemons)
            {
                flowLayoutPanel1.Controls.Add(new PokeVisual(item.NomePokemon, item.GetImagen()));
            }

        
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            nt = new Thread(novoform);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void novoform(object? obj)
        {
            Application.Run(new Form3());
        }
    }
}
