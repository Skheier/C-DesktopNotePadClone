using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;

namespace NotePad
{
    public partial class Localizar : Form
    {
        public Localizar()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e) //Botão cancelar
        {
            this.Close();
        }

        private void btnSubstitui_Click(object sender, EventArgs e) //Botão Localizar
        {
            String busca = txtBxLocaliza.Text; // Declaração das variáveis 
            String texto = ((Form1)this.Owner).rchTxtBxContent.Text;
            RichTextBoxFinds regra = RichTextBoxFinds.None; 

            if(chckBxCaseSensitive.Checked == true)
            {
                regra = RichTextBoxFinds.MatchCase;
            }
            if (chckBxPalavraInteira.Checked == true)
            {
                regra = RichTextBoxFinds.WholeWord;
            }
            int index = 0;

            while (index < ((Form1)this.Owner).rchTxtBxContent.Text.LastIndexOf(busca))
            {
                ((Form1)this.Owner).rchTxtBxContent.Find(busca, index, texto.Length, regra); //Linha que efetivamente faz a busca.
                ((Form1)this.Owner).rchTxtBxContent.SelectionBackColor = Color.Lime;
                index = ((Form1)this.Owner).rchTxtBxContent.Text.IndexOf(busca, index) + 1;
            }
            this.Close();
        }
    }
}
