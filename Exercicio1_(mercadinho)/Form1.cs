using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio1__mercadinho_
{
    public partial class Louja : Form
    {
        int venda = 1; // 'id' da venda
        int itens_grade = 0; // itens 'cadastrados' na venda
        double total = 0; // total de todas as vendas
        double total_temp = 0; // total temporario para caso a venda atual seja cancelada para voltar ao valor anterior
        public Louja()
        {
            InitializeComponent();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_nova_venda_Click(object sender, EventArgs e)
        {
            // cria uma nova venda zerando tudo menos o total, que será armazenado até o programa ser fechado
            venda += 1;
            txt_venda.Text = venda.ToString();
            txt_vlrunit.Clear();
            txt_qntd_selecionado.Clear();
            txt_qntd.Clear();
            txt_desc.Clear();
            dgv.Rows.Clear();
            lbl_itens_grade.Text = "";

            total_temp = total; // armazena o total temporário para caso a próxima venda seja cancelada voltar ao valor anterior
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            // SE algum dos valores forem vazios/nulos dará um erro para o usuário
            if (txt_desc.Text == null || txt_qntd.Text == null || txt_vlrunit.Text == null ||
                txt_desc.Text == "" || txt_qntd.Text == "" || txt_vlrunit.Text == "")
            {
                MessageBox.Show("Não preencheu todos campos obrigatórios", "",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // SENÃO cadastrará o produto na venda sem problemas; somando no total etc
            else
            {
                double vlr_unit = double.Parse(txt_vlrunit.Text);
                int qntd = int.Parse(txt_qntd.Text);

                dgv.Rows.Add(txt_desc.Text, txt_qntd.Text, txt_vlrunit.Text);

                txt_venda.Text = venda.ToString();
                txt_desc.Clear();
                txt_qntd.Clear();
                txt_vlrunit.Clear();

                itens_grade += 1;
                total += vlr_unit * qntd;
                lbl_itens_grade.Text = itens_grade.ToString();
                lbl_total.Text = total.ToString("C");
            }
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            // SE não houver nenhum produto cadastrado na venda, dará um erro pois não há produto a ser removido
            if (dgv.RowCount <= 0)
            {
                MessageBox.Show("Não há vendas para serem excluídas", "",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            // SENÃO remove o produto da venda atual descontando o valor dele do total
            {
                double vlr_unit;
                int qntd;
                txt_venda.Text = venda.ToString();

                vlr_unit = double.Parse(dgv.CurrentRow.Cells["dgv_vlrunit"].Value.ToString());
                qntd = int.Parse(dgv.CurrentRow.Cells["dgv_qntd"].Value.ToString());
                total -= vlr_unit * qntd;
                lbl_total.Text = total.ToString();
                itens_grade -= 1;
                lbl_itens_grade.Text = itens_grade.ToString();

                dgv.Rows.RemoveAt(dgv.CurrentRow.Index);

            }
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            // SE algum dos valores que irá ser colocado no produto for vazio/nulo dará um erro
            if (txt_desc.Text == null || txt_qntd.Text == null || txt_vlrunit.Text == null ||
                txt_desc.Text == "" || txt_qntd.Text == "" || txt_vlrunit.Text == "")
            {
                MessageBox.Show("Não preencheu todos campos obrigatórios", "",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            // SENÃO alterará a célula selecionada pelo usuário de acordo com o que ele colocar nos campos de registro APÓS selecionar algo da linha desejada para a alteração
            else
            {

                double vlr_unit = double.Parse(dgv.CurrentRow.Cells["dgv_vlrunit"].Value.ToString());
                int qntd = int.Parse(dgv.CurrentRow.Cells["dgv_qntd"].Value.ToString());
                total -= vlr_unit * qntd;

                lbl_total.Text = total.ToString("C");
                dgv.CurrentRow.Cells["dgv_desc"].Value = txt_desc.Text;
                dgv.CurrentRow.Cells["dgv_qntd"].Value = txt_qntd.Text;
                dgv.CurrentRow.Cells["dgv_vlrunit"].Value = txt_vlrunit.Text;

                double vlr_unit1 = double.Parse(dgv.CurrentRow.Cells["dgv_vlrunit"].Value.ToString());
                int qntd1 = int.Parse(dgv.CurrentRow.Cells["dgv_qntd"].Value.ToString());
                total += vlr_unit1 * qntd1;
                lbl_total.Text = total.ToString("C");
            }


        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Conta e expõe ao usuário quantas células da tabela forem selecionadas com o CTRL+click
            txt_qntd_selecionado.Text = dgv.SelectedCells.Count.ToString();
            // Pega os dados da célula selecionada e joga nos campos de cadastro acima da tabela para o usuário editar
            txt_desc.Text = dgv.CurrentRow.Cells["dgv_desc"].Value.ToString();
            txt_vlrunit.Text = dgv.CurrentRow.Cells["dgv_vlrunit"].Value.ToString();
            txt_qntd.Text = dgv.CurrentRow.Cells["dgv_qntd"].Value.ToString();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            // Cancela todos os cadastros da venda atual e volta o valor do total para o da venda anterior através do total temporário já descrito no começo do código
            txt_venda.Text = venda.ToString();
            txt_vlrunit.Clear();
            txt_qntd_selecionado.Clear();
            txt_qntd.Clear();
            txt_desc.Clear();
            dgv.Rows.Clear();
            lbl_itens_grade.Text = "";
            total = total_temp;
            lbl_total.Text = total.ToString("C");

        }
    }
}
