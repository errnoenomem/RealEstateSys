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

    public partial class Form6 : Form
    {
        private MySqlCommand cmd;
        private MySqlDataReader read;
        private MySqlConnection con; 

        public Form6()
        {
            InitializeComponent();
            con = new MySqlConnection("SERVER=localhost;DATABASE=properties;UID=ricefieldboy;PASSWORD=Superhi2;");
            con.Open();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next (100000, 109999);
            string add = one.Text;
            string cit = two.Text;
            string state = three.Text;
            string zip = four.Text;
            string desc = five.Text;
            string buy = six.Text;
            string rent = seven.Text;
            string lsize = eight.Text;
            string hsize = nine.Text;
            string prop = ten.Text;
            string bed = eleven.Text;
            string bath = twelve.Text;
            string garage = thirteen.Text;
            string street = fourteen.Text;
            string stories = fifteen.Text.ToString();
            string basement = sixteen.Text;
            string year = seventeen.Text;

            string owner = oName.Text;
            string ownerPhone = oPhone.Text;
            string ownerEmail = oEmail.Text;
            string realtor = rName.Text;
            string realtorPhone = rPhone.Text;
            string realtorEmail = rEmail.Text;
            string realtorWebsite = rWebsite.Text;
            string realtorComments = rComments.Text;
            cmd = new MySqlCommand("insert into listings(address,city,state,zip,description,buyprice,rentprice,lotsize,housesize,propertytype,bedrooms,bathrooms,garage,streetparking,stories,basement,yearbuilt,idNum,owner,phone,email,realtor,rphone,remail,rwebsite,rcomments) values('" + add + "','" + cit + "','"
                + state + "','" + zip + "','" + desc + "','" + buy + "','" + rent + "','" + lsize + "','" + hsize + "','" + prop + "','" + bed + "','" + bath + "','" + garage + "','"
                + street + "','" + stories + "','" + basement + "','" + year + "','" + randomNumber.ToString() + "','" + owner + "','" + ownerPhone + "','" + ownerEmail + "','"
                + realtor + "','" + realtorPhone + "','" + realtorEmail + "','" + realtorWebsite + "','" + realtorComments + "')", con);
            int nuRowsAffected = cmd.ExecuteNonQuery(); //execute qeury to database
            if (nuRowsAffected < 1)
            {
                MessageBox.Show("Registration failed", "ERROR");
            }
            else
            {
                MessageBox.Show("Property has been succesfully listed,", "Registration");
            }
        }
    }
}
