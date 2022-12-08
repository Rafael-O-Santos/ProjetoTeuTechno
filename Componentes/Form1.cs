using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            int operador;
            string fruitas = "";

            operador = int.Parse(txtSelecione.Text);

            switch (operador)
            {
                case 1: fruitas = "Banana";
                    break;

                case 2: fruitas = "Maça";
                    break;

                case 3: fruitas = "Pera";
                    break;

                case 4: fruitas = "Melancia";
                    break;

                default: fruitas = "Nenhuma fruita selecionada.";
                    break;
            }
            txtFruitaSelecionadas.Text = fruitas;

            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // executar o método criado
            limparCampos();
        }
        //criar o método para limpar os componentes
        public void limparCampos()
        {
            txtFruitaSelecionadas.Clear();
            txtSelecione.Text = "";
            ltbFruitas.Items.Clear();
            cbbFruitasSelecionadas.Items.Clear();
            cbbFruitasSelecionadas.Text = "";

            txtSelecione.Focus();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            ltbFruitas.Items.Clear();
            ltbFruitas.Items.Add(txtFruitaSelecionadas.Text);
            cbbFruitasSelecionadas.Items.Add(txtFruitaSelecionadas.Text);    
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //formas de sair
            //Close();
            //this.Close();
            

            DialogResult res;

            res = MessageBox.Show("Deseja Sair?", "Menssagem do sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            if (res == DialogResult.Yes) 
            {
                Application.Exit();
            }
            else
            {
                limparCampos();
            }
        }

        private void txtSelecione_KeyDown(object sender, KeyEventArgs e)
        {
            txtFruitaSelecionadas.Focus();
            txtFruitaSelecionadas.Text = "";
            if (e.KeyCode == Keys.Enter)
            {
                btnSelecionar.Focus();
            }
        }
    }
}
