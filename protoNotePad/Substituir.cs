using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NotePad
{
    public partial class Substituir : Form
    {
        public Substituir()
        {
            InitializeComponent();
        }

        private void substituir_Load(object sender, EventArgs e)
        {

        }

        private void txtBxSubstitui_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnSubstitui_Click(object sender, EventArgs e) //Botão substituir
        {
            String busca = txtBxLocaliza.Text;  //Declaração das variaveis nescessárias
            String nova = txtBxSubstitui.Text;
            String texto = ((Form1)this.Owner).rchTxtBxContent.Text;

            ((Form1)this.Owner).rchTxtBxContent.Text = texto.Replace(busca, nova);

            this.Close();
        }
        private void btnCancelar_Click(object sender, EventArgs e) //Botão cancelar
        {
            this.Close();
        }
    }
}
