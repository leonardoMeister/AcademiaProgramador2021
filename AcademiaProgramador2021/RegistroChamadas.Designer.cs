
namespace AcademiaProgramador2021
{
    partial class RegistroChamadas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_chamadas = new System.Windows.Forms.DataGridView();
            this.panel_inferior = new System.Windows.Forms.Panel();
            this.btn_remover = new System.Windows.Forms.Button();
            this.btn_fecharTela = new System.Windows.Forms.Button();
            this.btn_nova_chamada = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.tb_data = new System.Windows.Forms.MaskedTextBox();
            this.tb_equipamento = new System.Windows.Forms.TextBox();
            this.tb_titulo = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label_data = new System.Windows.Forms.Label();
            this.label_equipamento = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.label_titulo = new System.Windows.Forms.Label();
            this.tb_descricao = new System.Windows.Forms.TextBox();
            this.label_descricao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chamadas)).BeginInit();
            this.panel_inferior.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_chamadas
            // 
            this.dgv_chamadas.AllowUserToAddRows = false;
            this.dgv_chamadas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_chamadas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_chamadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_chamadas.EnableHeadersVisualStyles = false;
            this.dgv_chamadas.Location = new System.Drawing.Point(54, 137);
            this.dgv_chamadas.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_chamadas.MultiSelect = false;
            this.dgv_chamadas.Name = "dgv_chamadas";
            this.dgv_chamadas.ReadOnly = true;
            this.dgv_chamadas.RowHeadersVisible = false;
            this.dgv_chamadas.RowHeadersWidth = 51;
            this.dgv_chamadas.RowTemplate.Height = 24;
            this.dgv_chamadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_chamadas.Size = new System.Drawing.Size(498, 119);
            this.dgv_chamadas.TabIndex = 20;
            this.dgv_chamadas.SelectionChanged += new System.EventHandler(this.dgv_chamadas_SelectionChanged);
            // 
            // panel_inferior
            // 
            this.panel_inferior.Controls.Add(this.btn_remover);
            this.panel_inferior.Controls.Add(this.btn_fecharTela);
            this.panel_inferior.Controls.Add(this.btn_nova_chamada);
            this.panel_inferior.Controls.Add(this.btn_salvar);
            this.panel_inferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_inferior.Location = new System.Drawing.Point(0, 268);
            this.panel_inferior.Name = "panel_inferior";
            this.panel_inferior.Size = new System.Drawing.Size(614, 39);
            this.panel_inferior.TabIndex = 5;
            // 
            // btn_remover
            // 
            this.btn_remover.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remover.Location = new System.Drawing.Point(314, 8);
            this.btn_remover.Margin = new System.Windows.Forms.Padding(2);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(148, 25);
            this.btn_remover.TabIndex = 7;
            this.btn_remover.Text = "Remover Chamado";
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // btn_fecharTela
            // 
            this.btn_fecharTela.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fecharTela.Location = new System.Drawing.Point(482, 8);
            this.btn_fecharTela.Margin = new System.Windows.Forms.Padding(2);
            this.btn_fecharTela.Name = "btn_fecharTela";
            this.btn_fecharTela.Size = new System.Drawing.Size(122, 25);
            this.btn_fecharTela.TabIndex = 8;
            this.btn_fecharTela.Text = "Fechar";
            this.btn_fecharTela.UseVisualStyleBackColor = true;
            this.btn_fecharTela.Click += new System.EventHandler(this.btn_fecharTela_Click);
            // 
            // btn_nova_chamada
            // 
            this.btn_nova_chamada.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nova_chamada.Location = new System.Drawing.Point(11, 8);
            this.btn_nova_chamada.Margin = new System.Windows.Forms.Padding(2);
            this.btn_nova_chamada.Name = "btn_nova_chamada";
            this.btn_nova_chamada.Size = new System.Drawing.Size(142, 25);
            this.btn_nova_chamada.TabIndex = 6;
            this.btn_nova_chamada.Text = "Adicionar Chamado";
            this.btn_nova_chamada.UseVisualStyleBackColor = true;
            this.btn_nova_chamada.Click += new System.EventHandler(this.btn_nova_chamada_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.Location = new System.Drawing.Point(170, 8);
            this.btn_salvar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(125, 25);
            this.btn_salvar.TabIndex = 6;
            this.btn_salvar.Text = "Salvar Modificação";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // tb_data
            // 
            this.tb_data.Location = new System.Drawing.Point(385, 54);
            this.tb_data.Mask = "00/00/0000";
            this.tb_data.Name = "tb_data";
            this.tb_data.Size = new System.Drawing.Size(100, 20);
            this.tb_data.TabIndex = 3;
            this.tb_data.ValidatingType = typeof(System.DateTime);
            // 
            // tb_equipamento
            // 
            this.tb_equipamento.Location = new System.Drawing.Point(384, 15);
            this.tb_equipamento.Margin = new System.Windows.Forms.Padding(2);
            this.tb_equipamento.Name = "tb_equipamento";
            this.tb_equipamento.Size = new System.Drawing.Size(172, 20);
            this.tb_equipamento.TabIndex = 2;
            this.tb_equipamento.TabStop = false;
            this.tb_equipamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_titulo
            // 
            this.tb_titulo.Location = new System.Drawing.Point(139, 15);
            this.tb_titulo.Margin = new System.Windows.Forms.Padding(2);
            this.tb_titulo.Name = "tb_titulo";
            this.tb_titulo.Size = new System.Drawing.Size(132, 20);
            this.tb_titulo.TabIndex = 1;
            this.tb_titulo.TabStop = false;
            this.tb_titulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_id
            // 
            this.tb_id.Enabled = false;
            this.tb_id.Location = new System.Drawing.Point(139, 54);
            this.tb_id.Margin = new System.Windows.Forms.Padding(2);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(41, 20);
            this.tb_id.TabIndex = 14;
            this.tb_id.TabStop = false;
            this.tb_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_data
            // 
            this.label_data.AutoSize = true;
            this.label_data.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_data.Location = new System.Drawing.Point(259, 54);
            this.label_data.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_data.Name = "label_data";
            this.label_data.Size = new System.Drawing.Size(121, 17);
            this.label_data.TabIndex = 18;
            this.label_data.Text = "Data De Entrada";
            // 
            // label_equipamento
            // 
            this.label_equipamento.AutoSize = true;
            this.label_equipamento.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_equipamento.Location = new System.Drawing.Point(280, 15);
            this.label_equipamento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_equipamento.Name = "label_equipamento";
            this.label_equipamento.Size = new System.Drawing.Size(100, 17);
            this.label_equipamento.TabIndex = 17;
            this.label_equipamento.Text = "Equipamento";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id.Location = new System.Drawing.Point(111, 54);
            this.label_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(24, 17);
            this.label_id.TabIndex = 16;
            this.label_id.Text = "Id";
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.Location = new System.Drawing.Point(86, 15);
            this.label_titulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(47, 17);
            this.label_titulo.TabIndex = 15;
            this.label_titulo.Text = "Titulo";
            // 
            // tb_descricao
            // 
            this.tb_descricao.Location = new System.Drawing.Point(139, 85);
            this.tb_descricao.Margin = new System.Windows.Forms.Padding(2);
            this.tb_descricao.Multiline = true;
            this.tb_descricao.Name = "tb_descricao";
            this.tb_descricao.Size = new System.Drawing.Size(346, 38);
            this.tb_descricao.TabIndex = 4;
            this.tb_descricao.TabStop = false;
            this.tb_descricao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_descricao
            // 
            this.label_descricao.AutoSize = true;
            this.label_descricao.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_descricao.Location = new System.Drawing.Point(62, 85);
            this.label_descricao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_descricao.Name = "label_descricao";
            this.label_descricao.Size = new System.Drawing.Size(73, 17);
            this.label_descricao.TabIndex = 22;
            this.label_descricao.Text = "Descrição";
            // 
            // RegistroChamadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 307);
            this.Controls.Add(this.tb_descricao);
            this.Controls.Add(this.label_descricao);
            this.Controls.Add(this.tb_data);
            this.Controls.Add(this.tb_equipamento);
            this.Controls.Add(this.tb_titulo);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label_data);
            this.Controls.Add(this.label_equipamento);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.label_titulo);
            this.Controls.Add(this.panel_inferior);
            this.Controls.Add(this.dgv_chamadas);
            this.Name = "RegistroChamadas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Chamadas";
            this.Load += new System.EventHandler(this.RegistroChamadas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chamadas)).EndInit();
            this.panel_inferior.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_chamadas;
        private System.Windows.Forms.Panel panel_inferior;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Button btn_fecharTela;
        private System.Windows.Forms.Button btn_nova_chamada;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.MaskedTextBox tb_data;
        private System.Windows.Forms.TextBox tb_equipamento;
        private System.Windows.Forms.TextBox tb_titulo;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label_data;
        private System.Windows.Forms.Label label_equipamento;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.TextBox tb_descricao;
        private System.Windows.Forms.Label label_descricao;
    }
}