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
    public partial class RegistroEquipamentos : Form
    {
         
        public RegistroEquipamentos()
        {
            InitializeComponent();
        }

        //Atualizando meu datagridview no load, para pegar os dados do BD
        private void RegistroEquipamentos_Load(object sender, EventArgs e)
        {
            atualizar();
        }

        //Método de atualizar datagridview e limpar campos de dados
        private void atualizar()
        {
            BancoDados con = new BancoDados();
            try
            {
                dgv_equipamentos.DataSource = BancoDados.ObterEquipamentos();
                tb_preco.Text = "";
                tb_numero.Text = "";
                tb_nome.Text = "";
                tb_id.Text = "";
                tb_fabricante.Text = "";
                tb_data.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Erro de conecção Com BD");
            }
        }

        //ação de Salvar modificações na tabela
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = tb_nome.Text;
                string fabricante = tb_fabricante.Text;
                DateTime date = Convert.ToDateTime(tb_data.Text);
                string data = date.Date.ToShortDateString().ToString();
                decimal numeroSerie = Convert.ToDecimal(tb_numero.Text);
                string preco = tb_preco.Text;
                string vid =  tb_id.Text;
                MessageBox.Show("Sucesso");
                BancoDados.AtualizarEquipamento(nome, fabricante, numeroSerie, preco, data, vid);
                atualizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Selecione um item na tabela");
            }
        }

        //ação de adicionar item na tabela
        private void button2_Click(object sender, EventArgs e)
        {
            try
            { 
                string nome = tb_nome.Text;
                string fabricante = tb_fabricante.Text;
                DateTime date = Convert.ToDateTime(tb_data.Text);
                string data =  date.Date.ToShortDateString().ToString();
                decimal numeroSerie = Convert.ToDecimal( tb_numero.Text);
                decimal preco = Convert.ToDecimal(tb_preco.Text);
                MessageBox.Show("Sucesso");
                BancoDados.InserirEquipamento(nome, fabricante, numeroSerie, preco, data);
                atualizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Preencha os campos corretamente");
            }
        }

        //ação fechar tela
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //ação de preencher os campos do formulario ao selecionar uma linha no datagridview
        private void dgv_equipamentos_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if (contLinhas>0)
            {
                DataTable dt = new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                dt =BancoDados.ObterDadosEquipamento(vid);
                tb_id.Text = dt.Rows[0].Field<Int64>("id").ToString();
                tb_nome.Text = dt.Rows[0].Field<string>("Nome").ToString();
                tb_numero.Text = dt.Rows[0].Field<decimal>("Numero").ToString();
                tb_fabricante.Text = dt.Rows[0].Field<string>("Fabricante").ToString();
                tb_data.Text = dt.Rows[0].Field<string>("Data").ToString();
                tb_preco.Text = dt.Rows[0].Field<decimal>("Preco").ToString();
            }
        }

        //Ação de remover item selecionado no datagridview da tabela
        private void btn_remover_Click(object sender, EventArgs e)
        {
            string vid = tb_id.Text;
            BancoDados.RemoverEquipamento(vid);
            atualizar();
        }
    }
}
