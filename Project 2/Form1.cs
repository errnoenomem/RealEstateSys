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
    public partial class P2 : Form
    {
        private MySqlCommand cmd; //initialize cmd inputter for database
        private MySqlDataReader read; //initialize reader for database
        private MySqlConnection con; //initialize the  connector for database

        public P2() //constructor
        {
            InitializeComponent();
            con = new MySqlConnection("SERVER=localhost;DATABASE=properties;UID=ricefieldboy;PASSWORD=Superhi2;"); //Creates a link to the SQL Database
        }

        private void P2_Load(object sender, EventArgs e)
        {
            try//try statements
            {
                con.Open(); // opens the connection
            }
            catch //if fail, execute below
            {
                con.Close(); //close the connection
                MessageBox.Show("ERROR IN DATABASE CONNECTION! CLOSING PROGRAM NOW ");//messagebox displaying error in connecting to the server
                this.Close();//closes the application entireley
            }
            cmd = new MySqlCommand("SELECT address FROM listings", con); //Sytax, select all "address" from "listings" which is the database
            read = cmd.ExecuteReader(); //executes the command
            if (read.HasRows) //If there are rows to read in
            {
                while (read.Read()) //While there are more addresses to read
                {
                    propertylist.Items.Add(read[0].ToString()); //add the address to the combobox, named "propertylist". [0] is the directory of the address
                }
            }
            MessageBox.Show("Listings added!"); //Informs that listings have been added, will remove this in the future
            read.Close(); //close the reader, this must be done or errors will incur
        }

        private void propertylist_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new MySqlCommand("SELECT * FROM listings where address='" + this.propertylist.SelectedItem.ToString() + "'", con); //Gather all data when address is equal to the address selected
            read = cmd.ExecuteReader();
            if (read.HasRows) //if there are rows to be read
            {//Text of appropriate labels will be filled with the information of the address
                read.Read(); //start reading
                address.Text = read[0].ToString();
                idnum.Text = read[1].ToString();
                city.Text = read[2].ToString();
                state.Text = read[3].ToString();
                zip.Text = read[4].ToString();
                description.Text = read[5].ToString();
                status.Text = read[6].ToString();
                buy.Text = read[7].ToString();
                rent.Text = read[8].ToString();
                lotsize.Text = read[9].ToString();
                housesize.Text = read[10].ToString();
                proptype.Text = read[11].ToString();
                bedrooms.Text = read[12].ToString();
                bathrooms.Text = read[13].ToString();
                garage.Text = read[14].ToString();
                street.Text = read[15].ToString();
                basement.Text = read[17].ToString();
                stories.Text = read[16].ToString();
                age.Text = read[18].ToString();
                //age.Text = read.GetString("age"); //different syntax, same result //for reference
                read.Close(); //close read
            }
        }

        private void purchase_Click(object sender, EventArgs e) //the purchase button
        {//Once pressed, a messagebox will prompt for a confirmation, options yes or no
            DialogResult confirm = MessageBox.Show("Are you sure you want to purchase this property?", "CONFIRM YOUR PURCHASE", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (confirm == DialogResult.Yes && status.Text == "Active") //if yes has been selected
            {
                ccForm childForm4 = new ccForm(this.address.Text, this); //passes the address so the form can utilize it
                childForm4.Show();//Opens up the credit card prompt form
            }
            else if (confirm == DialogResult.Yes && status.Text == "Sold")
                MessageBox.Show("This property is unavailable for purchase!", "WARNING!");
            if (confirm == DialogResult.No)
                MessageBox.Show("Purchase canceled", "Cancel");
        }

        private void reset_Click(object sender, EventArgs e) //reset button resets all statuses back to Active
        {
            cmd = new MySqlCommand("update listings set status='Active'", con);
            read = cmd.ExecuteReader();
            MessageBox.Show("All listings have been reset"); //prompts user that the listings have been reset
            read.Close();
            status.Text = "Active";
        }

        private void renewsel_Click(object sender, EventArgs e) //reset selection button resets the status of selected property
        {
            cmd = new MySqlCommand("update listings set status='Active' where address='" + this.address.Text + "'", con);
            read = cmd.ExecuteReader();
            MessageBox.Show("Selected listing has been reset"); //prompts user of such
            read.Close();
            status.Text = "Active";
        }

        private void offer_Click(object sender, EventArgs e)
        {
            oForm childForm = new oForm(this.address.Text); //creates "childForm" of form2, childForm pass the string address of selected property
            childForm.Show(); //Displays form2
        }

        private void owner_Click(object sender, EventArgs e)
        {
            nameForm childForm2 = new nameForm(this.address.Text);
            childForm2.Show();
        }

        private void realtor_Click(object sender, EventArgs e)
        {
            realtorform childForm3 = new realtorform(this.address.Text);
            childForm3.Show();
        }

        private void filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filter.SelectedItem.ToString() == "all")
            {
                propertylist.Items.Clear();
                cmd = new MySqlCommand("SELECT address FROM listings", con); //Sytax, select all "address" from "listings" which is the database
                read = cmd.ExecuteReader(); //executes the command
                if (read.HasRows) //If there are rows to read in
                {
                    while (read.Read()) //While there are more addresses to read
                    {
                        propertylist.Items.Add(read[0].ToString()); //add the address to the combobox, named "propertylist". [0] is the directory of the address
                    }
                }
                read.Close();
            }
            else
            {
                cmd = new MySqlCommand("select address from listings where state='" + filter.SelectedItem.ToString() + "'", con);
                read = cmd.ExecuteReader();
                if (read.HasRows)
                {
                    propertylist.Items.Clear();
                    while (read.Read())
                    {
                        propertylist.Items.Add(read[0].ToString());
                    }
                }
                read.Close();
            }
        }

        private void register_Click(object sender, EventArgs e)
        {
            Form6 childform5 = new Form6();
            childform5.Show();
        }
    }
}

