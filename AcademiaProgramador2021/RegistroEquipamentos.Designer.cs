
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
            this.dgv_equipamentos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_fecharTela = new System.Windows.Forms.Button();
            this.btn_novo_equipamento = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.label_id = new System.Windows.Forms.Label();
            this.label_preco = new System.Windows.Forms.Label();
            this.label_numero_serie = new System.Windows.Forms.Label();
            this.label_fabricante = new System.Windows.Forms.Label();
            this.label_data = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label_nome = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_remover = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_equipamentos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_equipamentos
            // 
            this.dgv_equipamentos.AllowUserToAddRows = false;
            this.dgv_equipamentos.AllowUserToDeleteRows = false;
            this.dgv_equipamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_equipamentos.Location = new System.Drawing.Point(61, 91);
            this.dgv_equipamentos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_equipamentos.Name = "dgv_equipamentos";
            this.dgv_equipamentos.ReadOnly = true;
            this.dgv_equipamentos.RowHeadersWidth = 51;
            this.dgv_equipamentos.RowTemplate.Height = 24;
            this.dgv_equipamentos.Size = new System.Drawing.Size(652, 219);
            this.dgv_equipamentos.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_remover);
            this.panel1.Controls.Add(this.btn_fecharTela);
            this.panel1.Controls.Add(this.btn_novo_equipamento);
            this.panel1.Controls.Add(this.btn_salvar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 318);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 37);
            this.panel1.TabIndex = 1;
            // 
            // btn_fecharTela
            // 
            this.btn_fecharTela.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fecharTela.Location = new System.Drawing.Point(567, 7);
            this.btn_fecharTela.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.btn_novo_equipamento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.btn_salvar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(383, 52);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(41, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TabStop = false;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(617, 14);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(150, 20);
            this.textBox3.TabIndex = 9;
            this.textBox3.TabStop = false;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(183, 52);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(109, 20);
            this.textBox4.TabIndex = 10;
            this.textBox4.TabStop = false;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(580, 52);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(172, 20);
            this.textBox5.TabIndex = 11;
            this.textBox5.TabStop = false;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(373, 14);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(113, 20);
            this.textBox6.TabIndex = 12;
            this.textBox6.TabStop = false;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.label_nome.Click += new System.EventHandler(this.label_nome_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(68, 14);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 20);
            this.textBox2.TabIndex = 8;
            this.textBox2.TabStop = false;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
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
            // 
            // RegistroEquipamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 355);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_data);
            this.Controls.Add(this.label_fabricante);
            this.Controls.Add(this.label_numero_serie);
            this.Controls.Add(this.label_preco);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.label_nome);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_equipamentos);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RegistroEquipamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Equipamentos";
            this.Load += new System.EventHandler(this.RegistroEquipamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_equipamentos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_equipamentos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_fecharTela;
        private System.Windows.Forms.Button btn_novo_equipamento;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_preco;
        private System.Windows.Forms.Label label_numero_serie;
        private System.Windows.Forms.Label label_fabricante;
        private System.Windows.Forms.Label label_data;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label_nome;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_remover;
    }
}