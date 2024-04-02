using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Entity
{
    public class Movie
    {
        public int ID { get; set; }
        public string? Category { get; set; }
        public string? Name { get; set; }
        public string? Time { get; set; }
        public DateTime Date { get; set; }
    }
}
