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
 
        bool isAlteracao = true;
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

            if (isAlteracao)
            {
                var sql = "INSERT INTO aluno" + "(matricula, dt_nascimento, nome, endereco, bairro, cidade, estado, senha)" +
                            "values" + "(@matricula, @dt_nascimento, @nome, @endereco, @bairro, @cidade, @estado, @senha)";
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
                cmd.Prepare();
                cmd.ExecuteNonQuery();

            }
            else
            {

            }
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
    }
}
