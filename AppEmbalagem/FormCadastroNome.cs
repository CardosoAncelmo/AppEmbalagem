using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AppEmbalagem
{
    public partial class FormCadastroNome : Form
    {
        public FormCadastroNome()
        {
            InitializeComponent();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=db_embalagem; password= ");
                objcon.Open();
                MySqlCommand objcomando = new MySqlCommand("insert into nome (re, nome, apelido)  values(?,?,?)", objcon);
                objcomando.Parameters.Add("@re", MySqlDbType.Int32).Value = txtre.Text;
                objcomando.Parameters.Add("@nome", MySqlDbType.VarChar, 30).Value = txtnome.Text;
                objcomando.Parameters.Add("@apelido", MySqlDbType.VarChar, 20).Value = txtapelido.Text;

                objcomando.ExecuteNonQuery();
                MessageBox.Show("Dados Salvo com sucesso!!");

                objcon.Close();

            }
            catch(Exception erro)
            {
                MessageBox.Show("Falha na Conexão com Banco de Dados!!" +erro);

            }
            try
            {
                MySqlConnection conectar = new MySqlConnection("server=localhost;port=3306;User Id=root;database=db_embalagem; password= ");
                conectar.Open();

                MySqlCommand Consulta = new MySqlCommand();
                Consulta.Connection = conectar;
                Consulta.CommandText = "select  re, nome, apelido from nome ";
                MySqlDataReader Resultado = Consulta.ExecuteReader();

                dataGridView1.Rows.Clear();

                if (Resultado.HasRows)
                {
                    while (Resultado.Read())
                    {
                        dataGridView1.Rows.Add(Resultado["re"].ToString(),
                                               Resultado["nome"].ToString(),
                                               Resultado["apelido"].ToString());
                                               
                    }
                }
                else
                {
                    MessageBox.Show("Nenhum registro foi encontrado!!");
                }

                conectar.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex);
            }


        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            txtre.Clear();
            txtnome.Clear();
            txtapelido.Clear();
            txtre.Focus();

        }

        private void txtre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.ProcessTabKey(true);
                e.Handled = true;
            }
        }

        private void txtnome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.ProcessTabKey(true);
                e.Handled = true;
            }
        }

        private void txtapelido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.ProcessTabKey(true);
                e.Handled = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
