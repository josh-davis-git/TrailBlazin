using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrailBlazinAPI.Models;
using TrailBlazinAPI.Repository.IRepository;

namespace TrailBlazinAPI.Repository
{
    public class TrailRepository : ITrailRepository
    {
        public bool CreateTrail(Trail trail)
        {
            throw new NotImplementedException();
        }

        public bool DeleteTrail(Trail trail)
        {
            throw new NotImplementedException();
        }

        public Trail GetTrail(int trailId)
        {
            throw new NotImplementedException();
        }

        public ICollection<Trail> GetTrails()
        {
            throw new NotImplementedException();
        }

        public ICollection<Trail> GetTrailsInNationalPark(int npId)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool TrailExists(string name)
        {
            throw new NotImplementedException();
        }

        public bool TrailExists(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateTrail(Trail trail)
        {
            throw new NotImplementedException();
        }
    }
}
