using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Unicore.Services.Entities;

namespace Unicore.Services.Services
{
    public interface IOwner
    {
        Task<List<Owner>> Get();
        Task<Owner> Get(int id);
        Task Create(Owner entity);
        Task<Owner> Update(Owner entity);
        Task Delete(int id);
    }
}
