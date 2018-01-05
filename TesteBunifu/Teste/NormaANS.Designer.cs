namespace Teste
{
    partial class NormaANS
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
            this.btnCadastrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.gdvTabelaAns = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txtCodAns = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtDescricao = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnBuscar = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtResposta = new Bunifu.Framework.UI.BunifuMetroTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.btnCadastrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvTabelaAns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnCadastrar.Image = global::Teste.Properties.Resources.plus1;
            this.btnCadastrar.ImageActive = null;
            this.btnCadastrar.Location = new System.Drawing.Point(24, 155);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(34, 31);
            this.btnCadastrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.TabStop = false;
            this.btnCadastrar.Zoom = 10;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // gdvTabelaAns
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gdvTabelaAns.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gdvTabelaAns.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.gdvTabelaAns.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gdvTabelaAns.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdvTabelaAns.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gdvTabelaAns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvTabelaAns.DoubleBuffered = true;
            this.gdvTabelaAns.EnableHeadersVisualStyles = false;
            this.gdvTabelaAns.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.gdvTabelaAns.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.gdvTabelaAns.Location = new System.Drawing.Point(62, 211);
            this.gdvTabelaAns.Name = "gdvTabelaAns";
            this.gdvTabelaAns.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gdvTabelaAns.Size = new System.Drawing.Size(498, 204);
            this.gdvTabelaAns.TabIndex = 1;
            // 
            // txtCodAns
            // 
            this.txtCodAns.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.txtCodAns.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.txtCodAns.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.txtCodAns.BorderThickness = 3;
            this.txtCodAns.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodAns.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCodAns.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.txtCodAns.isPassword = false;
            this.txtCodAns.Location = new System.Drawing.Point(149, 50);
            this.txtCodAns.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodAns.Name = "txtCodAns";
            this.txtCodAns.Size = new System.Drawing.Size(199, 24);
            this.txtCodAns.TabIndex = 2;
            this.txtCodAns.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtDescricao
            // 
            this.txtDescricao.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.txtDescricao.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.txtDescricao.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.txtDescricao.BorderThickness = 3;
            this.txtDescricao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescricao.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDescricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.txtDescricao.isPassword = false;
            this.txtDescricao.Location = new System.Drawing.Point(149, 82);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(386, 25);
            this.txtDescricao.TabIndex = 3;
            this.txtDescricao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(23, 61);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(102, 13);
            this.bunifuCustomLabel1.TabIndex = 4;
            this.bunifuCustomLabel1.Text = "Insira o Codigo ANS";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(23, 94);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(55, 13);
            this.bunifuCustomLabel2.TabIndex = 5;
            this.bunifuCustomLabel2.Text = "Descrição";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnBuscar.Image = global::Teste.Properties.Resources.lupa_branca;
            this.btnBuscar.ImageActive = null;
            this.btnBuscar.Location = new System.Drawing.Point(24, 13);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(34, 31);
            this.btnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Zoom = 10;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(76, 22);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(101, 13);
            this.bunifuCustomLabel3.TabIndex = 7;
            this.bunifuCustomLabel3.Text = "Buscar Codigo ANS";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(64, 164);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(52, 13);
            this.bunifuCustomLabel4.TabIndex = 8;
            this.bunifuCustomLabel4.Text = "Cadastrar";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(23, 127);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(108, 13);
            this.bunifuCustomLabel5.TabIndex = 10;
            this.bunifuCustomLabel5.Text = "Resposta Automatica";
            // 
            // txtResposta
            // 
            this.txtResposta.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.txtResposta.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.txtResposta.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.txtResposta.BorderThickness = 3;
            this.txtResposta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtResposta.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtResposta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.txtResposta.isPassword = false;
            this.txtResposta.Location = new System.Drawing.Point(149, 115);
            this.txtResposta.Margin = new System.Windows.Forms.Padding(4);
            this.txtResposta.Name = "txtResposta";
            this.txtResposta.Size = new System.Drawing.Size(386, 25);
            this.txtResposta.TabIndex = 9;
            this.txtResposta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // NormaANS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.txtResposta);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtCodAns);
            this.Controls.Add(this.gdvTabelaAns);
            this.Controls.Add(this.btnCadastrar);
            this.Name = "NormaANS";
            this.Size = new System.Drawing.Size(608, 449);
            this.Load += new System.EventHandler(this.NormaANS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnCadastrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvTabelaAns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton btnCadastrar;
        private Bunifu.Framework.UI.BunifuCustomDataGrid gdvTabelaAns;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtCodAns;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtDescricao;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuImageButton btnBuscar;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtResposta;
    }
}
