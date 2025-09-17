namespace NotePad
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.rchTxtBxContent = new System.Windows.Forms.RichTextBox();
            this.mnStrpHeader = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaJanelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.configurarPaginaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desfazerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.recortarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selecionarTudoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.buscarComOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.substituirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.dataHoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quebraDeFonteAutomáticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fonteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.corDoFundoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.corToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.corDeFundoDoTextoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ampliarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redizirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomPadrãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barraDeStatursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.imagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sttsStrpFoot = new System.Windows.Forms.StatusStrip();
            this.tlStrpSttsLblCodificacao = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlStrpSttsLblFormato = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlStrpSttsLblZoom = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlStrpSttsLblPosicao = new System.Windows.Forms.ToolStripStatusLabel();
            this.opnFlDlgAbrir = new System.Windows.Forms.OpenFileDialog();
            this.svFlDlgAbrir = new System.Windows.Forms.SaveFileDialog();
            this.prntDcmntContent = new System.Drawing.Printing.PrintDocument();
            this.pgStpDlgConfiguraPag = new System.Windows.Forms.PageSetupDialog();
            this.prntDlgImprimir = new System.Windows.Forms.PrintDialog();
            this.fntDlgFonte = new System.Windows.Forms.FontDialog();
            this.clrDlgCor = new System.Windows.Forms.ColorDialog();
            this.mnStrpHeader.SuspendLayout();
            this.sttsStrpFoot.SuspendLayout();
            this.SuspendLayout();
            // 
            // rchTxtBxContent
            // 
            this.rchTxtBxContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rchTxtBxContent.Font = new System.Drawing.Font("Liberation Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchTxtBxContent.Location = new System.Drawing.Point(0, 24);
            this.rchTxtBxContent.Name = "rchTxtBxContent";
            this.rchTxtBxContent.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.rchTxtBxContent.Size = new System.Drawing.Size(585, 584);
            this.rchTxtBxContent.TabIndex = 0;
            this.rchTxtBxContent.Text = "";
            this.rchTxtBxContent.TextChanged += new System.EventHandler(this.rchTxtBxConteudo_TextChanged);
            // 
            // mnStrpHeader
            // 
            this.mnStrpHeader.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.formatarToolStripMenuItem,
            this.exibirToolStripMenuItem});
            this.mnStrpHeader.Location = new System.Drawing.Point(0, 0);
            this.mnStrpHeader.Name = "mnStrpHeader";
            this.mnStrpHeader.Size = new System.Drawing.Size(585, 24);
            this.mnStrpHeader.TabIndex = 1;
            this.mnStrpHeader.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.novaJanelaToolStripMenuItem,
            this.abrirToolStripMenuItem1,
            this.salvarToolStripMenuItem,
            this.salvarComoToolStripMenuItem,
            this.toolStripMenuItem1,
            this.configurarPaginaToolStripMenuItem,
            this.imprimirToolStripMenuItem,
            this.toolStripMenuItem2,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "&Arquivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.abrirToolStripMenuItem.Text = "Novo";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // novaJanelaToolStripMenuItem
            // 
            this.novaJanelaToolStripMenuItem.Name = "novaJanelaToolStripMenuItem";
            this.novaJanelaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.novaJanelaToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.novaJanelaToolStripMenuItem.Text = "Nova Janela";
            this.novaJanelaToolStripMenuItem.Click += new System.EventHandler(this.novaJanelaToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem1
            // 
            this.abrirToolStripMenuItem1.Name = "abrirToolStripMenuItem1";
            this.abrirToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.abrirToolStripMenuItem1.Size = new System.Drawing.Size(222, 22);
            this.abrirToolStripMenuItem1.Text = "Abrir...";
            this.abrirToolStripMenuItem1.Click += new System.EventHandler(this.abrirToolStripMenuItem1_Click);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.salvarToolStripMenuItem.Text = "Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
            // 
            // salvarComoToolStripMenuItem
            // 
            this.salvarComoToolStripMenuItem.Name = "salvarComoToolStripMenuItem";
            this.salvarComoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.salvarComoToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.salvarComoToolStripMenuItem.Text = "Salvar Como...";
            this.salvarComoToolStripMenuItem.Click += new System.EventHandler(this.salvarComoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(219, 6);
            // 
            // configurarPaginaToolStripMenuItem
            // 
            this.configurarPaginaToolStripMenuItem.Name = "configurarPaginaToolStripMenuItem";
            this.configurarPaginaToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.configurarPaginaToolStripMenuItem.Text = "Configurar Página...";
            this.configurarPaginaToolStripMenuItem.Click += new System.EventHandler(this.configurarPaginaToolStripMenuItem_Click);
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.imprimirToolStripMenuItem.Text = "Imprimir...";
            this.imprimirToolStripMenuItem.Click += new System.EventHandler(this.imprimirToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(219, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.desfazerToolStripMenuItem,
            this.toolStripMenuItem3,
            this.recortarToolStripMenuItem,
            this.copiarToolStripMenuItem,
            this.colarToolStripMenuItem,
            this.selecionarTudoToolStripMenuItem,
            this.excluirToolStripMenuItem,
            this.toolStripSeparator1,
            this.buscarComOToolStripMenuItem,
            this.localizarToolStripMenuItem,
            this.substituirToolStripMenuItem,
            this.toolStripMenuItem4,
            this.dataHoraToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "&Editar";
            // 
            // desfazerToolStripMenuItem
            // 
            this.desfazerToolStripMenuItem.Name = "desfazerToolStripMenuItem";
            this.desfazerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.desfazerToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.desfazerToolStripMenuItem.Text = "Desfazer";
            this.desfazerToolStripMenuItem.Click += new System.EventHandler(this.desfazerToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(219, 6);
            // 
            // recortarToolStripMenuItem
            // 
            this.recortarToolStripMenuItem.Name = "recortarToolStripMenuItem";
            this.recortarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.recortarToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.recortarToolStripMenuItem.Text = "Recortar";
            this.recortarToolStripMenuItem.Click += new System.EventHandler(this.recortarToolStripMenuItem_Click);
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.copiarToolStripMenuItem.Text = "Copiar";
            this.copiarToolStripMenuItem.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
            // 
            // colarToolStripMenuItem
            // 
            this.colarToolStripMenuItem.Name = "colarToolStripMenuItem";
            this.colarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.colarToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.colarToolStripMenuItem.Text = "Colar";
            this.colarToolStripMenuItem.Click += new System.EventHandler(this.colarToolStripMenuItem_Click);
            // 
            // selecionarTudoToolStripMenuItem
            // 
            this.selecionarTudoToolStripMenuItem.Name = "selecionarTudoToolStripMenuItem";
            this.selecionarTudoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selecionarTudoToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.selecionarTudoToolStripMenuItem.Text = "Selecionar tudo";
            this.selecionarTudoToolStripMenuItem.Click += new System.EventHandler(this.selecionarTudoToolStripMenuItem_Click);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.excluirToolStripMenuItem.Text = "Excluir";
            this.excluirToolStripMenuItem.Click += new System.EventHandler(this.excluirToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(219, 6);
            // 
            // buscarComOToolStripMenuItem
            // 
            this.buscarComOToolStripMenuItem.Name = "buscarComOToolStripMenuItem";
            this.buscarComOToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.buscarComOToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.buscarComOToolStripMenuItem.Text = "Buscar com o Bing...";
            this.buscarComOToolStripMenuItem.Click += new System.EventHandler(this.buscarComOToolStripMenuItem_Click);
            // 
            // localizarToolStripMenuItem
            // 
            this.localizarToolStripMenuItem.Name = "localizarToolStripMenuItem";
            this.localizarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.localizarToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.localizarToolStripMenuItem.Text = "Localizar";
            this.localizarToolStripMenuItem.Click += new System.EventHandler(this.localizarToolStripMenuItem_Click);
            // 
            // substituirToolStripMenuItem
            // 
            this.substituirToolStripMenuItem.Name = "substituirToolStripMenuItem";
            this.substituirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.substituirToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.substituirToolStripMenuItem.Text = "Substituir...";
            this.substituirToolStripMenuItem.Click += new System.EventHandler(this.substituirToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(219, 6);
            // 
            // dataHoraToolStripMenuItem
            // 
            this.dataHoraToolStripMenuItem.Name = "dataHoraToolStripMenuItem";
            this.dataHoraToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.dataHoraToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.dataHoraToolStripMenuItem.Text = "Hora/Data";
            this.dataHoraToolStripMenuItem.Click += new System.EventHandler(this.dataHoraToolStripMenuItem_Click);
            // 
            // formatarToolStripMenuItem
            // 
            this.formatarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quebraDeFonteAutomáticaToolStripMenuItem,
            this.fonteToolStripMenuItem,
            this.corDoFundoToolStripMenuItem,
            this.corToolStripMenuItem,
            this.corDeFundoDoTextoToolStripMenuItem});
            this.formatarToolStripMenuItem.Name = "formatarToolStripMenuItem";
            this.formatarToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.formatarToolStripMenuItem.Text = "&Formatar";
            // 
            // quebraDeFonteAutomáticaToolStripMenuItem
            // 
            this.quebraDeFonteAutomáticaToolStripMenuItem.Name = "quebraDeFonteAutomáticaToolStripMenuItem";
            this.quebraDeFonteAutomáticaToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.quebraDeFonteAutomáticaToolStripMenuItem.Text = "Quebra Automática de linha";
            this.quebraDeFonteAutomáticaToolStripMenuItem.Click += new System.EventHandler(this.quebraDeFonteAutomáticaToolStripMenuItem_Click);
            // 
            // fonteToolStripMenuItem
            // 
            this.fonteToolStripMenuItem.Name = "fonteToolStripMenuItem";
            this.fonteToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.fonteToolStripMenuItem.Text = "Fonte...";
            this.fonteToolStripMenuItem.Click += new System.EventHandler(this.fonteToolStripMenuItem_Click);
            // 
            // corDoFundoToolStripMenuItem
            // 
            this.corDoFundoToolStripMenuItem.Name = "corDoFundoToolStripMenuItem";
            this.corDoFundoToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.corDoFundoToolStripMenuItem.Text = "Cor da Caixa de Texto";
            this.corDoFundoToolStripMenuItem.Click += new System.EventHandler(this.corDoFundoToolStripMenuItem_Click);
            // 
            // corToolStripMenuItem
            // 
            this.corToolStripMenuItem.Name = "corToolStripMenuItem";
            this.corToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.corToolStripMenuItem.Text = "Cor do Texto";
            this.corToolStripMenuItem.Click += new System.EventHandler(this.corToolStripMenuItem_Click);
            // 
            // corDeFundoDoTextoToolStripMenuItem
            // 
            this.corDeFundoDoTextoToolStripMenuItem.Name = "corDeFundoDoTextoToolStripMenuItem";
            this.corDeFundoDoTextoToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.corDeFundoDoTextoToolStripMenuItem.Text = "Cor de fundo do Texto";
            this.corDeFundoDoTextoToolStripMenuItem.Click += new System.EventHandler(this.corDeFundoDoTextoToolStripMenuItem_Click);
            // 
            // exibirToolStripMenuItem
            // 
            this.exibirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomToolStripMenuItem,
            this.barraDeStatursToolStripMenuItem,
            this.toolStripMenuItem5,
            this.imagemToolStripMenuItem});
            this.exibirToolStripMenuItem.Name = "exibirToolStripMenuItem";
            this.exibirToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.exibirToolStripMenuItem.Text = "E&xibir";
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ampliarToolStripMenuItem,
            this.redizirToolStripMenuItem,
            this.zoomPadrãoToolStripMenuItem});
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.zoomToolStripMenuItem.Text = "Zoom";
            // 
            // ampliarToolStripMenuItem
            // 
            this.ampliarToolStripMenuItem.Name = "ampliarToolStripMenuItem";
            this.ampliarToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + sinal de adição";
            this.ampliarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus)));
            this.ampliarToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.ampliarToolStripMenuItem.Text = "Ampliar";
            this.ampliarToolStripMenuItem.Click += new System.EventHandler(this.ampliarToolStripMenuItem_Click);
            // 
            // redizirToolStripMenuItem
            // 
            this.redizirToolStripMenuItem.Name = "redizirToolStripMenuItem";
            this.redizirToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + sinal de subtração";
            this.redizirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemMinus)));
            this.redizirToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.redizirToolStripMenuItem.Text = "Redizir";
            this.redizirToolStripMenuItem.Click += new System.EventHandler(this.redizirToolStripMenuItem_Click);
            // 
            // zoomPadrãoToolStripMenuItem
            // 
            this.zoomPadrãoToolStripMenuItem.Name = "zoomPadrãoToolStripMenuItem";
            this.zoomPadrãoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D0)));
            this.zoomPadrãoToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.zoomPadrãoToolStripMenuItem.Text = "Restauar Zoom Padrão";
            this.zoomPadrãoToolStripMenuItem.Click += new System.EventHandler(this.zoomPadrãoToolStripMenuItem_Click);
            // 
            // barraDeStatursToolStripMenuItem
            // 
            this.barraDeStatursToolStripMenuItem.Name = "barraDeStatursToolStripMenuItem";
            this.barraDeStatursToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.barraDeStatursToolStripMenuItem.Text = "Barra de status";
            this.barraDeStatursToolStripMenuItem.Click += new System.EventHandler(this.barraDeStatursToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(148, 6);
            // 
            // imagemToolStripMenuItem
            // 
            this.imagemToolStripMenuItem.Name = "imagemToolStripMenuItem";
            this.imagemToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.imagemToolStripMenuItem.Text = "Imagem...";
            this.imagemToolStripMenuItem.Click += new System.EventHandler(this.imagemToolStripMenuItem_Click);
            // 
            // sttsStrpFoot
            // 
            this.sttsStrpFoot.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlStrpSttsLblCodificacao,
            this.tlStrpSttsLblFormato,
            this.tlStrpSttsLblZoom,
            this.tlStrpSttsLblPosicao});
            this.sttsStrpFoot.Location = new System.Drawing.Point(0, 584);
            this.sttsStrpFoot.Name = "sttsStrpFoot";
            this.sttsStrpFoot.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sttsStrpFoot.Size = new System.Drawing.Size(585, 24);
            this.sttsStrpFoot.TabIndex = 2;
            this.sttsStrpFoot.Text = "statusStrip1";
            // 
            // tlStrpSttsLblCodificacao
            // 
            this.tlStrpSttsLblCodificacao.Name = "tlStrpSttsLblCodificacao";
            this.tlStrpSttsLblCodificacao.Size = new System.Drawing.Size(39, 19);
            this.tlStrpSttsLblCodificacao.Text = "UTF-8";
            // 
            // tlStrpSttsLblFormato
            // 
            this.tlStrpSttsLblFormato.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tlStrpSttsLblFormato.Name = "tlStrpSttsLblFormato";
            this.tlStrpSttsLblFormato.Size = new System.Drawing.Size(95, 19);
            this.tlStrpSttsLblFormato.Text = "Windows(CRLF)";
            // 
            // tlStrpSttsLblZoom
            // 
            this.tlStrpSttsLblZoom.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tlStrpSttsLblZoom.Name = "tlStrpSttsLblZoom";
            this.tlStrpSttsLblZoom.Size = new System.Drawing.Size(39, 19);
            this.tlStrpSttsLblZoom.Text = "100%";
            // 
            // tlStrpSttsLblPosicao
            // 
            this.tlStrpSttsLblPosicao.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tlStrpSttsLblPosicao.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.tlStrpSttsLblPosicao.Margin = new System.Windows.Forms.Padding(0);
            this.tlStrpSttsLblPosicao.Name = "tlStrpSttsLblPosicao";
            this.tlStrpSttsLblPosicao.Size = new System.Drawing.Size(52, 24);
            this.tlStrpSttsLblPosicao.Text = ":Ln:  Col";
            // 
            // opnFlDlgAbrir
            // 
            this.opnFlDlgAbrir.DereferenceLinks = false;
            this.opnFlDlgAbrir.Filter = "Arquivo de Texto (*.txt)|*.txt|Documentos de Texto (*.rtf)|*.rtf|Todos os Arquivo" +
    "s (*.*)|*.*";
            this.opnFlDlgAbrir.InitialDirectory = "C:";
            this.opnFlDlgAbrir.Title = "Abrir arquivo...";
            // 
            // svFlDlgAbrir
            // 
            this.svFlDlgAbrir.Filter = "Arquivo de Texto (*.txt)|*.txt|Documentos de Texto (*.rtf)|*.rtf|Todos os Arquivo" +
    "s (*.*)|*.*";
            this.svFlDlgAbrir.Title = "Salvar Como...";
            // 
            // pgStpDlgConfiguraPag
            // 
            this.pgStpDlgConfiguraPag.Document = this.prntDcmntContent;
            // 
            // prntDlgImprimir
            // 
            this.prntDlgImprimir.Document = this.prntDcmntContent;
            this.prntDlgImprimir.UseEXDialog = true;
            // 
            // fntDlgFonte
            // 
            this.fntDlgFonte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 608);
            this.Controls.Add(this.sttsStrpFoot);
            this.Controls.Add(this.rchTxtBxContent);
            this.Controls.Add(this.mnStrpHeader);
            this.KeyPreview = true;
            this.MainMenuStrip = this.mnStrpHeader;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mnStrpHeader.ResumeLayout(false);
            this.mnStrpHeader.PerformLayout();
            this.sttsStrpFoot.ResumeLayout(false);
            this.sttsStrpFoot.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnStrpHeader;
        private System.Windows.Forms.StatusStrip sttsStrpFoot;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaJanelaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurarPaginaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desfazerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem recortarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ampliarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barraDeStatursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redizirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomPadrãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quebraDeFonteAutomáticaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarComOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fonteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem substituirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataHoraToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog opnFlDlgAbrir;
        private System.Windows.Forms.SaveFileDialog svFlDlgAbrir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem selecionarTudoToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument prntDcmntContent;
        private System.Windows.Forms.PageSetupDialog pgStpDlgConfiguraPag;
        private System.Windows.Forms.PrintDialog prntDlgImprimir;
        private System.Windows.Forms.FontDialog fntDlgFonte;
        private System.Windows.Forms.ToolStripStatusLabel tlStrpSttsLblCodificacao;
        private System.Windows.Forms.ToolStripStatusLabel tlStrpSttsLblFormato;
        private System.Windows.Forms.ToolStripStatusLabel tlStrpSttsLblZoom;
        private System.Windows.Forms.ToolStripStatusLabel tlStrpSttsLblPosicao;
        private System.Windows.Forms.ToolStripMenuItem corToolStripMenuItem;
        private System.Windows.Forms.ColorDialog clrDlgCor;
        private System.Windows.Forms.ToolStripMenuItem corDoFundoToolStripMenuItem;
        public System.Windows.Forms.RichTextBox rchTxtBxContent;
        private System.Windows.Forms.ToolStripMenuItem corDeFundoDoTextoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imagemToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
    }
}

