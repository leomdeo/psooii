using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoQuinta
{
    public class Cadastro
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public string mensagem;
        public Cadastro(string nome)
        {
            cmd.CommandText = "insert into ANIMAIS(nome) values (@nome);";

            cmd.Parameters.AddWithValue("@nome", nome);
            try 
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.desconectar();
                this.mensagem = "Cadastro com sucesso!" ;
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro ao tentar conectar com o Banco de dados";
            }
        }
    }
}
