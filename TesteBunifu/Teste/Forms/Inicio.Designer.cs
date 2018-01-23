namespace Teste
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnInicio = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCadastrarOperadoras = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCadastrarClientes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCadastrarANS = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBuscarLote = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.cadastrarClientes2 = new Teste.CadastrarClientes();
            this.cadastrarFuncionario2 = new Teste.CadastrarFuncionario();
            this.cadastrarOperadora2 = new Teste.CadastrarOperadora();
            this.menuPrincipal2 = new Teste.MenuPrincipal();
            this.normaANS2 = new Teste.NormaANS();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.btnInicio);
            this.flowLayoutPanel1.Controls.Add(this.btnCadastrarOperadoras);
            this.flowLayoutPanel1.Controls.Add(this.btnCadastrarClientes);
            this.flowLayoutPanel1.Controls.Add(this.btnCadastrarANS);
            this.flowLayoutPanel1.Controls.Add(this.btnBuscarLote);
            this.flowLayoutPanel1.Controls.Add(this.bunifuFlatButton4);
            this.flowLayoutPanel1.Controls.Add(this.bunifuFlatButton5);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(269, 458);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Teste.Properties.Resources.LOGO_179x73;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(266, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnInicio
            // 
            this.btnInicio.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInicio.BorderRadius = 0;
            this.btnInicio.ButtonText = "       Menu principal";
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.DisabledColor = System.Drawing.Color.Gray;
            this.btnInicio.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.Iconcolor = System.Drawing.Color.Transparent;
            this.btnInicio.Iconimage = global::Teste.Properties.Resources.top_menu;
            this.btnInicio.Iconimage_right = null;
            this.btnInicio.Iconimage_right_Selected = null;
            this.btnInicio.Iconimage_Selected = null;
            this.btnInicio.IconMarginLeft = 0;
            this.btnInicio.IconMarginRight = 0;
            this.btnInicio.IconRightVisible = false;
            this.btnInicio.IconRightZoom = 0D;
            this.btnInicio.IconVisible = true;
            this.btnInicio.IconZoom = 70D;
            this.btnInicio.IsTab = true;
            this.btnInicio.Location = new System.Drawing.Point(3, 88);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.btnInicio.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.btnInicio.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnInicio.selected = true;
            this.btnInicio.Size = new System.Drawing.Size(266, 47);
            this.btnInicio.TabIndex = 8;
            this.btnInicio.Text = "       Menu principal";
            this.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnInicio.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnCadastrarOperadoras
            // 
            this.btnCadastrarOperadoras.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnCadastrarOperadoras.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCadastrarOperadoras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCadastrarOperadoras.BorderRadius = 0;
            this.btnCadastrarOperadoras.ButtonText = "       Operadoras";
            this.btnCadastrarOperadoras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarOperadoras.DisabledColor = System.Drawing.Color.Gray;
            this.btnCadastrarOperadoras.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarOperadoras.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCadastrarOperadoras.Iconimage = global::Teste.Properties.Resources.Hospital;
            this.btnCadastrarOperadoras.Iconimage_right = null;
            this.btnCadastrarOperadoras.Iconimage_right_Selected = null;
            this.btnCadastrarOperadoras.Iconimage_Selected = null;
            this.btnCadastrarOperadoras.IconMarginLeft = 0;
            this.btnCadastrarOperadoras.IconMarginRight = 0;
            this.btnCadastrarOperadoras.IconRightVisible = false;
            this.btnCadastrarOperadoras.IconRightZoom = 0D;
            this.btnCadastrarOperadoras.IconVisible = true;
            this.btnCadastrarOperadoras.IconZoom = 70D;
            this.btnCadastrarOperadoras.IsTab = true;
            this.btnCadastrarOperadoras.Location = new System.Drawing.Point(3, 141);
            this.btnCadastrarOperadoras.Name = "btnCadastrarOperadoras";
            this.btnCadastrarOperadoras.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.btnCadastrarOperadoras.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.btnCadastrarOperadoras.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnCadastrarOperadoras.selected = false;
            this.btnCadastrarOperadoras.Size = new System.Drawing.Size(266, 47);
            this.btnCadastrarOperadoras.TabIndex = 2;
            this.btnCadastrarOperadoras.Text = "       Operadoras";
            this.btnCadastrarOperadoras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarOperadoras.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCadastrarOperadoras.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarOperadoras.Click += new System.EventHandler(this.btnCadastrarOperadoras_Click);
            // 
            // btnCadastrarClientes
            // 
            this.btnCadastrarClientes.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnCadastrarClientes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCadastrarClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCadastrarClientes.BorderRadius = 0;
            this.btnCadastrarClientes.ButtonText = "       Clientes";
            this.btnCadastrarClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarClientes.DisabledColor = System.Drawing.Color.Gray;
            this.btnCadastrarClientes.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarClientes.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCadastrarClientes.Iconimage = global::Teste.Properties.Resources.medico;
            this.btnCadastrarClientes.Iconimage_right = null;
            this.btnCadastrarClientes.Iconimage_right_Selected = null;
            this.btnCadastrarClientes.Iconimage_Selected = null;
            this.btnCadastrarClientes.IconMarginLeft = 0;
            this.btnCadastrarClientes.IconMarginRight = 0;
            this.btnCadastrarClientes.IconRightVisible = false;
            this.btnCadastrarClientes.IconRightZoom = 0D;
            this.btnCadastrarClientes.IconVisible = true;
            this.btnCadastrarClientes.IconZoom = 70D;
            this.btnCadastrarClientes.IsTab = true;
            this.btnCadastrarClientes.Location = new System.Drawing.Point(3, 194);
            this.btnCadastrarClientes.Name = "btnCadastrarClientes";
            this.btnCadastrarClientes.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.btnCadastrarClientes.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.btnCadastrarClientes.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnCadastrarClientes.selected = false;
            this.btnCadastrarClientes.Size = new System.Drawing.Size(266, 47);
            this.btnCadastrarClientes.TabIndex = 3;
            this.btnCadastrarClientes.Text = "       Clientes";
            this.btnCadastrarClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarClientes.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCadastrarClientes.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarClientes.Click += new System.EventHandler(this.btnCadastrarClientes_Click);
            // 
            // btnCadastrarANS
            // 
            this.btnCadastrarANS.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnCadastrarANS.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCadastrarANS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCadastrarANS.BorderRadius = 0;
            this.btnCadastrarANS.ButtonText = "      Normas da ANS";
            this.btnCadastrarANS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarANS.DisabledColor = System.Drawing.Color.Gray;
            this.btnCadastrarANS.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarANS.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCadastrarANS.Iconimage = global::Teste.Properties.Resources.ans2;
            this.btnCadastrarANS.Iconimage_right = null;
            this.btnCadastrarANS.Iconimage_right_Selected = null;
            this.btnCadastrarANS.Iconimage_Selected = null;
            this.btnCadastrarANS.IconMarginLeft = 0;
            this.btnCadastrarANS.IconMarginRight = 0;
            this.btnCadastrarANS.IconRightVisible = false;
            this.btnCadastrarANS.IconRightZoom = 0D;
            this.btnCadastrarANS.IconVisible = true;
            this.btnCadastrarANS.IconZoom = 90D;
            this.btnCadastrarANS.IsTab = true;
            this.btnCadastrarANS.Location = new System.Drawing.Point(3, 247);
            this.btnCadastrarANS.Name = "btnCadastrarANS";
            this.btnCadastrarANS.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.btnCadastrarANS.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.btnCadastrarANS.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnCadastrarANS.selected = false;
            this.btnCadastrarANS.Size = new System.Drawing.Size(266, 47);
            this.btnCadastrarANS.TabIndex = 4;
            this.btnCadastrarANS.Text = "      Normas da ANS";
            this.btnCadastrarANS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarANS.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCadastrarANS.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarANS.Click += new System.EventHandler(this.btnCadastrarANS_Click);
            // 
            // btnBuscarLote
            // 
            this.btnBuscarLote.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnBuscarLote.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscarLote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarLote.BorderRadius = 0;
            this.btnBuscarLote.ButtonText = "       Buscar Lotes";
            this.btnBuscarLote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarLote.DisabledColor = System.Drawing.Color.Gray;
            this.btnBuscarLote.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarLote.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBuscarLote.Iconimage = global::Teste.Properties.Resources.Lupa2;
            this.btnBuscarLote.Iconimage_right = null;
            this.btnBuscarLote.Iconimage_right_Selected = null;
            this.btnBuscarLote.Iconimage_Selected = null;
            this.btnBuscarLote.IconMarginLeft = 0;
            this.btnBuscarLote.IconMarginRight = 0;
            this.btnBuscarLote.IconRightVisible = false;
            this.btnBuscarLote.IconRightZoom = 0D;
            this.btnBuscarLote.IconVisible = true;
            this.btnBuscarLote.IconZoom = 70D;
            this.btnBuscarLote.IsTab = true;
            this.btnBuscarLote.Location = new System.Drawing.Point(3, 300);
            this.btnBuscarLote.Name = "btnBuscarLote";
            this.btnBuscarLote.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscarLote.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscarLote.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnBuscarLote.selected = false;
            this.btnBuscarLote.Size = new System.Drawing.Size(266, 47);
            this.btnBuscarLote.TabIndex = 5;
            this.btnBuscarLote.Text = "       Buscar Lotes";
            this.btnBuscarLote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarLote.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBuscarLote.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "      Funcionario";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = global::Teste.Properties.Resources.usuario;
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 0;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = false;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = true;
            this.bunifuFlatButton4.IconZoom = 70D;
            this.bunifuFlatButton4.IsTab = true;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(3, 353);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(266, 47);
            this.bunifuFlatButton4.TabIndex = 6;
            this.bunifuFlatButton4.Text = "      Funcionario";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton4.Click += new System.EventHandler(this.bunifuFlatButton4_Click);
            // 
            // bunifuFlatButton5
            // 
            this.bunifuFlatButton5.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.bunifuFlatButton5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton5.BorderRadius = 0;
            this.bunifuFlatButton5.ButtonText = "      Gerar Relatorio";
            this.bunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.Iconimage = global::Teste.Properties.Resources.correct;
            this.bunifuFlatButton5.Iconimage_right = null;
            this.bunifuFlatButton5.Iconimage_right_Selected = null;
            this.bunifuFlatButton5.Iconimage_Selected = null;
            this.bunifuFlatButton5.IconMarginLeft = 0;
            this.bunifuFlatButton5.IconMarginRight = 0;
            this.bunifuFlatButton5.IconRightVisible = false;
            this.bunifuFlatButton5.IconRightZoom = 0D;
            this.bunifuFlatButton5.IconVisible = true;
            this.bunifuFlatButton5.IconZoom = 70D;
            this.bunifuFlatButton5.IsTab = true;
            this.bunifuFlatButton5.Location = new System.Drawing.Point(3, 406);
            this.bunifuFlatButton5.Name = "bunifuFlatButton5";
            this.bunifuFlatButton5.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton5.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.bunifuFlatButton5.selected = false;
            this.bunifuFlatButton5.Size = new System.Drawing.Size(266, 47);
            this.bunifuFlatButton5.TabIndex = 7;
            this.bunifuFlatButton5.Text = "      Gerar Relatorio";
            this.bunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton5.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton5.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.panelHeader.Controls.Add(this.bunifuImageButton2);
            this.panelHeader.Controls.Add(this.bunifuCustomLabel1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(874, 25);
            this.panelHeader.TabIndex = 1;
            this.panelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHeader_Paint);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(844, 2);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(27, 26);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 2;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(21, 3);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(144, 19);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Recurso de Glosa";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelHeader;
            this.bunifuDragControl1.Vertical = true;
            // 
            // cadastrarClientes2
            // 
            this.cadastrarClientes2.Location = new System.Drawing.Point(270, 25);
            this.cadastrarClientes2.Name = "cadastrarClientes2";
            this.cadastrarClientes2.Size = new System.Drawing.Size(601, 449);
            this.cadastrarClientes2.TabIndex = 2;
            // 
            // cadastrarFuncionario2
            // 
            this.cadastrarFuncionario2.Location = new System.Drawing.Point(270, 25);
            this.cadastrarFuncionario2.Name = "cadastrarFuncionario2";
            this.cadastrarFuncionario2.Size = new System.Drawing.Size(601, 449);
            this.cadastrarFuncionario2.TabIndex = 3;
            // 
            // cadastrarOperadora2
            // 
            this.cadastrarOperadora2.Location = new System.Drawing.Point(270, 25);
            this.cadastrarOperadora2.Name = "cadastrarOperadora2";
            this.cadastrarOperadora2.Size = new System.Drawing.Size(601, 449);
            this.cadastrarOperadora2.TabIndex = 4;
            // 
            // menuPrincipal2
            // 
            this.menuPrincipal2.Location = new System.Drawing.Point(270, 25);
            this.menuPrincipal2.Name = "menuPrincipal2";
            this.menuPrincipal2.Size = new System.Drawing.Size(601, 449);
            this.menuPrincipal2.TabIndex = 5;
            // 
            // normaANS2
            // 
            this.normaANS2.Location = new System.Drawing.Point(270, 25);
            this.normaANS2.Name = "normaANS2";
            this.normaANS2.Size = new System.Drawing.Size(604, 453);
            this.normaANS2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(874, 483);
            this.Controls.Add(this.normaANS2);
            this.Controls.Add(this.menuPrincipal2);
            this.Controls.Add(this.cadastrarOperadora2);
            this.Controls.Add(this.cadastrarFuncionario2);
            this.Controls.Add(this.cadastrarClientes2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btnCadastrarOperadoras;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnCadastrarClientes;
        private Bunifu.Framework.UI.BunifuFlatButton btnCadastrarANS;
        private Bunifu.Framework.UI.BunifuFlatButton btnBuscarLote;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton5;
        private Bunifu.Framework.UI.BunifuFlatButton btnInicio;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private NormaANS normaANS2;
        private MenuPrincipal menuPrincipal2;
        private CadastrarOperadora cadastrarOperadora2;
        private CadastrarFuncionario cadastrarFuncionario2;
        private CadastrarClientes cadastrarClientes2;
    }
}