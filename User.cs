using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMovieThisIsIt
{
    class User
    {
        string username;
        string password;


        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }


        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }


        /*int myRate;
        string username;


        public int MyRate { get => myRate; set => myRate = value; }
        public string Username { get => username; set => username = value; }

        LogIn f1 = new LogIn();
        ListOfMovies f2 = new ListOfMovies();

        public User(string username)
        {
            Username = username;
            username = f1.fo;
        }

        public void Ocen(Movie m, int myRate)
        {
            MyRate = myRate;
            myRate = f2.fi;
        } // to nie ma być konstruktorem i łączyć username i myRate tylko dodawać jakby ocene username.Ocen(film)
*/
    }
}
