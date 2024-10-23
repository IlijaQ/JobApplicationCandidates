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
        [MaxLength(50)]
        public string FileName { get; set; }
        [MaxLength(500)]
        public string FilePath { get; set; }
        public byte Type { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
