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
    public partial class realtorform : Form
    {
        private MySqlCommand cmd;
        private MySqlDataReader read;
        private MySqlConnection con;

        public realtorform(string s)
        {
            InitializeComponent();
            con = new MySqlConnection("SERVER=localhost;DATABASE=properties;UID=ricefieldboy;PASSWORD=Superhi2;");
            con.Open();
            cmd = new MySqlCommand("select * from listings where address='" + s + "'", con);
            read = cmd.ExecuteReader();
            if (read.HasRows)
            {//same setup code, give appropriate text to labels in the "REALTOR DETAILS" form
                read.Read();
                address.Text = s;
                rname.Text = read[32].ToString();
                rphone.Text = read[33].ToString();
                remail.Text = read[34].ToString();
                rwebsite.Text = read[35].ToString();
                rcomments.Text = read[36].ToString();
                read.Close();
            }
        }
    }
}
