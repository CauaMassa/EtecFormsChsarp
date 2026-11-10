using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _261176_261072.Models;

namespace _261176_261072.Views
{
    public partial class FrmClientes : Form
    {
        Cidade ci;
        Cliente cl;

        public FrmClientes()
        {
            InitializeComponent();
        }

        void carregarGrid(string pesquisa)
        {
            cl = new Cliente()
            {
                nome = pesquisa
            };
            dgvClientes.DataSource = cl.Consultar();
        }

        void limpaControles()
        {
            txtId.Clear();
            txtNome.Clear();
            cboCidades.SelectedIndex = -1;
            txtUF.Clear();
            mskCPF.Clear();
            txtRenda.Clear();
            dtpDataNasc.Value = DateTime.Now;
            picFoto.ImageLocation = "";
            chkVenda.Checked = false;
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            // Cria um objeto do tipo cidade
            // E alimenta o comboBox
            ci = new Cidade();
            cboCidades.DataSource = ci.Consultar();
            cboCidades.DisplayMember = "nome";
            cboCidades.ValueMember = "id";

            limpaControles();
            carregarGrid("");

            // Deixa invisível colunas do Grid
            dgvClientes.Columns["idCidade"].Visible = false;
            dgvClientes.Columns["foto"].Visible = false;
        }

        private void cboCidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCidades.SelectedIndex != -1)
            {
                DataRowView reg = cboCidades.SelectedItem as DataRowView;
                if (reg != null)
                    txtUF.Text = reg["uf"].ToString();
            }
            else
            {
                txtUF.Clear();
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "") return;

            if (cboCidades.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma cidade.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double renda;
            if (!double.TryParse(txtRenda.Text, out renda))
            {
                MessageBox.Show("Informe uma renda válida.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRenda.Focus();
                return;
            }

            cl = new Cliente()
            {
                nome = txtNome.Text,
                idCidade = (int)cboCidades.SelectedValue,
                dataNasc = dtpDataNasc.Value,
                renda = renda,
                cpf = mskCPF.Text,
                foto = picFoto.ImageLocation,
                venda = chkVenda.Checked
            };

            cl.Incluir();

            limpaControles();
            carregarGrid("");
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // RowIndex = -1 quando clica no cabeçalho do grid
            if (e.RowIndex < 0) return;

            DataGridViewRow linha = dgvClientes.Rows[e.RowIndex];

            txtId.Text = linha.Cells["id"].Value.ToString();
            txtNome.Text = linha.Cells["nome"].Value.ToString();

            // Seleciona a cidade pelo id (mais seguro que usar .Text)
            if (linha.Cells["idCidade"].Value != DBNull.Value)
                cboCidades.SelectedValue = Convert.ToInt32(linha.Cells["idCidade"].Value);
            else
                cboCidades.SelectedIndex = -1;

            txtUF.Text = linha.Cells["uf"].Value.ToString();

            chkVenda.Checked = linha.Cells["venda"].Value != DBNull.Value
                               && Convert.ToBoolean(linha.Cells["venda"].Value);

            mskCPF.Text = linha.Cells["cpf"].Value.ToString();

            if (linha.Cells["dataNasc"].Value != DBNull.Value)
                dtpDataNasc.Value = Convert.ToDateTime(linha.Cells["dataNasc"].Value);

            txtRenda.Text = linha.Cells["renda"].Value.ToString();
            picFoto.ImageLocation = linha.Cells["foto"].Value.ToString();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "") return;

            if (cboCidades.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma cidade.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double renda;
            if (!double.TryParse(txtRenda.Text, out renda))
            {
                MessageBox.Show("Informe uma renda válida.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRenda.Focus();
                return;
            }

            cl = new Cliente()
            {
                id = int.Parse(txtId.Text),
                nome = txtNome.Text,
                idCidade = (int)cboCidades.SelectedValue,
                dataNasc = dtpDataNasc.Value,
                renda = renda,
                cpf = mskCPF.Text,
                foto = picFoto.ImageLocation,
                venda = chkVenda.Checked
            };
            cl.Alterar();

            limpaControles();
            carregarGrid("");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "") return;

            if (MessageBox.Show("Deseja excluir o cliente?", "Exclusão",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cl = new Cliente()
                {
                    id = int.Parse(txtId.Text)
                };
                cl.Excluir();

                limpaControles();
                carregarGrid("");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpaControles();
            carregarGrid("");
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            carregarGrid(txtPesquisa.Text);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void picFoto_Click(object sender, EventArgs e)
        {
            ofdArquivo.InitialDirectory = "D:/fotos/clientes/";
            ofdArquivo.FileName = "";
            ofdArquivo.Filter = "Imagens|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            // Só troca a foto se o usuário realmente escolheu um arquivo
            if (ofdArquivo.ShowDialog() == DialogResult.OK)
                picFoto.ImageLocation = ofdArquivo.FileName;
        }
    }
}