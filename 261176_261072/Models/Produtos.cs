using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using static Org.BouncyCastle.Asn1.Cmp.Challenge;
using System.Windows.Forms;

namespace _261176_261072.Models
{
    public class Produtos
    {
        public int id { get; set; }
        public string categoria { get; set; }
        public string descricao { get; set; }
        public string marca { get; set; }
        public double vlrVenda { get; set; }
        public double estoque { get; set; }
        public string foto { get; set; }

        public void Incluir()
        {
            try
            {
                Banco.Conexao.Open();
                Banco.Comando = new MySqlCommand
                ("INSERT INTO produtos (categoria, descricao, marca, vlrVenda, estoque, foto) " +
                "VALUES (@categoria, @descricao, @marca, @vlrVenda, @estoque, @foto)", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@categoria", categoria);
                Banco.Comando.Parameters.AddWithValue("@descricao", descricao);
                Banco.Comando.Parameters.AddWithValue("@marca", marca);
                Banco.Comando.Parameters.AddWithValue("@vlrVenda", vlrVenda);
                Banco.Comando.Parameters.AddWithValue("@estoque", estoque);
                Banco.Comando.Parameters.AddWithValue("@foto", foto);
                Banco.Comando.ExecuteNonQuery();
                Banco.Conexao.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Alterar()
        {
            try
            {
                Banco.Conexao.Open();
                Banco.Comando = new MySqlCommand
                ("UPDATE produtos SET categoria = @categoria, descricao = @descricao, marca = @marca, " +
                "vlrVenda = @vlrVenda, estoque = @estoque, foto = @foto", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@categoria", categoria);
                Banco.Comando.Parameters.AddWithValue("@descricao", descricao);
                Banco.Comando.Parameters.AddWithValue("@marca", marca);
                Banco.Comando.Parameters.AddWithValue("@vlrVenda", vlrVenda);
                Banco.Comando.Parameters.AddWithValue("@estoque", estoque);
                Banco.Comando.Parameters.AddWithValue("@foto", foto);
                Banco.Comando.ExecuteNonQuery();
                Banco.Conexao.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      public void Excluir()
        {
            try
            {
                Banco.Conexao.Open();
                Banco.Comando = new MySqlCommand("delete from produtos where id = @id", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@id", id);
                Banco.Comando.ExecuteNonQuery();
                Banco.Conexao.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
