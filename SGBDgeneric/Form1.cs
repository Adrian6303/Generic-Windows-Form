using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGBDgeneric
{
    public partial class Form1 : Form
    {
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        DataSet ds1 = new DataSet();
        public Form1()
        {
            InitializeComponent();
            Form1_LoadParent();
            generateTextBoxes();
        }

        private void Form1_LoadParent()
        {

            string con= ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            try
            {
                ParentDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                SqlConnection cs = new SqlConnection(con);
                string select = ConfigurationManager.AppSettings["selectParent"];
                da.SelectCommand = new SqlCommand(select, cs);
                ds.Clear();
                da.Fill(ds);
                ParentDataGridView.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_LoadChild()
        {
            string con = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            try
            {
                ChildDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                SqlConnection cs = new SqlConnection(con);
                string select = ConfigurationManager.AppSettings["selectChild"];

                da.SelectCommand = new SqlCommand(select, cs);
                da.SelectCommand.Parameters.AddWithValue("@id_parent", ParentDataGridView.SelectedRows[0].Cells[0].Value);
                ds1.Clear();
                da.Fill(ds1);
                ChildDataGridView.DataSource = ds1.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void generateTextBoxes()
        {
            List<string> CollumnNames = new List<string>(ConfigurationManager.AppSettings["ChildColumnNames"].Split(','));
            int pointX = 30;
            int pointY = 40;
            panel1.Controls.Clear();
            foreach (string collumn in CollumnNames)
            {
                

                TextBox txt = new TextBox();
                txt.Size = new Size(200, 20);
                txt.Location = new Point(pointX +150, pointY);
                txt.Name = collumn;
                txt.Visible = true;
                txt.Parent = panel1;
                
                
                Label lbl = new Label();
                lbl.Size = new Size(150, 20);
                lbl.Location = new Point(pointX, pointY);
                lbl.Name = collumn;
                lbl.Text = collumn;
                lbl.Visible = true;
                lbl.Parent = panel1;
                
                panel1.Show();
                
                pointY += 30;
            }

        }



        private void ParentDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Form1_LoadChild();
            generateTextBoxes();
        }

        private void ChildDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            List<string> CollumnNames = new List<string>(ConfigurationManager.AppSettings["ChildColumnNames"].Split(','));
            int id= int.Parse(ChildDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            int i = 1;
            foreach (string collumn in CollumnNames)
            {
                panel1.Controls.Find(collumn, true)[0].Text = ChildDataGridView.SelectedRows[0].Cells[i].Value.ToString();
                i++;
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            Form1_LoadParent();
            generateTextBoxes();
            ChildDataGridView.DataSource = null;
            
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string con = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            SqlConnection cs = new SqlConnection(con);
            try
            {
                string ChildColumnNames = ConfigurationManager.AppSettings["ChildColumnNames"];
                List<string> CollumnNamesList = new List<string>(ConfigurationManager.AppSettings["ChildColumnNames"].Split(','));
                string InsertQuery = ConfigurationManager.AppSettings["InsertQuery"];
                SqlCommand cmd = new SqlCommand(InsertQuery, cs);
                cmd.Parameters.AddWithValue("@id_parent", ParentDataGridView.SelectedRows[0].Cells[0].Value);
                foreach (string collumn in CollumnNamesList)
                {
                    TextBox textBox = (TextBox)panel1.Controls.Find(collumn, true)[0];
                    cmd.Parameters.AddWithValue("@" + collumn, textBox.Text);

                }
                cs.Open();
                cmd.ExecuteNonQuery();
                ds1.Clear();
                da.Fill(ds1);
                ChildDataGridView.DataSource = ds1.Tables[0];
                MessageBox.Show("Inserted successfully");
                cs.Close();
                generateTextBoxes();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cs.Close();
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string con = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            SqlConnection cs = new SqlConnection(con);
            try
            {
                string ChildColumnNames = ConfigurationManager.AppSettings["ChildColumnNames"];
                List<string> CollumnNamesList = new List<string>(ConfigurationManager.AppSettings["ChildColumnNames"].Split(','));
                string UpdateQuery = ConfigurationManager.AppSettings["UpdateQuery"];
                SqlCommand cmd = new SqlCommand(UpdateQuery, cs);
                cmd.Parameters.AddWithValue("@id_child", ChildDataGridView.SelectedRows[0].Cells[0].Value);
                foreach (string collumn in CollumnNamesList)
                {
                    TextBox textBox = (TextBox)panel1.Controls.Find(collumn, true)[0];
                    cmd.Parameters.AddWithValue("@" + collumn, textBox.Text);

                }
                cs.Open();
                cmd.ExecuteNonQuery();
                ds1.Clear();
                da.Fill(ds1);
                ChildDataGridView.DataSource = ds1.Tables[0];
                MessageBox.Show("Updated successfully");
                cs.Close();
                generateTextBoxes();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cs.Close();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string con = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            SqlConnection cs = new SqlConnection(con);
            try
            {
                string DeleteQuery = ConfigurationManager.AppSettings["DeleteQuery"];
                SqlCommand cmd = new SqlCommand(DeleteQuery, cs);
                cmd.Parameters.AddWithValue("@id_child", ChildDataGridView.SelectedRows[0].Cells[0].Value);
                cs.Open();
                cmd.ExecuteNonQuery();
                ds1.Clear();
                da.Fill(ds1);
                ChildDataGridView.DataSource = ds1.Tables[0];
                MessageBox.Show("Deleted successfully");
                cs.Close();
                generateTextBoxes();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cs.Close();
            }

        }


    }
}
