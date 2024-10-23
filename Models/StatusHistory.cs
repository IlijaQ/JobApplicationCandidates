using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidates.Models
{
    public class StatusHistory
    {
        public int Id { get; set; }
        public int CandidateId { get; set; }
        public byte Status { get; set; }
        public DateTime StatusUpdate { get; set; }
    }
}
