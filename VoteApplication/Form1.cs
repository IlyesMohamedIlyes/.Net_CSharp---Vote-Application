using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using StationServiceProject.Scripts;

namespace VoteApplication
{
    public partial class Form1 : Form
    {

        SqlConnection _connection = DatabaseAccess.Instance.Connection;
        SqlDataAdapter _dataAdapter;
        DataSet _dataSet;

        public Form1()
        {
            InitializeComponent();
            refreshTable();
            refreshNumbers();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        public void refreshNumbers()
        {
            int pour = 0, contre = 0;
            try
            {
                _connection.Open();

                using (var command = new SqlCommand("CountP", _connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    using (var reader = command.ExecuteReader())
                    {
                        reader.Read();

                        pour = reader.GetInt32(0);
                    }
                }
                using (var command = new SqlCommand("CountContre", _connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    using (var reader = command.ExecuteReader())
                    {
                        reader.Read();

                        contre = reader.GetInt32(0);
                    }
                }
                _connection.Close();

                int nbrvote = pour + contre;
                MessageBox.Show(nbrvote.ToString());
                label_NombreVote.Text = nbrvote.ToString();
                label_Pour.Text = pour.ToString();
                label_Contre.Text = contre.ToString();
                if (nbrvote == 0)
                {
                    label_ContrePourcentage.Text = 0 + "%";
                    label_PourPourcentage.Text = 0 + "%";
                }
                else
                {
                    label_ContrePourcentage.Text = (contre * 100 / nbrvote) + "%";
                    label_PourPourcentage.Text = (pour * 100 / nbrvote) + "%";
                }

            } 
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                _connection.Close();
                return;
            }
        }
        public void refreshTable()
        {
            try
            {
                using (var command = new SqlCommand("Refresh", _connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    _dataAdapter = new SqlDataAdapter(command);
                    _dataSet = new DataSet();
                    _dataAdapter.Fill(_dataSet);

                    _connection.Open();
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("INVALID\n" + e);
                        _connection.Close();
                        return;
                    }
                }
                _connection.Close();

                dataGridView1.DataSource = _dataSet.Tables[0];

                dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells; // Matricule
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells; // Prénm
                dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // PourContre Greve
            }
            catch (Exception e)
            {
                MessageBox.Show("INVALID. " + e);
                _connection.Close();
                return;
            }

        }

        private void button_Soumettre_Click(object sender, EventArgs e)
        {
            if (!verifyfields())
                return;

            if (MessageBox.Show(string.Format("{0} portant matricule {1} est {2}",
                textBox_Specialite.Text, textBox_Matricule.Text, comboBox_Greve.SelectedItem.ToString()),
                "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)

            {

                using (var command = new SqlCommand("Add_Voteur", _connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Matricule", textBox_Matricule.Text);
                    command.Parameters.AddWithValue("@Faculte", textBox_Faculte.Text);
                    command.Parameters.AddWithValue("@Specialite", textBox_Specialite.Text);
                    command.Parameters.AddWithValue("@PourGreve", comboBox_Greve.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@DébutGreve", textBox_Debut.Text);
                    command.Parameters.AddWithValue("@DuréeGreve", textBox_Duree.Text);

                    try
                    {
                        _connection.Open();
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        //Exist Matricule
                        if (ex.ToString().Contains("Violation of PRIMARY KEY"))
                            MessageBox.Show("Ce matricule existe déjà !! ");
                        else
                            MessageBox.Show(ex.ToString()); 

                        _connection.Close();
                        return;
                    }
                    _connection.Close();
                }

                refreshTable();
                numbersChanger(1);
            }
            
                
        }

        private void numbersChanger(int num)
        {
            int nbrvote = (int.Parse(label_NombreVote.Text) + num);

            label_NombreVote.Text = nbrvote.ToString();

            int pour = int.Parse(label_Pour.Text);
            int contre = int.Parse(label_Contre.Text);

            if (comboBox_Greve.SelectedIndex == 0)
            {
                pour += num;
                label_Pour.Text = pour.ToString();
            }
            else
            {
                contre += num;
                label_Contre.Text = contre.ToString();
            }
            label_ContrePourcentage.Text = (contre * 100 / nbrvote) + "%";
            label_PourPourcentage.Text = (pour * 100 / nbrvote) + "%";

        }

        private void comboBox_Greve_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Greve.SelectedIndex == 0)
                panel_PourGreve.Visible = true;
            else
            { panel_PourGreve.Visible = false;
                textBox_Duree.Text = "";
                textBox_Debut.Text = "";
            }
        }

        private void label_Name_Click(object sender, EventArgs e)
        {

        }

        private bool verifyfields ()
        {
            if (string.IsNullOrWhiteSpace(textBox_Matricule.Text))
            {
                MessageBox.Show("Veuillez entrer un matricule");
                return false;
            }

            return true;
        }

        private void button_voir_Click(object sender, EventArgs e)
        {
            panel_pourcentage.Visible = !panel_pourcentage.Visible;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
