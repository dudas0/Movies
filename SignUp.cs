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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void Rejestruj_Click(object sender, EventArgs e)
        {
            if (textnazwa.Text == "" || texthaslo.Text == "")
                MessageBox.Show("PROSZĘ WYPEŁNIJ WSZYSTKIE POLA'!");
            else if (texthaslo.Text != texthaslo2.Text)
                MessageBox.Show("Podane hasła różnią się!");

            else
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source = DESKTOP-MELB6US\SQLEXPRESS; Initial Catalog = movies; Integrated Security = True;"))
                {
                    conn.Open();
                    SqlCommand sqlCmd = new SqlCommand("AddingUser", conn);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@FirstName", textimie.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@LastName", textnazwisko.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Email", textemail.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Username", textnazwa.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Password", texthaslo.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("ZAREJESTROWAŁEŚ SIĘ!");
                    Clear();
                    this.Hide();
                    new home().Show();
                }
            }
        }

        void Clear()
        {
            textimie.Text = textnazwisko.Text = textemail.Text = textnazwa.Text = texthaslo.Text = texthaslo2.Text = " ";
        }
    }
}
