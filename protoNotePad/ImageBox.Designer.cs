namespace NotePad
{
    partial class ImageBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pctrBxImagem = new System.Windows.Forms.PictureBox();
            this.opnFlDlgImage = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBxImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // pctrBxImagem
            // 
            this.pctrBxImagem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pctrBxImagem.Location = new System.Drawing.Point(0, 0);
            this.pctrBxImagem.Name = "pctrBxImagem";
            this.pctrBxImagem.Size = new System.Drawing.Size(704, 441);
            this.pctrBxImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrBxImagem.TabIndex = 0;
            this.pctrBxImagem.TabStop = false;
            // 
            // opnFlDlgImage
            // 
            this.opnFlDlgImage.FileName = "Escolha um arquivo...";
            this.opnFlDlgImage.Filter = "Arquivo de Imagem (*.png)|*.png|Arquivo de Imagem (*.jpg)|*.jpg|Arquivo de Imagem" +
    " (*.jpeg)|*.jpeg|Arquivo tipo Gif (*.gif)|*.gif|Arquivo tipo ícone (*.ico)|*.ico" +
    "|Todos os Arquivos (*.*)|*.*";
            // 
            // ImageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.pctrBxImagem);
            this.Name = "ImageBox";
            this.Text = "Imagem...";
            this.Load += new System.EventHandler(this.ImageBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctrBxImagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctrBxImagem;
        private System.Windows.Forms.OpenFileDialog opnFlDlgImage;
    }
}