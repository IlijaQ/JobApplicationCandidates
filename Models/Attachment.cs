using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidates.Models
{
    public class Attachment
    {
        public int Id { get; set; }
        [ForeignKey("Candidate")]
        public int CandidateId { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public byte Type { get; set; }
        public DateTime LastUpdate { get; set; }
        public virtual Candidate Candidate { get; set; }
    }
}
