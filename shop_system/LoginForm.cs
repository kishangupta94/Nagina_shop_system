using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shop_system
{

    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }
        public string firstname;
        public string lastname;
        private void login_Click(object sender, EventArgs e)
        {
            //globals.user1 = btnusername.Text;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=DRAGEN94; database=shop; integrated security = True";
            SqlCommand cmd = new SqlCommand("SELECT * FROM NewEmployee WHERE username ='" + btnusername.Text + "' and password='" + btnpassword.Text + "'", con);
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataTable DT = new DataTable();
            DA.Fill(DT);
 
            if(comboBox1.SelectedItem != null) 
            { 
                string Combouser = comboBox1.SelectedItem.ToString();
            
            if (DT.Rows.Count > 0)
            {
                firstname = DT.Rows[0][1].ToString().ToUpper();
                lastname = DT.Rows[0][3].ToString().ToUpper();
                globals.user1 = firstname + " " + lastname;



                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    if (DT.Rows[i]["usertype"].ToString() == Combouser)
                    {
                        MessageBox.Show($"{DT.Rows[i][10]} Successfully Login as {DT.Rows[i][12]} ");
                        if (comboBox1.SelectedIndex == 0)
                        {
                            NewEmployee ne = new NewEmployee();
                            ne.Show();
                            this.Hide();

                        }
                        else
                        {
                            ShopSystem ss = new ShopSystem();
                            ss.Show();
                            this.Hide();

                        }
                    }
                }
            }
            else
            {
                con.Close();
                MessageBox.Show("Incorrect Username Or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
            else
            {
                MessageBox.Show("Please Select User Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure. You Want To Exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Welcome Back", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btn_abount_Click(object sender, EventArgs e)
        {
            About abt = new About();
            abt.Show();
            this.Hide();
        }
    }
}
