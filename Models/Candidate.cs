using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CandidateLog.Models
{
    public class Candidate
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Jmbg { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Link> Links { get; set; }
        public string PhoneNumber { get; set; }
        public string AdditionalInfo { get; set; }
        public DateTime LastUpdate { get; set; }
        public virtual ICollection<Attachment> Attachments { get; set; }
        public string PhotoFilePath { get; set; }
        public byte Rating { get; set; }
        public byte Status { get; set; }
        public virtual ICollection<StatusHistory> StatusHistories { get; set; }

        
    }
}
