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
        int venda = 1;
        int itens_grade = 0;
        double total = 0;
        double total_temp = 0;
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
            venda += 1;
            txt_venda.Text = venda.ToString();
            txt_vlrunit.Clear();
            txt_qntd_selecionado.Clear();
            txt_qntd.Clear();
            txt_desc.Clear();
            dgv.Rows.Clear();
            lbl_itens_grade.Text = "";

            total_temp = total;
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            if (txt_desc.Text == null || txt_qntd.Text == null || txt_vlrunit.Text == null ||
                txt_desc.Text == "" || txt_qntd.Text == "" || txt_vlrunit.Text == "")
            {
                MessageBox.Show("Não preencheu todos campos obrigatórios", "",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            if (dgv.RowCount <= 0)
            {
                MessageBox.Show("Não há vendas para serem excluídas", "",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
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
            if (txt_desc.Text == null || txt_qntd.Text == null || txt_vlrunit.Text == null ||
                txt_desc.Text == "" || txt_qntd.Text == "" || txt_vlrunit.Text == "")
            {
                MessageBox.Show("Não preencheu todos campos obrigatórios", "",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
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
            txt_qntd_selecionado.Text = dgv.SelectedCells.Count.ToString();
            txt_desc.Text = dgv.CurrentRow.Cells["dgv_desc"].Value.ToString();
            txt_vlrunit.Text = dgv.CurrentRow.Cells["dgv_vlrunit"].Value.ToString();
            txt_qntd.Text = dgv.CurrentRow.Cells["dgv_qntd"].Value.ToString();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
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
