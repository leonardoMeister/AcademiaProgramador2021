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
        
        public static SQLiteConnection conectaBanco()
        {          
            string stringAcessoBD;
            SQLiteConnection conexao;
            stringAcessoBD = "Data Source= C:\\Users\\leozi\\Desktop\\Projeto Academia\\AcademiaProgramador2021\\bin\\Debug\\banco_academia.db;version=3;";
            conexao = new SQLiteConnection(stringAcessoBD);
            conexao.Open();
            MessageBox.Show("Conecção efeturada");
            return conexao;
        }
        
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
        


    }
}
