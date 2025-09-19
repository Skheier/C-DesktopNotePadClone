namespace NotePad
{
    partial class Substituir
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
            this.txtBxSubstitui = new System.Windows.Forms.TextBox();
            this.txtBxLocaliza = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSubstitui = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBxSubstitui
            // 
            this.txtBxSubstitui.Location = new System.Drawing.Point(89, 47);
            this.txtBxSubstitui.Name = "txtBxSubstitui";
            this.txtBxSubstitui.Size = new System.Drawing.Size(222, 20);
            this.txtBxSubstitui.TabIndex = 0;
            this.txtBxSubstitui.TextChanged += new System.EventHandler(this.txtBxSubstitui_TextChanged);
            // 
            // txtBxLocaliza
            // 
            this.txtBxLocaliza.Location = new System.Drawing.Point(89, 20);
            this.txtBxLocaliza.Name = "txtBxLocaliza";
            this.txtBxLocaliza.Size = new System.Drawing.Size(222, 20);
            this.txtBxLocaliza.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Localiza: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Substituir por:";
            // 
            // btnSubstitui
            // 
            this.btnSubstitui.Location = new System.Drawing.Point(317, 18);
            this.btnSubstitui.Name = "btnSubstitui";
            this.btnSubstitui.Size = new System.Drawing.Size(135, 23);
            this.btnSubstitui.TabIndex = 4;
            this.btnSubstitui.Text = "Substituir Tudo";
            this.btnSubstitui.UseVisualStyleBackColor = true;
            this.btnSubstitui.Click += new System.EventHandler(this.btnSubstitui_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(317, 45);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(135, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Substituir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 91);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSubstitui);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBxLocaliza);
            this.Controls.Add(this.txtBxSubstitui);
            this.Name = "Substituir";
            this.Text = "substituir";
            this.Load += new System.EventHandler(this.substituir_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxSubstitui;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSubstitui;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.TextBox txtBxLocaliza;
    }
}