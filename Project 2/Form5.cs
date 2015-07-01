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

//This Form contains inheritance/polymorphism requirement
namespace Project_2
{
    public partial class ccForm : Form
    {
        private MySqlCommand cmd;
        private MySqlDataReader read;
        private MySqlConnection con;
        public string test;
        P2 objs;

        public ccForm(string s, P2 obj)
        { //same code as previously, note that 's' passed to this constructor has been given to test
            InitializeComponent();
            con = new MySqlConnection("SERVER=localhost;DATABASE=properties;UID=ricefieldboy;PASSWORD=Superhi2;");
            con.Open();
            objs = obj;
            test = s; //public string test recieves the value of 's', an address
            //Adds click events to textboxes - name, cc, csc, and expdate
            name.Click += new EventHandler(name_Click);
            cc.Click += new EventHandler(cc_Click);
            csc.Click += new EventHandler(csc_Click);
            expdate.Click += new EventHandler(expdate_Click);
        }

        private void expdate_Click(object sender, EventArgs e)
        {
            expdate.Clear(); //This allows the user to clear the textbox once it has been clicked
        }

        private void csc_Click(object sender, EventArgs e)
        {
            csc.Clear(); //same code for the following
        }

        private void cc_Click(object sender, EventArgs e)
        {
            cc.Clear();
        }

        private void name_Click(object sender, EventArgs e)
        {
            name.Clear();
        }

        public void classEdit(string type) //parameter is string type, the Credit Card Provider
        {//sets label to the credit card type, passed from the inheritance class below ("type" being mastercard, visa etc...)
            label1.Text = type;
        }

        private void mastercard_CheckedChanged(object sender, EventArgs e) //if mastercard radiobutton is checked
        {
            CreditCard[] credit = new CreditCard[1]; //create pointer object of CreditCard
            credit[0] = new MasterCard(this); //pointer points to MasterCard (a derived class) and passes argument (this), which is this form
            credit[0].PrintCard(); //calls the class function, PrintCard
        }
        //Repeats the same process for each Radio Button checked
        private void visa_CheckedChanged(object sender, EventArgs e)
        {
            CreditCard[] credit = new CreditCard[1];
            credit[0] = new Visa(this);
            credit[0].PrintCard();
        }

        private void americanexpress_CheckedChanged(object sender, EventArgs e)
        {
            CreditCard[] credit = new CreditCard[1];
            credit[0] = new AmericanExpress(this);
            credit[0].PrintCard();
        }

        private void discovercard_CheckedChanged(object sender, EventArgs e)
        {
            CreditCard[] credit = new CreditCard[1];
            credit[0] = new DiscoverCard(this);
            credit[0].PrintCard();
        }

        public void submit2_Click(object sender, EventArgs e)
        {//When you click submit in Form5
                CreditCard[] credit = new CreditCard[1]; //object pointer is created
                credit[0] = new CreditCard(this); //points object of CreditCard
                credit[0].name = this.name.Text; //sets data members to the text boxes values
                credit[0].ccNum = this.cc.Text;
                credit[0].sNum = this.csc.Text;
                credit[0].expDate = this.expdate.Text;
                //MessageBox will output information stored in CreditCard and not this form to show that values have been passed to the class
                DialogResult confirm = MessageBox.Show("Name: " + credit[0].name + "\nCredit Card Number: " + credit[0].ccNum + "\nCVV: " + credit[0].sNum + "\nExpiration Date: " + credit[0].expDate + "\n\n\nConfirm the above information correct?", "Confirm your Credit Card information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (confirm == DialogResult.Yes) //Information confirmation, yes no
                { //if yes, executes command that sets status to sold
                    cmd = new MySqlCommand("update listings set status='Sold' where address='" + test + "'", con);
                    read = cmd.ExecuteReader();
                    MessageBox.Show("Congratulations! You have purchased this property"); //prompts user that they have purchased the property
                    read.Close(); //close the read
                    cmd = new MySqlCommand("SELECT address FROM listings", con); //Sytax, select all "address" from "listings" which is the database
                    read = cmd.ExecuteReader(); //executes the command
                    objs.status.Text = "Sold";
                }
            }
        }



    //inheritance/polymorphism
    public class CreditCard //base class
    {
        public ccForm inst; //public ccForm object, ccForm is Form5
        public string name, ccNum, sNum, expDate; //public strings of name, credit card number, security number, and expiration date
        public CreditCard() { } // default constructor
        public CreditCard(ccForm obj) {inst = obj;} //constructor initializer that takes object of Form5
        public virtual void PrintCard() { } //Virtual functions to allow for overriding of PrintCard() function
        public virtual void setName(string s)
        {//Set name sets name to 's', which is the value in the name textbox
            name = s;
        }
        public virtual void setExp(string s)
        {//sets the other data members to textbox values
            expDate = s;
        }
        public virtual void setCC(string s)
        {
            ccNum = s;
        }
        public virtual void setSecurity(string s)
        {
            sNum = s;
        }
    }
    public class MasterCard : CreditCard //derived classes follow
    {
        public MasterCard(ccForm obj) :base(obj) { } //obj of ccForm is pased from the base class
        public override void PrintCard() //overriders PrintCard to print its own card provider in the label when its specific radio button has been checked
        {
            inst.classEdit("MasterCard");//
        }
    }
    public class Visa : CreditCard
    {//same code for the other card providers
        public Visa(ccForm obj) :base(obj) { }
        public override void PrintCard()
        {
            inst.classEdit("Visa");
        }
    }
    public class AmericanExpress : CreditCard
    {
        public AmericanExpress(ccForm obj) :base(obj) { }
        public override void PrintCard()
        {
            inst.classEdit("American Express");
        }
    }
    public class DiscoverCard : CreditCard
    {
        public DiscoverCard(ccForm obj) :base(obj) { }
        public override void PrintCard()
        {
            inst.classEdit("Discover");
        }
    }
}
