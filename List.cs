using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;

namespace ProjectMovieThisIsIt
{
    [Serializable]
    public class List 
    {

        List<Movie> lista = new List<Movie>();
        public string plik = "movies.xml";
        public List<Movie> Lista { get => lista; set => lista = value; }

        public List()
        {
            Lista = new List<Movie>();
        }

        public void Dodaj(Movie m)
        {
            Lista.Add(m);
        }

        public void Sortuj()
        {
            Lista.Sort();
        }

        public void SortujPoOcenie()
        {
            Lista.Sort(new RATEComparator());
        }

        public static void ZapiszJSON(string nazwaPliku, List l)
        {
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(List));
            //StreamWriter writer = new StreamWriter(nPliku);
            using (var fstream = File.Create(nazwaPliku))
            {
                jsonSerializer.WriteObject(fstream, l);
            }
        }
        public static List OdczytajJSON(string nazwaPliku)
        {
            // Deserializacja JSON
            try
            {
                FileStream fstream = new FileStream(nazwaPliku, FileMode.Open);
                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(List));
                fstream.Position = 0;
                List l = (List)jsonSerializer.ReadObject(fstream);
                fstream.Close();
                return l;
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Plik {0} nie istnieje!!!", nazwaPliku);
            }
            return null;
        }
    }
    class RATEComparator : IComparer<Movie>
    {
        public int Compare(Movie a, Movie b)
        {
            if (a != null && b != null)
                return a.AvgRate.CompareTo(b.AvgRate);
            else
                return 0;
        }
    }
}
