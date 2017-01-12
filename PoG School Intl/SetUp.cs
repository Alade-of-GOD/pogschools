using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoG_School_Intl
{
    public partial class SetUp : Form
    {
        Colors colors = new Colors();
        String adRole, userRole, fName, sName, userId;
        bool val;
        public SetUp()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            colors.CloseHover(pictureBox2);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            colors.CloseOut(pictureBox2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked != false)
            {
                ValidateInputs();
                GetData();
                if (val != false)
                {
                    string subPath = @"C:\pogworlddb\";
                    try
                    {
                        bool exists = Directory.Exists(subPath);
                        if (!exists)
                        {
                            DirectoryInfo dir = Directory.CreateDirectory(subPath);
                            dir.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
                        }
                    }
                    catch (Exception c)
                    {
                        MessageBox.Show(c.Message, "Error while creating Root Data File");
                    }

                    OleDbConnection myConnection = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0;" + @"Data source= C:\pogworlddb\FileManagerDb.accdb");
                    OleDbCommand myCommand = new OleDbCommand();
                    myConnection.Open();
                    myCommand.Connection = myConnection;
                    myCommand.CommandText = "INSERT INTO UsersTable (UserId, FirstName, SurnName, UserRole, AdminRole) VALUES (@p1, @p2, @p3, @p4, @p5)";
                    myCommand.Parameters.AddWithValue("@p1", userId);
                    myCommand.Parameters.AddWithValue("@p2", fName);
                    myCommand.Parameters.AddWithValue("@p3", sName);
                    myCommand.Parameters.AddWithValue("@p4", userRole);
                    myCommand.Parameters.AddWithValue("@p5", adRole);
                    myCommand.ExecuteNonQuery();
                    myCommand.Connection.Close();
                    MessageBox.Show("New Account Added", "PoGWorld", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //da.InsertCommand = new SqlCommand("insert into Training values(@FirstName,@LastName,@Course,@Department,@Address)", cs);
                    //da.InsertCommand.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = textBox2.Text;
                    //da.InsertCommand.Parameters.Add("@LastName", SqlDbType.VarChar).Value = textBox3.Text;
                    //da.InsertCommand.Parameters.Add("@Course", SqlDbType.VarChar).Value = textBox4.Text;
                    //da.InsertCommand.Parameters.Add("@Department", SqlDbType.VarChar).Value = textBox5.Text;
                    //da.InsertCommand.Parameters.Add("@Address", SqlDbType.VarChar).Value = textBox5.Text;

                    //cs.Open();
                    //da.InsertCommand.ExecuteNonQuery();
                    MessageBox.Show("Successfully Saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    myConnection.Close();


                }
            }
            else
            {
                MessageBox.Show("You have to agree to terms and conditions", "POGWOLRD", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void GetData()
        {
            adRole = comboBoxEx1.Text;
            userRole = comboBoxEx2.Text;
            userId = textBoxX2.Text;
            fName = textBoxX1.Text;
            sName = textBoxX3.Text;
        }

        private void ValidateInputs()
        {
            errorProvider1.Clear();
            if (textBoxX1.Text == "") errorProvider1.SetError(textBoxX1, "Please Fill");
            if (textBoxX2.Text == "") errorProvider1.SetError(textBoxX2, "Can't be Empty");
            if (textBoxX3.Text == "") errorProvider1.SetError(textBoxX3, "Please Fill");
            if (comboBoxEx2.Text == "") errorProvider1.SetError(comboBoxEx2, "Assign Role");
            if (comboBoxEx1.Text == "") errorProvider1.SetError(comboBoxEx1, "Your Role");

            if (textBoxX1.Text != "" && textBoxX2.Text != "" && textBoxX3.Text != "" && comboBoxEx1.Text != "" && comboBoxEx2.Text != "")
            {
                if (comboBoxEx1.Text.ToString() != "Owner" && comboBoxEx1.Text.ToString() != "Admin" && comboBoxEx1.Text.ToString() != "Management")
                    errorProvider1.SetError(comboBoxEx1, "Incorrect Role");

                else if (comboBoxEx2.Text.ToString() != "Owner" && comboBoxEx2.Text.ToString() != "Admin" && comboBoxEx2.Text.ToString() != "Management" && comboBoxEx2.Text.ToString() != "Principal" && comboBoxEx2.Text.ToString() != "Staff")
                    errorProvider1.SetError(comboBoxEx2, "Incorrect Role");
                else val = true;
            }
        }

    }
}
