using System;
using System.Windows.Forms;

namespace AirlineReservationSystemCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "Admin" || TextBox2.Text == "Admin")
            {
                MessageBox.Show("You are logged in successfully..");
                this.Visible = false;
                Home obj1 = new Home();
                obj1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Enter Valid Username and Password.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
