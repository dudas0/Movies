using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ProjectMovieThisIsIt
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void Logowanie_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-MELB6US\SQLEXPRESS; Initial Catalog = movies; Integrated Security = True;");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM tableUser WHERE UserName='" + textusername.Text + "' AND Password='" + textpassword.Text + "'", con);
            /* in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. */
            DataTable dt = new DataTable(); //this is creating a virtual table  
            sda.Fill(dt);


            if (dt.Rows[0][0].ToString() == "1")
            {
                User u1 = new User(textusername.Text, textpassword.Text);
                this.Close();
                new ListOfMovies().Show();
            }
            else
                MessageBox.Show("Niepoprawna nazwa użytkownika lub hasło");
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string fo //dzięki temu w innych klasach moge używać textusername jak wywołam klase i tą metode
        {
            get { return textusername.Text; }
            set { textusername.Text = value; }

        }

        public string fo1
        {
            get { return textpassword.Text; }
            set { textpassword.Text = value; }

        }

    }
}
