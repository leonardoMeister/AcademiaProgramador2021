
namespace AcademiaProgramador2021
{
    partial class RegistroEquipamentos
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_equipamentos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_remover = new System.Windows.Forms.Button();
            this.btn_fecharTela = new System.Windows.Forms.Button();
            this.btn_novo_equipamento = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.label_id = new System.Windows.Forms.Label();
            this.label_preco = new System.Windows.Forms.Label();
            this.label_numero_serie = new System.Windows.Forms.Label();
            this.label_fabricante = new System.Windows.Forms.Label();
            this.label_data = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_fabricante = new System.Windows.Forms.TextBox();
            this.label_nome = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.tb_data = new System.Windows.Forms.MaskedTextBox();
            this.tb_numero = new System.Windows.Forms.MaskedTextBox();
            this.tb_preco = new System.Windows.Forms.TextBox();
            this.bancoDadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_equipamentos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bancoDadosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_equipamentos
            // 
            this.dgv_equipamentos.AllowUserToAddRows = false;
            this.dgv_equipamentos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_equipamentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_equipamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_equipamentos.Location = new System.Drawing.Point(85, 91);
            this.dgv_equipamentos.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_equipamentos.MultiSelect = false;
            this.dgv_equipamentos.Name = "dgv_equipamentos";
            this.dgv_equipamentos.ReadOnly = true;
            this.dgv_equipamentos.RowHeadersVisible = false;
            this.dgv_equipamentos.RowHeadersWidth = 51;
            this.dgv_equipamentos.RowTemplate.Height = 24;
            this.dgv_equipamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_equipamentos.Size = new System.Drawing.Size(597, 219);
            this.dgv_equipamentos.TabIndex = 0;
            this.dgv_equipamentos.SelectionChanged += new System.EventHandler(this.dgv_equipamentos_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_remover);
            this.panel1.Controls.Add(this.btn_fecharTela);
            this.panel1.Controls.Add(this.btn_novo_equipamento);
            this.panel1.Controls.Add(this.btn_salvar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 318);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 37);
            this.panel1.TabIndex = 1;
            // 
            // btn_remover
            // 
            this.btn_remover.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remover.Location = new System.Drawing.Point(395, 7);
            this.btn_remover.Margin = new System.Windows.Forms.Padding(2);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(148, 25);
            this.btn_remover.TabIndex = 4;
            this.btn_remover.Text = "Remover Equipamento";
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // btn_fecharTela
            // 
            this.btn_fecharTela.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fecharTela.Location = new System.Drawing.Point(567, 7);
            this.btn_fecharTela.Margin = new System.Windows.Forms.Padding(2);
            this.btn_fecharTela.Name = "btn_fecharTela";
            this.btn_fecharTela.Size = new System.Drawing.Size(122, 25);
            this.btn_fecharTela.TabIndex = 3;
            this.btn_fecharTela.Text = "Fechar Tela";
            this.btn_fecharTela.UseVisualStyleBackColor = true;
            this.btn_fecharTela.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_novo_equipamento
            // 
            this.btn_novo_equipamento.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_novo_equipamento.Location = new System.Drawing.Point(86, 7);
            this.btn_novo_equipamento.Margin = new System.Windows.Forms.Padding(2);
            this.btn_novo_equipamento.Name = "btn_novo_equipamento";
            this.btn_novo_equipamento.Size = new System.Drawing.Size(122, 25);
            this.btn_novo_equipamento.TabIndex = 1;
            this.btn_novo_equipamento.Text = "Novo Equipamento";
            this.btn_novo_equipamento.UseVisualStyleBackColor = true;
            this.btn_novo_equipamento.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.Location = new System.Drawing.Point(242, 7);
            this.btn_salvar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(122, 25);
            this.btn_salvar.TabIndex = 0;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id.Location = new System.Drawing.Point(355, 52);
            this.label_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(24, 17);
            this.label_id.TabIndex = 3;
            this.label_id.Text = "Id";
            // 
            // label_preco
            // 
            this.label_preco.AutoSize = true;
            this.label_preco.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_preco.Location = new System.Drawing.Point(36, 52);
            this.label_preco.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_preco.Name = "label_preco";
            this.label_preco.Size = new System.Drawing.Size(143, 17);
            this.label_preco.TabIndex = 4;
            this.label_preco.Text = "Preço Equipamento";
            // 
            // label_numero_serie
            // 
            this.label_numero_serie.AutoSize = true;
            this.label_numero_serie.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_numero_serie.Location = new System.Drawing.Point(511, 14);
            this.label_numero_serie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_numero_serie.Name = "label_numero_serie";
            this.label_numero_serie.Size = new System.Drawing.Size(102, 17);
            this.label_numero_serie.TabIndex = 5;
            this.label_numero_serie.Text = "Número Série";
            // 
            // label_fabricante
            // 
            this.label_fabricante.AutoSize = true;
            this.label_fabricante.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fabricante.Location = new System.Drawing.Point(496, 52);
            this.label_fabricante.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_fabricante.Name = "label_fabricante";
            this.label_fabricante.Size = new System.Drawing.Size(80, 17);
            this.label_fabricante.TabIndex = 6;
            this.label_fabricante.Text = "Fabricante";
            // 
            // label_data
            // 
            this.label_data.AutoSize = true;
            this.label_data.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_data.Location = new System.Drawing.Point(230, 14);
            this.label_data.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_data.Name = "label_data";
            this.label_data.Size = new System.Drawing.Size(139, 17);
            this.label_data.TabIndex = 7;
            this.label_data.Text = "Data De Fabricação";
            // 
            // tb_id
            // 
            this.tb_id.Enabled = false;
            this.tb_id.Location = new System.Drawing.Point(383, 52);
            this.tb_id.Margin = new System.Windows.Forms.Padding(2);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(41, 20);
            this.tb_id.TabIndex = 0;
            this.tb_id.TabStop = false;
            this.tb_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_fabricante
            // 
            this.tb_fabricante.Location = new System.Drawing.Point(580, 52);
            this.tb_fabricante.Margin = new System.Windows.Forms.Padding(2);
            this.tb_fabricante.Name = "tb_fabricante";
            this.tb_fabricante.Size = new System.Drawing.Size(172, 20);
            this.tb_fabricante.TabIndex = 11;
            this.tb_fabricante.TabStop = false;
            this.tb_fabricante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_nome
            // 
            this.label_nome.AutoSize = true;
            this.label_nome.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nome.Location = new System.Drawing.Point(15, 14);
            this.label_nome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_nome.Name = "label_nome";
            this.label_nome.Size = new System.Drawing.Size(49, 17);
            this.label_nome.TabIndex = 2;
            this.label_nome.Text = "Nome";
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(68, 14);
            this.tb_nome.Margin = new System.Windows.Forms.Padding(2);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(132, 20);
            this.tb_nome.TabIndex = 8;
            this.tb_nome.TabStop = false;
            this.tb_nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_data
            // 
            this.tb_data.Location = new System.Drawing.Point(374, 14);
            this.tb_data.Mask = "00/00/0000";
            this.tb_data.Name = "tb_data";
            this.tb_data.Size = new System.Drawing.Size(100, 20);
            this.tb_data.TabIndex = 13;
            this.tb_data.ValidatingType = typeof(System.DateTime);
            // 
            // tb_numero
            // 
            this.tb_numero.Location = new System.Drawing.Point(618, 11);
            this.tb_numero.Mask = "00000";
            this.tb_numero.Name = "tb_numero";
            this.tb_numero.Size = new System.Drawing.Size(40, 20);
            this.tb_numero.TabIndex = 14;
            this.tb_numero.ValidatingType = typeof(int);
            // 
            // tb_preco
            // 
            this.tb_preco.Location = new System.Drawing.Point(183, 52);
            this.tb_preco.Margin = new System.Windows.Forms.Padding(2);
            this.tb_preco.Name = "tb_preco";
            this.tb_preco.Size = new System.Drawing.Size(109, 20);
            this.tb_preco.TabIndex = 10;
            this.tb_preco.TabStop = false;
            this.tb_preco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bancoDadosBindingSource
            // 
            this.bancoDadosBindingSource.DataSource = typeof(AcademiaProgramador2021.BancoDados);
            // 
            // RegistroEquipamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 355);
            this.Controls.Add(this.tb_numero);
            this.Controls.Add(this.tb_data);
            this.Controls.Add(this.tb_fabricante);
            this.Controls.Add(this.tb_preco);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label_data);
            this.Controls.Add(this.label_fabricante);
            this.Controls.Add(this.label_numero_serie);
            this.Controls.Add(this.label_preco);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.label_nome);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_equipamentos);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RegistroEquipamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Equipamentos";
            this.Load += new System.EventHandler(this.RegistroEquipamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_equipamentos)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bancoDadosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_equipamentos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_preco;
        private System.Windows.Forms.Label label_numero_serie;
        private System.Windows.Forms.Label label_fabricante;
        private System.Windows.Forms.Label label_data;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_fabricante;
        private System.Windows.Forms.Label label_nome;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Button btn_fecharTela;
        private System.Windows.Forms.Button btn_novo_equipamento;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.MaskedTextBox tb_data;
        private System.Windows.Forms.BindingSource bancoDadosBindingSource;
        private System.Windows.Forms.MaskedTextBox tb_numero;
        private System.Windows.Forms.TextBox tb_preco;
    }
}