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
    public partial class ImageBox : Form
    {
        public ImageBox()
        {
            InitializeComponent();
        }

        private void ImageBox_Load(object sender, EventArgs e)
        {
            if(opnFlDlgImage.ShowDialog() == DialogResult.OK)
            {
                this.Text = opnFlDlgImage.FileName;
                Image ImagemEscolhida = Image.FromFile(opnFlDlgImage.FileName);
                pctrBxImagem.Image = ImagemEscolhida;
            }
            else
            {
                this.Close();
            }
        }
    }
}
