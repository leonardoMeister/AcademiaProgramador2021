using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademiaProgramador2021
{
    public partial class RegistroChamadas : Form
    {
        public RegistroChamadas()
        {
            InitializeComponent();
        }

        //Atualizando meu datagridview no load, para pegar os dados do BD
        private void RegistroChamadas_Load(object sender, EventArgs e)
        {
            Atualizar();
        }

        //Método de atualizar datagridview e limpar campos de dados
        public void Atualizar()
        {
            BancoDados con = new BancoDados();
            try
            {
                dgv_chamadas.DataSource = BancoDados.ObterChamadas();
                tb_titulo.Text = "";
                tb_id.Text = "";
                tb_equipamento.Text = "";
                tb_descricao.Text = "";
                tb_data.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Erro de conecção Com BD");
            }

        }

        //ação de fechar tela
        private void btn_fecharTela_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //ação de adicionar novo item na tabela 
        private void btn_nova_chamada_Click(object sender, EventArgs e)
        {
            try
            {
                string titulo = tb_titulo.Text;
                string equipamento = tb_equipamento.Text;
                DateTime date = Convert.ToDateTime(tb_data.Text);
                string data = date.Date.ToShortDateString().ToString();
                string descricao = tb_descricao.Text;
                MessageBox.Show("Sucesso");
                BancoDados.InserirChamada(titulo, equipamento, descricao, data);
                Atualizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Preencha os campos corretamente");
            }
        }

        //ação de preencher os campos do formulario ao selecionar uma linha no datagridview
        private void dgv_chamadas_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if (contLinhas > 0)
            {
                DataTable dt = new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                dt = BancoDados.ObterDadosChamadas(vid);
                tb_id.Text = dt.Rows[0].Field<Int64>("Id").ToString();
                tb_data.Text = dt.Rows[0].Field<string>("Data").ToString();
                tb_descricao.Text = dt.Rows[0].Field<string>("Descricao").ToString();
                tb_equipamento.Text = dt.Rows[0].Field<string>("Equipamento").ToString();
                tb_titulo.Text = dt.Rows[0].Field<string>("Titulo").ToString();

            }
        }

        //ação de salvar modificações do item selecionado no datagridview
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                string titulo = tb_titulo.Text;
                string descricao = tb_descricao.Text;
                DateTime date = Convert.ToDateTime(tb_data.Text);
                string data = date.Date.ToShortDateString().ToString();
                string equipamento = tb_equipamento.Text;
                string id = tb_id.Text;
                MessageBox.Show("Sucesso");
                BancoDados.AtualizarChamadas(titulo, equipamento, descricao, data, id);
                Atualizar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Selecione Um Item Na tabela");
            }
        }

        //ação de remover item selecionado no datagriview da tabela
        private void btn_remover_Click(object sender, EventArgs e)
        {
            string vid = tb_id.Text;
            BancoDados.RemoverChamado(vid);          
            Atualizar();
        }
    }
}
