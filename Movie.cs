using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProjectMovieThisIsIt
{
    [Serializable]
    public class Movie : IComparable
    {
        int idMovie;
        string name;
        int year;
        string director;
        double avgRate;
        int numberOfRates = 0;
        string description; 

        public Movie() { }

        public Movie(int idMovie, string name, int year, string director, double avgRate, int numberOfRates, string description)
        {
            IdMovie = idMovie;
            Name = name;
            Year = year;
            Director = director;
            AvgRate = avgRate;
            NumberOfRates = numberOfRates;
            Description = description;
        }



        public int IdMovie { get => idMovie; set => idMovie = value; }
        public string Name { get => name; set => name = value; }
        public int Year { get => year; set => year = value; }
        public string Director { get => director; set => director = value; }
        public double AvgRate { get => avgRate; set => avgRate = value; }
        public int NumberOfRates { get => numberOfRates; set => numberOfRates = value; }
        public string Description { get => description; set => description = value; }

        public int CompareTo(object o)
        {
            if (o != null)
            {
                Movie c = (Movie)o;
                int cmp = this.Name.CompareTo(c.Name);
                if (cmp != 0)
                    return cmp;
                else
                    return this.Year.CompareTo(c.Year);
            }
            else
                return 1;
        }



        /*public int CompareTo(Movie other)
        {
            if (AvgRate > other.AvgRate)
                return 1;
            else if (AvgRate < other.AvgRate)
                return -1;
            else
                return 0;
            //var lista = new List<Movie>();
            //lista.Sort();
            //lista.Sort(Comparer<Movie>.Create((m1, m2) => m1.avgRate.CompareTo(m2.avgRate)));
            //return name.CompareTo(other.name);
        }*/



    }
}
