using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateLog.Models
{
    public class Link
    {
        public int Id { get; set; }
        [ForeignKey("Candidate")]
        public int CandidateId { get; set; }
        public string UrlPath { get; set; }
        public virtual Candidate Candidate { get; set; }
    }
}
