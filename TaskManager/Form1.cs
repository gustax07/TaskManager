using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //- Adicionar as Colunas ao DataGridView -\\
            dgvTask.Columns.Add("colTarefa","Tarefa");
            dgvTask.Columns.Add("colReponsavel", "Responsavel");
            dgvTask.Columns.Add("colSetor", "Setor");
            dgvTask.Columns.Add("colData", "Data Limite");
            // Popular o combox:
            string[] setores = { "Administrador", "Financeiro", "Suporte", "Desenvolvimento","Atendimento" };
            cmbSector.Items.AddRange(setores);
            dgvTask.ForeColor = Color.Black;
            

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txbTask.Text) && txbTask.Text.Length < 3)
            {
                MessageBox.Show("campo tarefas não pode estar vazios", "ERRO!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (String.IsNullOrEmpty(txbResp.Text) && txbResp.Text.Length < 3)
            {
                MessageBox.Show("campo responsavel não pode estar vazios", "ERRO!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (cmbSector.SelectedIndex == -1)
            {
                MessageBox.Show("campo setor não pode estar vazios", "ERRO!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (dtpLimite.Value < DateTime.Today) 
            {
                MessageBox.Show("data invalida", "ERRO!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string task = txbTask.Text;
                string resp = txbResp.Text;
                string sector = cmbSector.Text;
                DateTime limit = dtpLimite.Value;

                dgvTask.Rows.Add(task, resp, sector, limit);

                // limpar
                txbResp.Clear();
                txbTask.Clear();
                cmbSector.SelectedIndex = -1;
                dtpLimite.Value = DateTime.Today;

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTask.Rows.Count > 0)
            {
                int lineSelected = dgvTask.SelectedCells[0].RowIndex;

                var resultado = MessageBox.Show("Tem certeza que deseja remover?", "ATENÇÃO!!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                
                if (resultado == DialogResult.Yes)
                {
                    dgvTask.Rows.RemoveAt(lineSelected);
                }
            }
        }
    }
}
