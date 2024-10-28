using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateLog.Models
{
    public class StatusHistory
    {
        public int Id { get; set; }
        [ForeignKey("Candidate")]
        public int CandidateId { get; set; }
        public byte Status { get; set; }
        public DateTime StatusUpdate { get; set; }
        public virtual Candidate Candidate { get; set; }
    }
}
