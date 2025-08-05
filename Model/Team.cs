using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? LogoUrl { get; set; }
        public string Coach { get; set; }

        public int SeasonId { get; set; }
        public Season Season { get; set; }

        public ICollection<Player> Players { get; set; }

    }
}
