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
    internal class Marcas
    {
        public int id { get; set; }
        public string marca { get; set; }
    

    public DataTable Consultar()
        {

            try
            {
                Banco.abrirConexao();

                Banco.Comando = new MySqlCommand("SELECT * FROM marcas WHERE marca like @marca order by marca", Banco.Conexao);

                Banco.Comando.Parameters.AddWithValue("@marca", "%" + marca + "%");

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

