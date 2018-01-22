namespace Teste
{
    partial class CadastrarFuncionario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gdvFuncionarios = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtUsuario = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtSenha = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtNomeFuncionario = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnCadastrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gdvFuncionarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCadastrar)).BeginInit();
            this.SuspendLayout();
            // 
            // gdvFuncionarios
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gdvFuncionarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.gdvFuncionarios.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.gdvFuncionarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gdvFuncionarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdvFuncionarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.gdvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvFuncionarios.DoubleBuffered = true;
            this.gdvFuncionarios.EnableHeadersVisualStyles = false;
            this.gdvFuncionarios.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.gdvFuncionarios.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.gdvFuncionarios.Location = new System.Drawing.Point(60, 223);
            this.gdvFuncionarios.Name = "gdvFuncionarios";
            this.gdvFuncionarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gdvFuncionarios.Size = new System.Drawing.Size(489, 192);
            this.gdvFuncionarios.TabIndex = 18;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(88, 104);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(38, 13);
            this.bunifuCustomLabel2.TabIndex = 16;
            this.bunifuCustomLabel2.Text = "Senha";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(88, 72);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(43, 13);
            this.bunifuCustomLabel1.TabIndex = 15;
            this.bunifuCustomLabel1.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.txtUsuario.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.txtUsuario.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.txtUsuario.BorderThickness = 3;
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.txtUsuario.isPassword = false;
            this.txtUsuario.Location = new System.Drawing.Point(215, 61);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(199, 24);
            this.txtUsuario.TabIndex = 14;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtSenha
            // 
            this.txtSenha.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.txtSenha.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.txtSenha.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.txtSenha.BorderThickness = 3;
            this.txtSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSenha.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.txtSenha.isPassword = true;
            this.txtSenha.Location = new System.Drawing.Point(215, 93);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(199, 24);
            this.txtSenha.TabIndex = 12;
            this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(82, 40);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(108, 13);
            this.bunifuCustomLabel4.TabIndex = 22;
            this.bunifuCustomLabel4.Text = "Nome do Funcionario";
            // 
            // txtNomeFuncionario
            // 
            this.txtNomeFuncionario.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.txtNomeFuncionario.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.txtNomeFuncionario.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.txtNomeFuncionario.BorderThickness = 3;
            this.txtNomeFuncionario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomeFuncionario.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNomeFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.txtNomeFuncionario.isPassword = false;
            this.txtNomeFuncionario.Location = new System.Drawing.Point(215, 29);
            this.txtNomeFuncionario.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeFuncionario.Name = "txtNomeFuncionario";
            this.txtNomeFuncionario.Size = new System.Drawing.Size(199, 24);
            this.txtNomeFuncionario.TabIndex = 21;
            this.txtNomeFuncionario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnCadastrar.Image = global::Teste.Properties.Resources.plus1;
            this.btnCadastrar.ImageActive = null;
            this.btnCadastrar.Location = new System.Drawing.Point(91, 154);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(41, 37);
            this.btnCadastrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCadastrar.TabIndex = 19;
            this.btnCadastrar.TabStop = false;
            this.btnCadastrar.Zoom = 10;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(138, 169);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(52, 13);
            this.bunifuCustomLabel3.TabIndex = 20;
            this.bunifuCustomLabel3.Text = "Cadastrar";
            // 
            // CadastrarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.txtNomeFuncionario);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.gdvFuncionarios);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtSenha);
            this.Name = "CadastrarFuncionario";
            this.Size = new System.Drawing.Size(608, 449);
            ((System.ComponentModel.ISupportInitialize)(this.gdvFuncionarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCadastrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomDataGrid gdvFuncionarios;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtUsuario;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtSenha;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtNomeFuncionario;
        private Bunifu.Framework.UI.BunifuImageButton btnCadastrar;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
    }
}
