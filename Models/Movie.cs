using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string titlu { get; set; }
        public string regia { get; set; }
        public string distributia { get; set; }
        public DateTime dataPremiera { get; set; }
        public int nrBilete { get; set; }
        public DateTime ora { get; set; }
        public DateTime dataFinal { get; set; }


    }
    public class MovieDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}
