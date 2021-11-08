using AdminsGuide.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminsGuide.Data.Repository
{
    public class SQLGuide : IGuide
    {
        private readonly DBContext _context;
        public SQLGuide(DBContext context)
        {
            _context = context; 
        }
        public void AddGuide(Guide guide)
        {
            _context.Add(guide);
            _context.SaveChanges();
        }

        public IEnumerable<Guide> GetAllGuides()
        {
            return _context.Guides;
        }

        public Guide GetGuideById(int guideId)
        {
            return _context.Guides.FirstOrDefault(g => g.Id == guideId);
        }

        public void RemoveGuide(int guideId)
        {
            _context.Remove(GetGuideById(guideId));
            _context.SaveChanges();
        }

        public void UpdateGuide(Guide guide)
        {
            var g = _context.Guides.Attach(guide);
            g.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
