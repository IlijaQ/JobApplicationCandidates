using Candidates.Models;
using Candidates.Resources;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidates.Data
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
            if (!string.IsNullOrEmpty(filter.Name))
            {
                filter.Name = filter.Name.ToLower();
                candidates = candidates.Where(n => n.Name.ToLower().Contains(filter.Name));
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
    }
}
