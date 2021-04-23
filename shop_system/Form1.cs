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
    public partial class ShopSystem : Form
    {
        public ShopSystem()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = System.Drawing.Color.Yellow;
            radioButton2.ForeColor = System.Drawing.Color.Red;
            comboitem.Items.Clear();
            comboitem.Items.Add("Jeleebi");
            comboitem.Items.Add("Rus Gulah");
            comboitem.Items.Add("Sehna");
            comboitem.Items.Add("Barfi");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            radioButton1.ForeColor = System.Drawing.Color.Red;
            radioButton2.ForeColor = System.Drawing.Color.Yellow;
            comboitem.Items.Clear();
            comboitem.Items.Add("Samosa");
            comboitem.Items.Add("Patis");
            comboitem.Items.Add("Vada Pav");
            comboitem.Items.Add("Kachori");
        }

        private void comboitem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboitem.SelectedItem.ToString() == "Jeleebi")
            { txt_price.Text = "30"; }
            else if (comboitem.SelectedItem.ToString() == "Rus Gulah")
            { txt_price.Text = "180"; }
            else if (comboitem.SelectedItem.ToString() == "Sehna")
            { txt_price.Text = "360"; }
            else if (comboitem.SelectedItem.ToString() == "Barfi")
            { txt_price.Text = "220"; }
            else if (comboitem.SelectedItem.ToString() == "Samosa") 
            { txt_price.Text = "10"; }
            else if (comboitem.SelectedItem.ToString() == "Patis") 
            { txt_price.Text = "15"; }
            else if (comboitem.SelectedItem.ToString() == "Vada Pav") 
            { txt_price.Text = "10"; }
            else if (comboitem.SelectedItem.ToString() == "Kachori") 
            { txt_price.Text = "15"; }
            else
            {
                txt_price.Text = "0";
            }
            txt_total.Text = "";
            txt_qty.Text = "";

        }

        private void txt_qty_TextChanged(object sender, EventArgs e)
        {
            if (txt_qty.Text.Length > 0)
            {
                txt_total.Text = (Convert.ToInt16(txt_price.Text) * Convert.ToInt16(txt_qty.Text)).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] arr = new string[4];
            arr[0] = comboitem.SelectedItem.ToString();
            arr[1] = txt_price.Text;
            arr[2] = txt_qty.Text;
            arr[3] = txt_total.Text;
            ListViewItem lvi = new ListViewItem(arr);
            listView1.Items.Add(lvi);
            txt_sub.Text= (Convert.ToInt16(txt_sub.Text) + Convert.ToInt16(txt_total.Text)).ToString();

        }


        private void txt_discount_TextChanged(object sender, EventArgs e)
        {
            if(txt_discount.Text.Length > 0)
            {
                txt_net.Text = (Convert.ToInt16(txt_sub.Text) - Convert.ToInt16(txt_discount.Text)).ToString();
            }
        }

        private void txt_paid_TextChanged(object sender, EventArgs e)
        {
            if (txt_paid.Text.Length > 0)
            {
                txt_bal.Text = (Convert.ToInt16(txt_net.Text) - Convert.ToInt16(txt_paid.Text)).ToString();
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    if (listView1.Items[i].Selected)
                    {
                        txt_sub.Text = (Convert.ToInt16(txt_sub.Text) - Convert.ToInt16(listView1.Items[i].SubItems[3].Text)).ToString();
                        listView1.Items[i].Remove();
                    }
                }
            }


        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=DRAGEN94; database=shop; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
              try {
                    con.Open();
                    cmd.CommandText = "insert into Invoice_Master(InvoiceDate,Sub_Total,Discount,Net_Amount,Paid_Amount) values " + "(getdate()," + txt_sub.Text + "," + txt_discount.Text + "," + txt_net.Text + "," + txt_paid.Text + ") select scope_identity() ";
                    string InvoiceID = cmd.ExecuteScalar().ToString();

                    foreach (ListViewItem ListItem in listView1.Items)
                    {
                        cmd.CommandText = "insert into Invoice_Detail(MasterID,Item_Name,Item_Price,Item_Qty,Item_Total) values " + "('"+ InvoiceID +"','" + ListItem.SubItems[0].Text +"','" + ListItem.SubItems[1].Text + "','" + ListItem.SubItems[2].Text + "','" + ListItem.SubItems[3].Text + "')";
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();
                    MessageBox.Show("Purchesed Item successfully, With Invoice #" + InvoiceID);
                    new Report.PrintInvoice(InvoiceID).Show();
                }catch (Exception ee)
                {
                    con.Close();
                    MessageBox.Show("Not Purchesed Item, error");
                }
            }
            else
            {
                MessageBox.Show("Please Add Item");
            }


            }
 
        private void button5_Click(object sender, EventArgs e)
        {
            comboitem.ResetText();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton1.ForeColor= System.Drawing.Color.Black;
            radioButton2.ForeColor = System.Drawing.Color.Black;
            txt_price.ResetText();
            txt_qty.ResetText();
            txt_total.ResetText();
            txt_bal.ResetText();
            txt_discount.ResetText();
            txt_net.ResetText();
            txt_paid.ResetText();
            txt_sub.ResetText();
            listView1.Items.Clear();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
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

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About abt = new About();
            abt.Show();
            this.Hide();
        }

        private void ShopSystem_Load(object sender, EventArgs e)
        {
            userlabel.Text = globals.user1;
        }
    }
    
}
