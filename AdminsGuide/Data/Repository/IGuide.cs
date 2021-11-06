using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminsGuide.Data.Models;

namespace AdminsGuide.Data.Repository
{
    public interface IGuide
    {
        IEnumerable<Guide> GetAllGuides();
        void AddGuide(Guide guide);
        void RemoveGuide(int guideId);
        void UpdateGuide(Guide guide);
        Guide GetGuideById(int guideId);

    }
}
