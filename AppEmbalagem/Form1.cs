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
    public partial class FormPrincipal : Form
    {
       DateTime horaa;
        public FormPrincipal()
        {
            InitializeComponent();
        }
       

        private void button2_Click(object sender, EventArgs e)
        {
            txtre.Clear();
            txtnome.Clear();
            txtapelido.Clear();
            txtcaixa.Clear();
            txtfluxo.Clear();
            txtre.Focus();
        }

        private void colaboradoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroNome Formcad = new FormCadastroNome();
            Formcad.ShowDialog();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            horaa = DateTime.Now;                                                                   
            labeldata.Text = horaa.ToString("yyyy'-'MM'-'dd");
            labelhoje.Text = horaa.ToLongDateString();
        }    
        private void btnsalvar_Click(object sender, EventArgs e)
        {

            if (txtre.Text == "") 
                MessageBox.Show("Por favor, preencha todos os campos!!");
            txtre.Focus();

            DateTime dia;
            dia = DateTime.Now;
            DateTime hora;
            hora = DateTime.Now;
           
            try
            {
                MySqlConnection objconexao = new MySqlConnection("server=localhost;port=3306;User Id=root;database=db_embalagem; password= ");
                objconexao.Open();

                            
                

                MySqlCommand objcom = new MySqlCommand("insert into producao (re, nome, apelido, caixas, dia, fluxo, hora)  values(?,?,?,?,?,?,?)", objconexao);
                objcom.Parameters.Add("@re", MySqlDbType.Int16).Value = txtre.Text;
                objcom.Parameters.Add("@nome", MySqlDbType.VarChar, 30).Value = txtnome.Text;
                objcom.Parameters.Add("@apelido", MySqlDbType.VarChar, 20).Value = txtapelido.Text;
                objcom.Parameters.Add("@caixas", MySqlDbType.Int16).Value = txtcaixa.Text;
                objcom.Parameters.Add("@dia", MySqlDbType.DateTime, 30).Value = dia;
                objcom.Parameters.Add("@fluxo", MySqlDbType.Int16).Value = txtfluxo.Text;
                objcom.Parameters.Add("@hora", MySqlDbType.DateTime, 30).Value = hora;
                objcom.ExecuteNonQuery();
                MessageBox.Show("Dados Salvo com sucesso!!");
                objconexao.Close();

                txtre.Clear();
                txtnome.Clear();
                txtapelido.Clear();
                txtcaixa.Clear();
                txtfluxo.Clear();
                txtre.Focus();

                MySqlCommand conexaodois = new MySqlCommand("select sum(caixas) from producao where dia = ?", objconexao);
                conexaodois.Parameters.Add("@dia", MySqlDbType.DateTime).Value = labeldata.Text;
                objconexao.Open();

                conexaodois.CommandType = CommandType.Text;

                MySqlDataReader calc;
                calc = conexaodois.ExecuteReader();
                calc.Read();
                txttotalhoje.Text = calc.GetString(0);
                objconexao.Close();

                MySqlCommand conexaodois1 = new MySqlCommand("select  sum(caixas) from producao where dia = ? and nome = 'Aline' ", objconexao);
                conexaodois1.Parameters.Add("@dia", MySqlDbType.DateTime).Value = labeldata.Text;
                objconexao.Open();

                conexaodois1.CommandType = CommandType.Text;

                MySqlDataReader calc1;
                calc1 = conexaodois1.ExecuteReader();
                calc1.Read();
                lbAline.Text = calc1.GetString(0);
                objconexao.Close();

                MySqlCommand conexaodois2 = new MySqlCommand("select  sum(caixas) from producao where dia = ? and nome = 'Ana' ", objconexao);
                conexaodois2.Parameters.Add("@dia", MySqlDbType.DateTime).Value = labeldata.Text;
                objconexao.Open();

                conexaodois2.CommandType = CommandType.Text;

                MySqlDataReader calc2;
                calc2 = conexaodois2.ExecuteReader();
                calc2.Read();
                lbAna.Text = calc2.GetString(0);
                objconexao.Close();

                MySqlCommand conexaodois3 = new MySqlCommand("select  sum(caixas) from producao where dia = ? and nome = 'Beatriz' ", objconexao);
                conexaodois3.Parameters.Add("@dia", MySqlDbType.DateTime).Value = labeldata.Text;
                objconexao.Open();

                conexaodois3.CommandType = CommandType.Text;

                MySqlDataReader calc3;
                calc3 = conexaodois3.ExecuteReader();
                calc3.Read();
                lbBia.Text = calc3.GetString(0);
                objconexao.Close();

                MySqlCommand conexaodois4 = new MySqlCommand("select  sum(caixas) from producao where dia = ? and nome = 'Debora' ", objconexao);
                conexaodois4.Parameters.Add("@dia", MySqlDbType.DateTime).Value = labeldata.Text;
                objconexao.Open();

                conexaodois4.CommandType = CommandType.Text;

                MySqlDataReader calc4;
                calc4 = conexaodois4.ExecuteReader();
                calc4.Read();
                lbDebora.Text = calc4.GetString(0);
                objconexao.Close();


                MySqlCommand conexaodois5 = new MySqlCommand("select  sum(caixas) from producao where dia = ? and nome = 'Jaqueline' ", objconexao);
                conexaodois5.Parameters.Add("@dia", MySqlDbType.DateTime).Value = labeldata.Text;
                objconexao.Open();

                conexaodois5.CommandType = CommandType.Text;

                MySqlDataReader calc5;
                calc5= conexaodois5.ExecuteReader();
                calc5.Read();
                lbJaqueline.Text = calc5.GetString(0);
                objconexao.Close();

                MySqlCommand conexaodois6 = new MySqlCommand("select  sum(caixas) from producao where dia = ? and nome = 'Juliana' ", objconexao);
                conexaodois6.Parameters.Add("@dia", MySqlDbType.DateTime).Value = labeldata.Text;
                objconexao.Open();

                conexaodois6.CommandType = CommandType.Text;

                MySqlDataReader calc6;
                calc6 = conexaodois6.ExecuteReader();
                calc6.Read();
                lbJuliana.Text = calc6.GetString(0);
                objconexao.Close();


                MySqlCommand conexaodois7 = new MySqlCommand("select  sum(caixas) from producao where dia = ? and nome = 'Luciana' ", objconexao);
                conexaodois7.Parameters.Add("@dia", MySqlDbType.DateTime).Value = labeldata.Text;
                objconexao.Open();

                conexaodois7.CommandType = CommandType.Text;

                MySqlDataReader calc7;
                calc7 = conexaodois7.ExecuteReader();
                calc7.Read();
                lbluciana.Text = calc7.GetString(0);
                objconexao.Close();

                MySqlCommand conexaodois8 = new MySqlCommand("select  sum(caixas) from producao where dia = ? and nome = 'Margarida' ", objconexao);
                conexaodois8.Parameters.Add("@dia", MySqlDbType.DateTime).Value = labeldata.Text;
                objconexao.Open();

                conexaodois8.CommandType = CommandType.Text;

                MySqlDataReader calc8;
                calc8 = conexaodois8.ExecuteReader();
                calc8.Read();
                lbMargarida.Text = calc8.GetString(0);
                objconexao.Close();


                MySqlCommand conexaodois9 = new MySqlCommand("select  sum(caixas) from producao where dia = ? and nome = 'Michele' ", objconexao);
                conexaodois9.Parameters.Add("@dia", MySqlDbType.DateTime).Value = labeldata.Text;
                objconexao.Open();

                conexaodois9.CommandType = CommandType.Text;

                MySqlDataReader calc9;
                calc9 = conexaodois9.ExecuteReader();
                calc9.Read();
                lbMichele.Text = calc9.GetString(0);
                objconexao.Close();


                MySqlCommand conexaodois10 = new MySqlCommand("select  sum(caixas) from producao where dia = ? and nome = 'Neusa' ", objconexao);
                conexaodois10.Parameters.Add("@dia", MySqlDbType.DateTime).Value = labeldata.Text;
                objconexao.Open();

                conexaodois10.CommandType = CommandType.Text;

                MySqlDataReader calc10;
                calc10 = conexaodois10.ExecuteReader();
                calc10.Read();
                lbNeusa.Text = calc10.GetString(0);
                objconexao.Close();


                MySqlCommand conexaodois11 = new MySqlCommand("select  sum(caixas) from producao where dia = ? and nome = 'Patricia' ", objconexao);
                conexaodois11.Parameters.Add("@dia", MySqlDbType.DateTime).Value = labeldata.Text;
                objconexao.Open();

                conexaodois11.CommandType = CommandType.Text;

                MySqlDataReader calc11;
                calc11 = conexaodois11.ExecuteReader();
                calc11.Read();
                lbPatricia.Text = calc11.GetString(0);
                objconexao.Close();


                MySqlCommand conexaodois12 = new MySqlCommand("select  sum(caixas) from producao where dia = ? and nome = 'Paula' ", objconexao);
                conexaodois12.Parameters.Add("@dia", MySqlDbType.DateTime).Value = labeldata.Text;
                objconexao.Open();

                conexaodois12.CommandType = CommandType.Text;

                MySqlDataReader calc12;
                calc12 = conexaodois12.ExecuteReader();
                calc12.Read();
                lbPaula.Text = calc12.GetString(0);
                objconexao.Close();

                MySqlCommand conexaodois13 = new MySqlCommand("select  sum(caixas) from producao where dia = ? and nome = 'Vanessa' ", objconexao);
                conexaodois13.Parameters.Add("@dia", MySqlDbType.DateTime).Value = labeldata.Text;
                objconexao.Open();

                conexaodois13.CommandType = CommandType.Text;

                MySqlDataReader calc13;
                calc13 = conexaodois13.ExecuteReader();
                calc13.Read();
                lbvanessa.Text = calc13.GetString(0);
                objconexao.Close();
            
            }
            catch(Exception  erro)
            {
                

            }
            ///começa aqui o datagredview
            try
            {
                MySqlConnection conectar = new MySqlConnection("server=localhost;port=3306;User Id=root;database=db_embalagem; password= ");
                conectar.Open();

                MySqlCommand Consulta = new MySqlCommand();
                Consulta.Connection = conectar;
                Consulta.CommandText = "select apelido, fluxo, caixas, hora from producao where dia = ? order by nome, fluxo";
                Consulta.Parameters.Add("@dia", MySqlDbType.DateTime).Value = labeldata.Text;
                MySqlDataReader Resultado = Consulta.ExecuteReader();

                dataGridView1.Rows.Clear();

                if (Resultado.HasRows)
                {
                    while (Resultado.Read())
                    {
                        dataGridView1.Rows.Add(Resultado["apelido"].ToString(),
                                               Resultado["fluxo"].ToString(),
                                               Resultado["caixas"].ToString(),
                                               Resultado["hora"].ToString());
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
            // termina aqui o gred
        }

        private void txtre_Validated(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection objconexao = new MySqlConnection("server=localhost;port=3306;User Id=root;database=db_embalagem; password= ");
                objconexao.Open();



                MySqlCommand objcom = new MySqlCommand("select nome, apelido from nome where re = ?", objconexao);
                objcom.Parameters.Add("@re", MySqlDbType.Int16).Value = txtre.Text;

                objcom.CommandType = CommandType.Text;
         
                MySqlDataReader ap;
                ap = objcom.ExecuteReader();
                ap.Read();
                txtnome.Text = ap.GetString(0);
                txtapelido.Text = ap.GetString(1);
                
                objconexao.Close();

               

            }
            catch (Exception erro)
            {
               // MessageBox.Show("Erro " + erro);

            }
        }

        private void txtre_Leave(object sender, EventArgs e)
        {
            
            

        }
        private void MudarNoEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.ProcessTabKey(true);
                e.Handled = true;
            }
        }

      

    }
}
