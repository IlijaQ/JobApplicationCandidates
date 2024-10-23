using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidates.Models
{
    public class Link
    {
        public int Id { get; set; }
        public int CandidateId { get; set; }
        public string UrlPath { get; set; }
    }
}
