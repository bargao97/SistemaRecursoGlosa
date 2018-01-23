namespace Teste
{
    partial class verPrestador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(verPrestador));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnHeader = new System.Windows.Forms.Panel();
            this.lblTitulo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnFechar = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPrestador = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblRazaoSocial = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblCPF = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtNomeFantasia = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtRazaoSocial = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtCNPJ = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.pnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.pnHeader.Controls.Add(this.lblTitulo);
            this.pnHeader.Controls.Add(this.btnFechar);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(818, 31);
            this.pnHeader.TabIndex = 0;
            this.pnHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(3, 3);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(95, 19);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Prestador:";
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.ImageActive = null;
            this.btnFechar.Location = new System.Drawing.Point(788, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(27, 26);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFechar.TabIndex = 3;
            this.btnFechar.TabStop = false;
            this.btnFechar.Zoom = 10;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pnHeader;
            this.bunifuDragControl1.Vertical = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(172, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 120);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblPrestador
            // 
            this.lblPrestador.AutoSize = true;
            this.lblPrestador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrestador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lblPrestador.Location = new System.Drawing.Point(353, 62);
            this.lblPrestador.Name = "lblPrestador";
            this.lblPrestador.Size = new System.Drawing.Size(87, 20);
            this.lblPrestador.TabIndex = 2;
            this.lblPrestador.Text = "Prestador";
            // 
            // lblRazaoSocial
            // 
            this.lblRazaoSocial.AutoSize = true;
            this.lblRazaoSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazaoSocial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lblRazaoSocial.Location = new System.Drawing.Point(353, 98);
            this.lblRazaoSocial.Name = "lblRazaoSocial";
            this.lblRazaoSocial.Size = new System.Drawing.Size(130, 20);
            this.lblRazaoSocial.TabIndex = 3;
            this.lblRazaoSocial.Text = "Nome Fantasia";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lblCPF.Location = new System.Drawing.Point(353, 137);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(87, 20);
            this.lblCPF.TabIndex = 4;
            this.lblCPF.Text = "Prestador";
            // 
            // txtNomeFantasia
            // 
            this.txtNomeFantasia.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.txtNomeFantasia.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.txtNomeFantasia.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.txtNomeFantasia.BorderThickness = 3;
            this.txtNomeFantasia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomeFantasia.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNomeFantasia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNomeFantasia.isPassword = false;
            this.txtNomeFantasia.Location = new System.Drawing.Point(348, 54);
            this.txtNomeFantasia.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.txtNomeFantasia.Size = new System.Drawing.Size(370, 28);
            this.txtNomeFantasia.TabIndex = 5;
            this.txtNomeFantasia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.txtRazaoSocial.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.txtRazaoSocial.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.txtRazaoSocial.BorderThickness = 3;
            this.txtRazaoSocial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRazaoSocial.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtRazaoSocial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRazaoSocial.isPassword = false;
            this.txtRazaoSocial.Location = new System.Drawing.Point(348, 90);
            this.txtRazaoSocial.Margin = new System.Windows.Forms.Padding(4);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(370, 28);
            this.txtRazaoSocial.TabIndex = 6;
            this.txtRazaoSocial.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.txtCNPJ.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.txtCNPJ.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.txtCNPJ.BorderThickness = 3;
            this.txtCNPJ.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCNPJ.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCNPJ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCNPJ.isPassword = false;
            this.txtCNPJ.Location = new System.Drawing.Point(348, 129);
            this.txtCNPJ.Margin = new System.Windows.Forms.Padding(4);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(370, 28);
            this.txtCNPJ.TabIndex = 7;
            this.txtCNPJ.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(31, 205);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(352, 215);
            this.bunifuCustomDataGrid1.TabIndex = 8;
            // 
            // verPrestador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 432);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Controls.Add(this.txtCNPJ);
            this.Controls.Add(this.txtRazaoSocial);
            this.Controls.Add(this.txtNomeFantasia);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblRazaoSocial);
            this.Controls.Add(this.lblPrestador);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "verPrestador";
            this.Text = "verPrestador";
            this.Load += new System.EventHandler(this.verPrestador_Load);
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel pnHeader;
        private Bunifu.Framework.UI.BunifuImageButton btnFechar;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTitulo;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtNomeFantasia;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCPF;
        private Bunifu.Framework.UI.BunifuCustomLabel lblRazaoSocial;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPrestador;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtCNPJ;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtRazaoSocial;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
    }
}