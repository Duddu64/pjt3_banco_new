using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace exemplo_treino
{
    public partial class FormCadastro : MaterialForm
    {
 
        bool isAlteracao = false;
        string cs = @"server=localhost;" +
                    "uid=root;" +
                    "pwd=;" +
                    "database=academico";
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {

        }

        private void materialTextBoxEdit1_Click(object sender, EventArgs e)
        {

        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void Editar()
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                isAlteracao = true;
                var linha = dataGridView1.SelectedRows[0];
                txtid.Text = linha.Cells["id"].Value.ToString();
                txtmatricula.Text = linha.Cells["matricula"].Value.ToString();
                txtdata.Text = linha.Cells["dt_nascimento"].Value.ToString();
                txtNome.Text = linha.Cells["nome"].Value.ToString();
                txtendereco.Text = linha.Cells["endereco"].Value.ToString();
                txtbairro.Text = linha.Cells["bairro"].Value.ToString();
                txtcidade.Text = linha.Cells["cidade"].Value.ToString();
                txtuf.Text = linha.Cells["estado"].Value.ToString();
                txtsenha.Text = linha.Cells["senha"].Value.ToString();
                tabpage.SelectedIndex = 0;
                txtmatricula.Focus();
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (ValidarFormulario())
            {
                Salvar();
                tabpage.SelectedIndex = 1;
            }
        }

        private void LimpaCampos()
        {
            isAlteracao = false;
            foreach (var control in tabPage1.Controls)
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
            var sql = "SELECT * FROM aluno";
            var sqlAd = new MySqlDataAdapter();
            sqlAd.SelectCommand = new MySqlCommand(sql, con);
            var dt = new DataTable();
            sqlAd.Fill(dt);

            dataGridView1.DataSource= dt;
            con.Close();
        }

        private void Salvar()
        {
            var con = new MySqlConnection(cs);
            con.Open();
            var sql = "";

            if (isAlteracao)
            {
                sql = "UPDATE aluno set " + "matricula= @matricula," + "dt_nascimento=@dt_nascimento," + "nome= @nome," + "endereco=@endereco," + "bairro = @bairro," + "cidade = @cidade," + "estado = @estado," + "senha = @senha" + " where id = @id";
                
            }
            else
            {
                sql = "INSERT INTO aluno" + "(matricula, dt_nascimento, nome, endereco, bairro, cidade, estado, senha)" +
                              "values" + "(@matricula, @dt_nascimento, @nome, @endereco, @bairro, @cidade, @estado, @senha)";

            }
            var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@matricula", txtmatricula.Text);
            DateTime.TryParse(txtdata.Text, out var dataNascimento);
            cmd.Parameters.AddWithValue("@dt_nascimento", dataNascimento);
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@endereco", txtendereco.Text);
            cmd.Parameters.AddWithValue("@bairro", txtbairro.Text);
            cmd.Parameters.AddWithValue("@cidade", txtcidade.Text);
            cmd.Parameters.AddWithValue("@estado", txtuf.Text);
            cmd.Parameters.AddWithValue("@senha", txtsenha.Text);
            if (isAlteracao)
                cmd.Parameters.AddWithValue("@id", txtid.Text);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            LimpaCampos();
        }

        private bool ValidarFormulario()
        {
            if (string.IsNullOrEmpty(txtmatricula.Text))
            {
                MessageBox.Show("Mátricula é Obrigátoria", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmatricula.Focus();

                return false;
            }
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Nome é Obrigátoria", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();

                return false;
            }
            if (string.IsNullOrEmpty(txtsenha.Text))
            {
                MessageBox.Show("Senha é Obrigátoria", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtsenha.Focus();

                return false;
            }
            if (string.IsNullOrEmpty(txtdata.Text))
            {
                MessageBox.Show("Data é Obrigátoria", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtdata.Focus();

                return false;
            }
            if (string.IsNullOrEmpty(txtcidade.Text))
            {
                MessageBox.Show("Cidade é Obrigátoria", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcidade.Focus();

                return false;
            }
            if (string.IsNullOrEmpty(txtendereco.Text))
            {
                MessageBox.Show("Cidade é Obrigátoria", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtendereco.Focus();

                return false;
            }
            return true;
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            carregaGrid();
        }

        private void materialButton5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count>0)
            {
                if(MessageBox.Show("Deseja deletar", "IFSP", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

        private void Deletar(int id)
        {
            var con = new MySqlConnection(cs);
            con.Open();
            var sql = "DELETE FROM ALUNO WHERE  id = @id";
            var cmd = new MySqlCommand (sql, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Prepare();
            cmd.ExecuteNonQuery();

        }

        private void materialButton4_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            tabpage.SelectedIndex= 0;
            txtmatricula.Focus();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja cancelar a operação?", "IFSP", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpaCampos();
                tabpage.SelectedIndex = 1;
                txtmatricula.Focus();
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Editar();
        }

        private void tabpage_Enter(object sender, EventArgs e)
        {
            carregaGrid();
        }

        private void txtuf_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
