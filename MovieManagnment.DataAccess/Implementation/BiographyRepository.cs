using MovieManagnment.DataAccess.Context;
using MovieManagnment.Domain.Entities;
using MovieManagnment.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagnment.DataAccess.Implementation
{
    internal class BiographyRepository : GenericRepository<Biography>, IBiographyRepository
    {
        public BiographyRepository(MovieManagnmentDbConext context) : base(context)
        {
        }
    }
}
