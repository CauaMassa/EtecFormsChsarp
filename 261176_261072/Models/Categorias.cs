using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace _261176_261072.Models
{
    internal class Categorias
    {
        public int id { get; set; }
        public string categoria { get; set; }

        public DataTable Consultar()
        {

            try
            {
                Banco.abrirConexao();

                Banco.Comando = new MySqlCommand("SELECT * FROM categorias WHERE marca like @categoria order by categoria", Banco.Conexao);

                Banco.Comando.Parameters.AddWithValue("@categoria", "%" + categoria + "%");

                Banco.Adaptador = new MySqlDataAdapter(Banco.Comando);
                Banco.datTabela = new DataTable();
                Banco.Adaptador.Fill(Banco.datTabela);

                Banco.fecharConexao();

                return Banco.datTabela;
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
