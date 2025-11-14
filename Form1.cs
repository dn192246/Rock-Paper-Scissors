using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void Jugar(string usuario)
        {
            Random aleatorio = new Random();
            int numero = aleatorio.Next(1, 3);
            string maquina = "";

            if (numero == 1) 
            {
                maquina = "Piedra";
                lbMaquina.Text = "Piedra";
            }
            
            if (numero == 2)
            {
                maquina = "Papel"; 
                lbMaquina.Text = "Papel";
            }

            if (numero == 3) 
            {
                maquina = "Tijeras";
                lbMaquina.Text = "Tijeras";
            } 

            if (usuario == maquina)
            {
                lbResultado.Text = "Empate";
            }

            else if (usuario == "Piedra" && maquina == "Tijeras" ||
                     usuario == "Papel" && maquina == "Piedra" ||
                     usuario == "Tijeras" && maquina == "Papel")
            {
                lbResultado.Text = "Ganaste";
            }

            else
            {
                lbResultado.Text = "Perdiste";
            }
        }

        private void btnTijera_Click(object sender, EventArgs e)
        {
            Jugar("Tijeras");
        }

        private void btnPiedra_Click(object sender, EventArgs e)
        {
            Jugar("Piedra");
        }

        private void btnPapel_Click(object sender, EventArgs e)
        {
            Jugar("Papel");
        }
    }
}
