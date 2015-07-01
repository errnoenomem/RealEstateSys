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
    public partial class nameForm : Form
    {
        private MySqlCommand cmd;
        private MySqlDataReader read;
        private MySqlConnection con;

        public nameForm(string s)
        {
            InitializeComponent();
            con = new MySqlConnection("SERVER=localhost;DATABASE=properties;UID=ricefieldboy;PASSWORD=Superhi2;");
            con.Open();
            cmd = new MySqlCommand("select * from listings where address='" + s + "'", con);
            read = cmd.ExecuteReader();
            if (read.HasRows)
            { //same setup from previous forms, sets strings to appropriate labels in the "OWNER DETAILS" form
                read.Read();
                address.Text = s;
                ownername.Text = read[29].ToString();
                phone.Text = read[30].ToString();
                email.Text = read[31].ToString();
                realtor.Text = read[32].ToString();
                read.Close();
            }
        }
    }
}
