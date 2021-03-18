using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace AcademiaProgramador2021
{
    class BancoDados
    {  

        //Abrindo conexão com o banco de dados
        public static SQLiteConnection conectaBanco()
        {          
            string stringAcessoBD;
            SQLiteConnection conexao;
            stringAcessoBD = "Data Source=banco_academia.db;Version=3;New=false;Compress=True;";  //String de acesso para BD, ele fica na pasta debug do projeto
            conexao = new SQLiteConnection(stringAcessoBD);
            conexao.Open(); //abre aqui e fecha no fim de cada Método 
            return conexao; //retornando a conexão para o método
        }
        //-------------------------------------------------------------------------------------------------------// Separar Parte Tela 2

        //Pegar todos os itens da tabela de chamadas do banco de dados
        public static DataTable ObterChamadas()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = conectaBanco();//abrindo conexao
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM tb_chamadas";  //query
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();//fechando conexao
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Pegando os dados da tabela chamadas com um ID primary key
        public static DataTable ObterDadosChamadas(String id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = conectaBanco(); //abrindo
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM  tb_chamadas WHERE Id = " + id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close(); //fechando
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Erro");
                return null; 
            }
        }

        //Atualizando os campos selecionados na tabela
        public static void AtualizarChamadas(String titulo, String equipamento, string descricao, string data, string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = conectaBanco(); //abrindo
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "UPDATE tb_chamadas SET Titulo='" + titulo + "',Data='" + data + "',Descricao='" + descricao + "',Equipamento='" + equipamento + "' WHERE Id='" + id + "' ";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);

                cmd.ExecuteNonQuery();
                vcon.Close(); //fechando
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Erro");
            }
        }

        //Removendo da tabela com base no id primary key
        public static void RemoverChamado(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = conectaBanco(); //abrindo
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "DELETE FROM tb_chamadas WHERE Id='" + id + "' "; //Query
                da = new SQLiteDataAdapter(cmd.CommandText, vcon); //adaptando 
                cmd.ExecuteNonQuery(); //executando query
                vcon.Close(); //fechando
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Erro");
            }
        }

        //Inserindo item na tabela de chamadas
        public static void InserirChamada(String titulo, String equipamento, string descricao, string data)
        {
            try
            {
                var vcon = conectaBanco(); //abrindo
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "INSERT INTO tb_chamadas (Titulo,Data,Descricao,Equipamento) VALUES ('" + titulo + "','" + data + "','" + descricao + "','" + equipamento+ "')";

                cmd.ExecuteNonQuery(); //executando query
                vcon.Close();//fechando
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro");
            }
        }

        //-------------------------------------------------------------------------------------------------------// Separar Parte Tela 1

        //Pegando campos na tabela do banco de dados equipamentos
        public static DataTable ObterDadosEquipamento(String id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = conectaBanco(); //abrindo
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM  tb_equipamentos WHERE Id = " +id; //query
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);//adapter
                da.Fill(dt);//preenchendo
                vcon.Close(); //fechando
                return dt;
            }
            catch (Exception ex)
            {
                return null;
                MessageBox.Show(ex.Message.ToString() ,"Erro");  
            }
        }

        //Atualizando dados dos campos do formulario na tabela Equipamentos
        public static void AtualizarEquipamento(String nome, String fabricante, decimal serie, string preco, string data, string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = conectaBanco();//abre
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "UPDATE tb_equipamentos SET Nome='"+nome+"',Numero='"+serie+ "',Fabricante='" + fabricante + "',Data='" + data + "',Preco='" + preco + "' WHERE Id='" + id + "' ";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();//fecha
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Erro");
            }
        }

        //Removendo item da tabela de equipamentos
        public static void RemoverEquipamento(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = conectaBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "DELETE FROM tb_equipamentos WHERE Id='" + id + "' ";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Erro");
            }
        }

        //Pegando os itens da tabela de equipamentos do bando de dados
        public static DataTable ObterEquipamentos()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = conectaBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM tb_equipamentos";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt; 
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Inserindo item na tabela de equipamentos do banco de dados
        public static void InserirEquipamento(String nome, String fabricante, decimal serie, decimal preco, string data)
        {
            try
            {
                var vcon = conectaBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText= "INSERT INTO tb_equipamentos (Nome,Numero,Fabricante,Data,Preco) VALUES ('" + nome+ "','"+serie +"','"+ fabricante+"','"+data+"','"+preco+"')";
                
                cmd.ExecuteNonQuery();
                vcon.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
