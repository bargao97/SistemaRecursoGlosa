namespace Teste
{
    partial class CadastrarClientes
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtRazaoSocial = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtNomeFantasia = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtCNPJ = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.gdvPrestadores = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnCadastrar = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.gdvPrestadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCadastrar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.txtRazaoSocial.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.txtRazaoSocial.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.txtRazaoSocial.BorderThickness = 3;
            this.txtRazaoSocial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRazaoSocial.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtRazaoSocial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.txtRazaoSocial.isPassword = false;
            this.txtRazaoSocial.Location = new System.Drawing.Point(289, 67);
            this.txtRazaoSocial.Margin = new System.Windows.Forms.Padding(4);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(199, 24);
            this.txtRazaoSocial.TabIndex = 3;
            this.txtRazaoSocial.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRazaoSocial.OnValueChanged += new System.EventHandler(this.txtRazaoSocial_OnValueChanged);
            // 
            // txtNomeFantasia
            // 
            this.txtNomeFantasia.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.txtNomeFantasia.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.txtNomeFantasia.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.txtNomeFantasia.BorderThickness = 3;
            this.txtNomeFantasia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomeFantasia.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNomeFantasia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.txtNomeFantasia.isPassword = false;
            this.txtNomeFantasia.Location = new System.Drawing.Point(289, 108);
            this.txtNomeFantasia.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.txtNomeFantasia.Size = new System.Drawing.Size(199, 24);
            this.txtNomeFantasia.TabIndex = 4;
            this.txtNomeFantasia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.txtCNPJ.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.txtCNPJ.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.txtCNPJ.BorderThickness = 3;
            this.txtCNPJ.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCNPJ.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCNPJ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.txtCNPJ.isPassword = false;
            this.txtCNPJ.Location = new System.Drawing.Point(289, 24);
            this.txtCNPJ.Margin = new System.Windows.Forms.Padding(4);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(199, 24);
            this.txtCNPJ.TabIndex = 5;
            this.txtCNPJ.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCNPJ.Leave += new System.EventHandler(this.txtCNPJ_Leave);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(90, 35);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(59, 13);
            this.bunifuCustomLabel1.TabIndex = 7;
            this.bunifuCustomLabel1.Text = "CPF/CNPJ";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(90, 78);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(85, 13);
            this.bunifuCustomLabel2.TabIndex = 8;
            this.bunifuCustomLabel2.Text = "RAZAO SOCIAL";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(90, 119);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(94, 13);
            this.bunifuCustomLabel3.TabIndex = 9;
            this.bunifuCustomLabel3.Text = "NOME FANTASIA";
            // 
            // gdvPrestadores
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gdvPrestadores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gdvPrestadores.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.gdvPrestadores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gdvPrestadores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdvPrestadores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gdvPrestadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvPrestadores.DoubleBuffered = true;
            this.gdvPrestadores.EnableHeadersVisualStyles = false;
            this.gdvPrestadores.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.gdvPrestadores.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.gdvPrestadores.Location = new System.Drawing.Point(61, 214);
            this.gdvPrestadores.Name = "gdvPrestadores";
            this.gdvPrestadores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gdvPrestadores.Size = new System.Drawing.Size(489, 192);
            this.gdvPrestadores.TabIndex = 10;
            this.gdvPrestadores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdvPrestadores_CellContentClick);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnCadastrar.Image = global::Teste.Properties.Resources.plus1;
            this.btnCadastrar.ImageActive = null;
            this.btnCadastrar.Location = new System.Drawing.Point(93, 148);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(41, 37);
            this.btnCadastrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCadastrar.TabIndex = 11;
            this.btnCadastrar.TabStop = false;
            this.btnCadastrar.Zoom = 10;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // CadastrarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.gdvPrestadores);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.txtCNPJ);
            this.Controls.Add(this.txtNomeFantasia);
            this.Controls.Add(this.txtRazaoSocial);
            this.Name = "CadastrarClientes";
            this.Size = new System.Drawing.Size(618, 449);
            this.Load += new System.EventHandler(this.CadastrarOperadora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdvPrestadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCadastrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMetroTextbox txtRazaoSocial;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtNomeFantasia;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtCNPJ;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomDataGrid gdvPrestadores;
        private Bunifu.Framework.UI.BunifuImageButton btnCadastrar;
    }
}
