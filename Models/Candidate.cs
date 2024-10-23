using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Candidates.Models
{
    public class Candidate
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string LastName { get; set; }
        [MinLength(13)]
        [MaxLength(13)]
        public string Jmbg { get; set; }
        public DateTime BirthDate { get; set; }
        [EmailAddress]
        [MaxLength(100)]
        public string Email { get; set; }
        public List<Link> Links { get; set; }
        [MaxLength(15)]
        public string PhoneNumber { get; set; }
        [MaxLength(300)]
        public string AdditionalInfo { get; set; }
        public DateTime LastUpdate { get; set; }
        public List<Attachment> Attachments { get; set; }
        [MaxLength(500)]
        public string PhotoFilePath { get; set; }
        public byte Rating { get; set; }
        public byte Status { get; set; }
        public List<StatusHistory> StatusLog { get; set; }
    }
}
