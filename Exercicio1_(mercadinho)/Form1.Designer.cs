namespace Exercicio1__mercadinho_
{
    partial class Louja
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_venda = new System.Windows.Forms.TextBox();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_qntd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_vlrunit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.txt_qntd_selecionado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_inserir = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_nova_venda = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_itens_grade = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgv_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_qntd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_vlrunit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Venda: ";
            // 
            // txt_venda
            // 
            this.txt_venda.BackColor = System.Drawing.Color.White;
            this.txt_venda.Enabled = false;
            this.txt_venda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_venda.ForeColor = System.Drawing.Color.Red;
            this.txt_venda.Location = new System.Drawing.Point(127, 7);
            this.txt_venda.Name = "txt_venda";
            this.txt_venda.Size = new System.Drawing.Size(42, 22);
            this.txt_venda.TabIndex = 1;
            this.txt_venda.Text = "1";
            this.txt_venda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_desc
            // 
            this.txt_desc.BackColor = System.Drawing.Color.White;
            this.txt_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_desc.ForeColor = System.Drawing.Color.Black;
            this.txt_desc.Location = new System.Drawing.Point(127, 35);
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(198, 22);
            this.txt_desc.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descrição:";
            // 
            // txt_qntd
            // 
            this.txt_qntd.BackColor = System.Drawing.Color.White;
            this.txt_qntd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qntd.ForeColor = System.Drawing.Color.Black;
            this.txt_qntd.Location = new System.Drawing.Point(127, 63);
            this.txt_qntd.Name = "txt_qntd";
            this.txt_qntd.Size = new System.Drawing.Size(74, 22);
            this.txt_qntd.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantidade:";
            // 
            // txt_vlrunit
            // 
            this.txt_vlrunit.BackColor = System.Drawing.Color.White;
            this.txt_vlrunit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_vlrunit.ForeColor = System.Drawing.Color.Black;
            this.txt_vlrunit.Location = new System.Drawing.Point(127, 91);
            this.txt_vlrunit.Name = "txt_vlrunit";
            this.txt_vlrunit.Size = new System.Drawing.Size(74, 22);
            this.txt_vlrunit.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Valor Unitário:";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_desc,
            this.dgv_qntd,
            this.dgv_vlrunit});
            this.dgv.Location = new System.Drawing.Point(16, 152);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(439, 222);
            this.dgv.TabIndex = 8;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // txt_qntd_selecionado
            // 
            this.txt_qntd_selecionado.BackColor = System.Drawing.Color.White;
            this.txt_qntd_selecionado.Enabled = false;
            this.txt_qntd_selecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qntd_selecionado.ForeColor = System.Drawing.Color.Black;
            this.txt_qntd_selecionado.Location = new System.Drawing.Point(243, 393);
            this.txt_qntd_selecionado.Name = "txt_qntd_selecionado";
            this.txt_qntd_selecionado.Size = new System.Drawing.Size(74, 22);
            this.txt_qntd_selecionado.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Quantidade de Item Selecionado:";
            // 
            // btn_inserir
            // 
            this.btn_inserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inserir.Location = new System.Drawing.Point(243, 78);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(105, 68);
            this.btn_inserir.TabIndex = 11;
            this.btn_inserir.Text = "Inserir";
            this.btn_inserir.UseVisualStyleBackColor = true;
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // btn_remover
            // 
            this.btn_remover.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remover.Location = new System.Drawing.Point(354, 78);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(105, 68);
            this.btn_remover.TabIndex = 12;
            this.btn_remover.Text = "Remover";
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alterar.Location = new System.Drawing.Point(354, 380);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(101, 33);
            this.btn_alterar.TabIndex = 13;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(354, 419);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(101, 33);
            this.btn_cancelar.TabIndex = 14;
            this.btn_cancelar.Text = "Cancelar Venda";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_nova_venda
            // 
            this.btn_nova_venda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nova_venda.Location = new System.Drawing.Point(354, 458);
            this.btn_nova_venda.Name = "btn_nova_venda";
            this.btn_nova_venda.Size = new System.Drawing.Size(101, 33);
            this.btn_nova_venda.TabIndex = 15;
            this.btn_nova_venda.Text = "Nova Venda";
            this.btn_nova_venda.UseVisualStyleBackColor = true;
            this.btn_nova_venda.Click += new System.EventHandler(this.btn_nova_venda_Click);
            // 
            // btn_fechar
            // 
            this.btn_fechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fechar.Location = new System.Drawing.Point(354, 497);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(101, 33);
            this.btn_fechar.TabIndex = 16;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(189, 432);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Total:";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbl_total.Location = new System.Drawing.Point(243, 432);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(0, 20);
            this.lbl_total.TabIndex = 18;
            // 
            // lbl_itens_grade
            // 
            this.lbl_itens_grade.AutoSize = true;
            this.lbl_itens_grade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itens_grade.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbl_itens_grade.Location = new System.Drawing.Point(243, 471);
            this.lbl_itens_grade.Name = "lbl_itens_grade";
            this.lbl_itens_grade.Size = new System.Drawing.Size(0, 20);
            this.lbl_itens_grade.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(117, 471);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Itens na Grade:";
            // 
            // dgv_desc
            // 
            this.dgv_desc.HeaderText = "Descrição";
            this.dgv_desc.Name = "dgv_desc";
            this.dgv_desc.ReadOnly = true;
            // 
            // dgv_qntd
            // 
            this.dgv_qntd.HeaderText = "Quantidade";
            this.dgv_qntd.Name = "dgv_qntd";
            this.dgv_qntd.ReadOnly = true;
            // 
            // dgv_vlrunit
            // 
            this.dgv_vlrunit.HeaderText = "Vlr. Unitário";
            this.dgv_vlrunit.Name = "dgv_vlrunit";
            this.dgv_vlrunit.ReadOnly = true;
            // 
            // Louja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 540);
            this.Controls.Add(this.lbl_itens_grade);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.btn_nova_venda);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.btn_inserir);
            this.Controls.Add(this.txt_qntd_selecionado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.txt_vlrunit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_qntd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_desc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_venda);
            this.Controls.Add(this.label1);
            this.Name = "Louja";
            this.Text = "Louja";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_venda;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_qntd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_vlrunit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox txt_qntd_selecionado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_inserir;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_nova_venda;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_itens_grade;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_qntd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_vlrunit;
    }
}

