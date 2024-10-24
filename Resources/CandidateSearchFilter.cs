using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidates.Resources
{
    public class CandidateSearchFilter
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Jmbg { get; set; }
        public DateTime LastUpdateFrom { get; set; }
        public DateTime LastUpdateTo { get; set; }
        public byte RatingFrom { get; set; }
        public byte RatingTo { get; set; }
        public byte Status { get; set; }
    }
}
