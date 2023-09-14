using MySql.Data.MySqlClient;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exemplo_treino
{
    public partial class FormCurso : MaterialForm
    {
        bool isAlteracao = false;
        string cs = @"server=localhost;" +
                    "uid=root;" +
                    "pwd=;" +
                    "database=academico";
        public FormCurso()
        {
            InitializeComponent();
        }

        private void txtNome_Click(object sender, EventArgs e)
        {

        }

        private void Editar()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                isAlteracao = true;
                var linha = dataGridView1.SelectedRows[0];
                txtid.Text = linha.Cells["id"].Value.ToString();
                txtdata.Text = linha.Cells["ano_criacao"].Value.ToString();
                txtNome.Text = linha.Cells["nome"].Value.ToString();
                txttipo.Text = linha.Cells["tipo"].Value.ToString();
                tabpageprof.SelectedIndex = 0;
                txtNome.Focus();
            }
        }
        private void LimpaCampos()
        {
            isAlteracao = false;
            foreach (var control in tabpageprof.Controls)
            {
                if (control is MaterialTextBoxEdit)
                {
                    ((MaterialTextBoxEdit)control).Clear();
                }
                if (control is MaterialMaskedTextBox)
                {
                    ((MaterialMaskedTextBox)control).Clear();
                }
            }
        }

        private void carregaGrid()
        {
            var con = new MySqlConnection(cs);
            con.Open();
            var sql = "SELECT * FROM curso";
            var sqlAd = new MySqlDataAdapter();
            sqlAd.SelectCommand = new MySqlCommand(sql, con);
            var dt = new DataTable();
            sqlAd.Fill(dt);

            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Salvar()
        {
            var con = new MySqlConnection(cs);
            con.Open();
            var sql = "";

            if (isAlteracao)
            {
                sql = "UPDATE curso set " + "ano_criacao=@ano_criacao," + "nome= @nome," + "tipo=@tipo" + " where id = @id";

            }
            else
            {
                sql = "INSERT INTO curso" + "(nome, tipo, ano_criacao)" +
                              "values" + "(@nome, @tipo, @ano_criacao)";

            }
            var cmd = new MySqlCommand(sql, con);
            DateTime.TryParse(txtdata.Text, out var AnoCriacao);
            cmd.Parameters.AddWithValue("@ano_criacao", AnoCriacao);
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@tipo", txttipo.Text);

            if (isAlteracao)
                cmd.Parameters.AddWithValue("@id", txtid.Text);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            LimpaCampos();
        }

        private bool ValidarFormulario()
        {
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Nome é Obrigátoria", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();

                return false;
            }
            if (string.IsNullOrEmpty(txtdata.Text))
            {
                MessageBox.Show("Ano de Criação é Obrigátorio", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtdata.Focus();

                return false;
            }
            return true;
        }

        private void Deletar(int id)
        {
            var con = new MySqlConnection(cs);
            con.Open();
            var sql = "DELETE FROM curso WHERE  id = @id";
            var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Prepare();
            cmd.ExecuteNonQuery();

        }
        private void materialButton4_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            tabpageprof.SelectedIndex = 0;
            txtNome.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarFormulario())
            {
                Salvar();
                tabpageprof.SelectedIndex = 1;
            }
        }

        private void materialButton5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Deseja deletar", "IFSP", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                    Deletar(id);
                    carregaGrid();

                }
                else
                {
                    MessageBox.Show("Selecione algum aluno", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja cancelar a operação?", "IFSP", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpaCampos();
                tabpageprof.SelectedIndex = 1;
                txtNome.Focus();
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Editar();
        }

        private void txtid_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            carregaGrid();
        }
    }
}
