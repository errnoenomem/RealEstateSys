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

namespace Project_2
{
    public partial class oForm : Form
    {
        private MySqlCommand cmd;
        private MySqlDataReader read;
        private MySqlConnection con;
        public string test;

        public oForm(string s) //important to pass string address text because it is needed to identify which offers are made on which listings
        {//Same syntax to establish the connector for the database from form1
            InitializeComponent();
            con = new MySqlConnection("SERVER=localhost;DATABASE=properties;UID=ricefieldboy;PASSWORD=Superhi2;"); 
            con.Open(); 
            cmd = new MySqlCommand("SELECT * FROM listings where address='" + s + "'", con); //selects all rows from listings where address is 's', the string address
            read = cmd.ExecuteReader();
            if (read.HasRows)
            {//name and offers will be added 
                test = s;
                read.Read();
                name1.Text = read[19].ToString();
                name2.Text = read[20].ToString();
                name3.Text = read[21].ToString();
                name4.Text = read[22].ToString();
                name5.Text = read[23].ToString();
                offer1.Text = read[24].ToString();
                offer2.Text = read[25].ToString();
                offer3.Text = read[26].ToString();
                offer4.Text = read[27].ToString();
                offer5.Text = read[28].ToString();
                name6.Text = read[38].ToString();
                offer6.Text = read[37].ToString();
                read.Close();
            }
        }

        private void submit_Click(object sender, EventArgs e) //once submit has been clicked
        { //the labels will take the text of the textbox
            name6.Text = name.Text;
            offer6.Text = offer.Text;
            cmd = new MySqlCommand("update listings set yourname='" + name6.Text + "' where address='" + test + "'", con);
            read = cmd.ExecuteReader();
            read.Close();
            cmd = new MySqlCommand("update listings set youroffer='" + offer6.Text + "' where address='" + test + "'", con);
            read = cmd.ExecuteReader();
            read.Close();
        }
    }
}
