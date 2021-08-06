using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProjectDemo.Abstract;

namespace GameProjectDemo.Entities
{
    public class Gamer:IPerson
    {
        public Gamer()
        {
            OwnGames = new List<Game>(); // Best Practices ?
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthOfDay { get; set; }
        public long NationalityId { get; set; }
        public double Money { get; set; }
        public List<Game> OwnGames { get; set; }
    }
}
