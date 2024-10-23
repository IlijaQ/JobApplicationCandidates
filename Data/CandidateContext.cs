﻿using Candidates.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidates.Data
{
    public class CandidateContext : DbContext
    {
        public CandidateContext() : base("name=CandidateContext")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<Link> Links { get; set; }
        public DbSet<Attachment> Attachments { get; set; }
        public DbSet<StatusHistory> StatusHistories { get; set; }
    }
}
