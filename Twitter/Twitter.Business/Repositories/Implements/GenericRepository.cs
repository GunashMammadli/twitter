using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitter.Business.Repositories.Interfaces;
using Twitter.Core.Entities.Common;

namespace Twitter.Business.Repositories.Implements
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        public DbSet<T> Table { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public IQueryable<T> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
