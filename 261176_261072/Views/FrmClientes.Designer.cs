namespace _261176_261072.Views
{
    partial class FrmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientes));
            this.txtId = new System.Windows.Forms.TextBox();
            this.chkVenda = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.dtpDataNasc = new System.Windows.Forms.DateTimePicker();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.cbosla = new System.Windows.Forms.Label();
            this.cboCidades = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRenda = new System.Windows.Forms.TextBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.ofdArquivo = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(27, 32);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(119, 26);
            this.txtId.TabIndex = 0;
            // 
            // chkVenda
            // 
            this.chkVenda.AutoSize = true;
            this.chkVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkVenda.Location = new System.Drawing.Point(185, 30);
            this.chkVenda.Name = "chkVenda";
            this.chkVenda.Size = new System.Drawing.Size(159, 24);
            this.chkVenda.TabIndex = 1;
            this.chkVenda.Text = "Bloqueia a venda?";
            this.chkVenda.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // mskCPF
            // 
            this.mskCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCPF.Location = new System.Drawing.Point(27, 216);
            this.mskCPF.Mask = "999.999.999-99";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(303, 26);
            this.mskCPF.TabIndex = 4;
            // 
            // dtpDataNasc
            // 
            this.dtpDataNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNasc.Location = new System.Drawing.Point(351, 216);
            this.dtpDataNasc.Name = "dtpDataNasc";
            this.dtpDataNasc.Size = new System.Drawing.Size(200, 26);
            this.dtpDataNasc.TabIndex = 5;
            // 
            // picFoto
            // 
            this.picFoto.Location = new System.Drawing.Point(584, 12);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(204, 178);
            this.picFoto.TabIndex = 6;
            this.picFoto.TabStop = false;
            this.picFoto.Click += new System.EventHandler(this.picFoto_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Código";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "CPF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(347, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Data Nascimento";
            // 
            // btnIncluir
            // 
            this.btnIncluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluir.Image = ((System.Drawing.Image)(resources.GetObject("btnIncluir.Image")));
            this.btnIncluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncluir.Location = new System.Drawing.Point(27, 267);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(147, 75);
            this.btnIncluir.TabIndex = 10;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(287, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Digite o nome do cliente para pesquisa:";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(17, 45);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(632, 26);
            this.txtPesquisa.TabIndex = 15;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.Image")));
            this.btnConsultar.Location = new System.Drawing.Point(665, 23);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(79, 71);
            this.btnConsultar.TabIndex = 16;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(17, 106);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(727, 150);
            this.dgvClientes.TabIndex = 17;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);
            // 
            // cbosla
            // 
            this.cbosla.AutoSize = true;
            this.cbosla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbosla.Location = new System.Drawing.Point(24, 127);
            this.cbosla.Name = "cbosla";
            this.cbosla.Size = new System.Drawing.Size(67, 20);
            this.cbosla.TabIndex = 18;
            this.cbosla.Text = "Cidades";
            // 
            // cboCidades
            // 
            this.cboCidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCidades.FormattingEnabled = true;
            this.cboCidades.Location = new System.Drawing.Point(27, 150);
            this.cboCidades.Name = "cboCidades";
            this.cboCidades.Size = new System.Drawing.Size(423, 28);
            this.cboCidades.TabIndex = 19;
            this.cboCidades.SelectedIndexChanged += new System.EventHandler(this.cboCidades_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvClientes);
            this.groupBox1.Controls.Add(this.txtPesquisa);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnConsultar);
            this.groupBox1.Location = new System.Drawing.Point(28, 359);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 262);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(580, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Renda";
            // 
            // txtRenda
            // 
            this.txtRenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRenda.Location = new System.Drawing.Point(584, 218);
            this.txtRenda.Name = "txtRenda";
            this.txtRenda.Size = new System.Drawing.Size(156, 26);
            this.txtRenda.TabIndex = 27;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(182, 267);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(147, 75);
            this.btnAlterar.TabIndex = 28;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(337, 267);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(147, 75);
            this.btnCancelar.TabIndex = 29;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFechar.Location = new System.Drawing.Point(647, 267);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(141, 75);
            this.btnFechar.TabIndex = 30;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(492, 267);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(147, 75);
            this.btnExcluir.TabIndex = 31;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // txtUF
            // 
            this.txtUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUF.Location = new System.Drawing.Point(475, 152);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(76, 26);
            this.txtUF.TabIndex = 32;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(471, 127);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(31, 20);
            this.label.TabIndex = 20;
            this.label.Text = "UF";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(28, 91);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(523, 26);
            this.txtNome.TabIndex = 33;
            // 
            // ofdArquivo
            // 
            this.ofdArquivo.FileName = "ofdArquivo";
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 633);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtUF);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.txtRenda);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.cboCidades);
            this.Controls.Add(this.cbosla);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picFoto);
            this.Controls.Add(this.dtpDataNasc);
            this.Controls.Add(this.mskCPF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkVenda);
            this.Controls.Add(this.txtId);
            this.Name = "FrmClientes";
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.CheckBox chkVenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.DateTimePicker dtpDataNasc;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label cbosla;
        private System.Windows.Forms.ComboBox cboCidades;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRenda;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.OpenFileDialog ofdArquivo;
    }
}