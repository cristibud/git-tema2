using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Bilet
    {
        public int ID { get; set; }
        public Movie movie { get; set; }
        public int rand { get; set; }
        public int loc { get; set; }
        public DateTime data { get; set; }

    }

    public class BiletDBContext : DbContext
    {
        public DbSet<Bilet> Bilete { get; set; }
    }
}
