using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NotePad
{
    public partial class Form1 : Form
    {
        bool alterado;
        int zoom = 100;

        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

        public Form1()
        {
            InitializeComponent();
            this.Location = new Point(Int32.Parse(config.AppSettings.Settings["windowPositionX"].Value),
                Int32.Parse(config.AppSettings.Settings["windowPositionY"].Value));
            this.Size = new Size(Int32.Parse(config.AppSettings.Settings["sizeW"].Value), 
                Int32.Parse(config.AppSettings.Settings["sizeH"].Value));

            this.Text = "";
            barraDeStatursToolStripMenuItem.Checked = true;
            rchTxtBxContent.WordWrap = true;
            quebraDeFonteAutomáticaToolStripMenuItem.CheckState = CheckState.Checked;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void atualizaPosicao()
        {
            int linha = rchTxtBxContent.GetLineFromCharIndex(rchTxtBxContent.SelectionStart); //Captura a linha do cursor
            int coluna = rchTxtBxContent.SelectionStart - rchTxtBxContent.GetFirstCharIndexFromLine(linha); //Captura a coluna do cursor
            tlStrpSttsLblPosicao.Text = "Ln: " + linha.ToString() + " Col: " + coluna.ToString(); //Atualiza na barra de status a dita posição capturada do cursor
        }   
        private void rchTxtBxConteudo_TextChanged(object sender, EventArgs e)
        {
            alterado = true;
            this.atualizaPosicao();
        }


        // Menu Arquivo

        //Novo arquivo
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!alterado)
            {
                this.Text = "";
                rchTxtBxContent.Text = "";
                alterado = false;
            }
            else
            {
                if(MessageBox.Show("Seu arquivo  foi alterado. Deseja Salvar?", "Bloco de Notas",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    this.Text = "";
                    rchTxtBxContent.Text = "";
                    alterado = false;
                }
                else
                {
                    if (this.Text != "")
                    {
                        this.saveFile(this.Text);
                    }
                    else
                    {
                        this.saveFileAs();
                    }
                }
            }
        }

        //Nova Janela
        private void novaJanelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }

        //Abrir arquivo
        private void openFile() 
        {
            if(opnFlDlgAbrir.ShowDialog() == DialogResult.OK)
            {
                this.Text = opnFlDlgAbrir.FileName; //Poe o nome do arquivo como titulo do formulario
                using (StreamReader reader = new StreamReader(opnFlDlgAbrir.OpenFile())) //Poe o conteudo do arquivo pra dentro do richTextBox
                {
                    rchTxtBxContent.Text = reader.ReadToEnd();
                    alterado = false;
                }
            }
        }
        private void abrirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!alterado) //só relmente abre o arquivo se o arquivo aberto não tiver sido alterado.
            {
                this.openFile();
            }
            else //abre uma MessageBox perguntando se deseja salvar.
            {
                if(MessageBox.Show("Seu arquivo  foi alterado. Deseja Salvar?", "Bloco de Notas",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    this.openFile();
                }
                else
                {
                    if (this.Text != "") //checa se existe um arquivo já aberto atravez do título.(tem título, arquivo aberto. Não tem, não há arquivo aberto)
                    {
                        this.saveFile(this.Text); //Se tem título, se tem arquivo, salva no arquivo aberto.
                    }
                    else
                    {
                        this.saveFileAs(); //Se NÃO tem aquivo, se NÃO tem título, salva em um novo arquivo.
                    }
                }
            }
        }

        //Salvar
        private void saveFile(String arquivo) 
        {
            if (arquivo != "")
            {
                StreamWriter buffer = new StreamWriter(arquivo);
                buffer.Write(rchTxtBxContent.Text);
                buffer.Close();
                this.Text = arquivo;
                alterado = false;
            }
            else
            {
                MessageBox.Show("Nome do arquivo inválido!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Text != "") //checa se existe um arquivo já aberto atravez do título.(tem título, arquivo aberto. Não tem, não há arquivo aberto)
            {
                this.saveFile(this.Text); //Se tem título, se tem arquivo, salva no arquivo aberto.
            }
            else
            {
                this.saveFileAs(); //Se NÃO tem aquivo, se NÃO tem título, salva em um novo arquivo.
            }
        }

        //Salvar Como...
        private void saveFileAs() 
        {
            if (svFlDlgAbrir.ShowDialog() == DialogResult.OK)
            {
                this.saveFile(svFlDlgAbrir.FileName);
            }
        }
        private void salvarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.saveFileAs();
        }

        //Configurar Página
        private void configurarPaginaToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            pgStpDlgConfiguraPag.ShowDialog();
        }

        //Imprimir
        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            prntDlgImprimir.ShowDialog();
        }

        //Sair
        private void sairToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            this.Close();
        }


        // Menu Editar

        //Copiar texto (Ctrl + C) 
        private void copiarToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            if (rchTxtBxContent.SelectedRtf != "")
            {
                Clipboard.SetDataObject(rchTxtBxContent.SelectedRtf);
            }
        }

        //Colar texto (Ctrl + V)
        private void colarToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            if(Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
            {
                rchTxtBxContent.SelectedRtf = (String)Clipboard.GetData(DataFormats.Text);
            }
        }

        //Recortar texto (Ctrl + X)
        private void recortarToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            if(rchTxtBxContent.SelectedRtf != "")
            {
                Clipboard.SetDataObject(rchTxtBxContent.SelectedRtf);
                rchTxtBxContent.SelectedRtf = "";
            }
        }

        //Selecionar tudo (Ctrl + A)
        private void selecionarTudoToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            rchTxtBxContent.SelectAll();
        }

        //Desfazer(Ctrl + Z)
        private void desfazerToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            rchTxtBxContent.Undo();
        }

        //Excluir (Del)
        private void excluirToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            if(rchTxtBxContent.SelectedRtf != "")
            {
                rchTxtBxContent.SelectedRtf = "";
            }
        }

        //Pesquisar no Bing... (Ctrl + E)
        private void buscarComOToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            if(rchTxtBxContent.SelectedRtf != "")
            {
                String texto = rchTxtBxContent.SelectedText;
                texto.Replace(' ', '+');
                System.Diagnostics.Process.Start("Microsoft-edge:https://www.bing.com/search?q=" + texto);  
            }
            else
            {
                MessageBox.Show("É nescessário selecionar um termo para pesquisar.", "Buscar com o Bing",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Substiruir (Ctrl + H)
        private void substituirToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            Substituir frm = new Substituir();
            frm.txtBxLocaliza.Text = rchTxtBxContent.SelectedText;
            frm.Show(this);
        }

        //Localizar (Ctrl + F)
        private void localizarToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            Localizar frm = new Localizar();
            frm.txtBxLocaliza.Text = rchTxtBxContent.SelectedText;
            frm.Show(this);
        }

        //Data/Hora (F5)
        private void dataHoraToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            rchTxtBxContent.SelectedText = System.Environment.NewLine + DateTime.Now;
        }

        // Menu Formatar

        //Quebra automática de linha
        private void quebraDeFonteAutomáticaToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            if(quebraDeFonteAutomáticaToolStripMenuItem.CheckState == CheckState.Unchecked)
            {
                rchTxtBxContent.WordWrap = true;
                quebraDeFonteAutomáticaToolStripMenuItem.CheckState = CheckState.Checked;
            }
            else if(quebraDeFonteAutomáticaToolStripMenuItem.CheckState == CheckState.Checked)
            {
                rchTxtBxContent.WordWrap = false;
                quebraDeFonteAutomáticaToolStripMenuItem.CheckState = CheckState.Unchecked;
            }
        }

        //Fonte
        private void fonteToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            if(fntDlgFonte.ShowDialog() == DialogResult.OK)
            {
                rchTxtBxContent.SelectionFont = fntDlgFonte.Font;
            }
        }

        //Cor da Caixa de texto
        private void corDoFundoToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            if(clrDlgCor.ShowDialog() == DialogResult.OK)
            {
                rchTxtBxContent.BackColor = clrDlgCor.Color;
            }
        }

        //Cor do Texto
        private void corToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            if (clrDlgCor.ShowDialog() == DialogResult.OK)
            {
                rchTxtBxContent.SelectionColor = clrDlgCor.Color;
            }
        }

        //Cor do fundo do texto
        private void corDeFundoDoTextoToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            if (clrDlgCor.ShowDialog() == DialogResult.OK)
            {
                rchTxtBxContent.SelectionBackColor = clrDlgCor.Color;
            }
        }


        // Menu Exibir 

        //Exibir barra de status
        private void barraDeStatursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            barraDeStatursToolStripMenuItem.Checked = !barraDeStatursToolStripMenuItem.Checked;
            sttsStrpFoot.Visible = !sttsStrpFoot.Visible;
        }

        //Abrir uma Imagem
        private void imagemToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            ImageBox frm = new ImageBox();
            frm.Show(this);
        }

        //Zoom
        private void atualizaZoom() 
        {
            tlStrpSttsLblZoom.Text = this.zoom.ToString() + "%";
        }

        private void ampliarToolStripMenuItem_Click(object sender, EventArgs e) //Zoom +
        {
            this.zoom++;
            rchTxtBxContent.Font = new Font(rchTxtBxContent.Font.FontFamily, rchTxtBxContent.Font.Size + 1, rchTxtBxContent.Font.Style);
            this.atualizaZoom();
        }

        private void redizirToolStripMenuItem_Click(object sender, EventArgs e) //Zoom -
        {
            this.zoom--;
            rchTxtBxContent.Font = new Font(rchTxtBxContent.Font.FontFamily, rchTxtBxContent.Font.Size - 1, rchTxtBxContent.Font.Style);
            this.atualizaZoom();
        }

        private void zoomPadrãoToolStripMenuItem_Click(object sender, EventArgs e) //Zoom padrao
        {
            this.zoom = 100;
            rchTxtBxContent.Font = new Font(rchTxtBxContent.Font.FontFamily, 12, rchTxtBxContent.Font.Style);
            this.atualizaZoom();
        }

        //Salvando as informações do form pra proxima execução;
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            config.AppSettings.Settings["windowPositionX"].Value = this.Location.X.ToString();
            config.AppSettings.Settings["windowPositionY"].Value = this.Location.Y.ToString();
            config.AppSettings.Settings["sizeW"].Value = this.Size.Width.ToString();
            config.AppSettings.Settings["sizeH"].Value = this.Size.Height.ToString();
            config.Save(ConfigurationSaveMode.Modified);
        }
    }
}
