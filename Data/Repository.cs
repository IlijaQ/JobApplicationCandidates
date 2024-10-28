using CandidateLog.Models;
using CandidateLog.Resources;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateLog.Data
{
    public class Repository
    {
        private readonly CandidateContext _context;
        public Repository(CandidateContext context)
        {
            _context = context;
        }

        public List<Candidate> GetAllCandidates(CandidateSearchFilter filter)
        {
            var candidates = _context.Candidates.AsQueryable();

            candidates = ApplyFilters(filter, candidates);

            return candidates.ToList();
        }
        private static IQueryable<Candidate> ApplyFilters(CandidateSearchFilter filter, IQueryable<Candidate> candidates)
        {
            if (!string.IsNullOrEmpty(filter.FirstName))
            {
                filter.FirstName = filter.FirstName.ToLower();
                candidates = candidates.Where(n => n.Name.ToLower().Contains(filter.FirstName));
            }
            if (!string.IsNullOrEmpty(filter.LastName))
            {
                filter.LastName = filter.LastName.ToLower();
                candidates = candidates.Where(ln => ln.LastName.ToLower().Contains(filter.LastName));
            }
            if (!string.IsNullOrEmpty(filter.Jmbg))
                candidates = candidates.Where(id => id.Jmbg == filter.Jmbg);

            if (filter.LastUpdateFrom != null)
                candidates = candidates.Where(d => d.LastUpdate > filter.LastUpdateFrom);
            if (filter.LastUpdateFrom != null)
                candidates = candidates.Where(d => d.LastUpdate < filter.LastUpdateTo);

            if (filter.RatingFrom != null)
                candidates = candidates.Where(r => r.Rating > filter.RatingFrom);
            if (filter.RatingTo != null)
                candidates = candidates.Where(r => r.Rating < filter.RatingTo);

            if (filter.Status != null)
                candidates = candidates.Where(s => s.Status == filter.Status);
            return candidates;
        }

        public Candidate GetCandidate(int id)
        {
            return _context.Candidates.Where(i => i.Id == id)
                .Include(l => l.Links)
                .Include(h => h.StatusHistories)
                .FirstOrDefault();
        }

        public void CreateCandidate(Candidate candidate)
        {
            _context.Candidates.Add(candidate);
            _context.SaveChanges();
        }

        public bool UpdateCandidate(Candidate candidateWithUpdates)
        {
            var candidateExist = _context.Candidates.FirstOrDefault(i => i.Id == candidateWithUpdates.Id);

            if(candidateExist == null)
                return false;

            _context.Candidates.Attach(candidateWithUpdates);

            _context.Entry(candidateWithUpdates).State = EntityState.Modified;

            foreach (Link l in candidateWithUpdates.Links)
                _context.Entry(l).State = EntityState.Modified;

            foreach (StatusHistory sh in candidateWithUpdates.StatusHistories)
                _context.Entry(sh).State = EntityState.Modified;

            _context.SaveChanges();
            return true;
        } 

        public bool DeleteCandidate(int id)
        {
            var candidate = _context.Candidates
                .Include(l => l.Links)
                .Include(s => s.StatusHistories)
                .FirstOrDefault(i => i.Id == id);

            if (candidate == null)
                return false;

            _context.Candidates.Remove(candidate);
            _context.SaveChanges();
            return true;
        }

        public void CreateAttachment(Attachment document)
        {
            _context.Attachments.Add(document);
            _context.SaveChanges ();
        }

        public bool DeleteAttachment(int id)
        {
            var document = _context.Attachments.FirstOrDefault(i => i.Id == id);

            if (document == null)
                return false;

            _context.Attachments.Remove(document);
            _context.SaveChanges();
            return true;
        }

        public void AddStatusHistoryEntry(StatusHistory entry)
        {
            _context.StatusHistories.Add(entry);
            _context.SaveChanges();
        }
    }
}
