using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Unicore.Services.Entities;

namespace Unicore.Services.Services
{
    public interface IUnicoreFarm
    {
        Task<List<UnicoreFarm>> Get();
        Task<UnicoreFarm> Get(int id);
        Task Create(UnicoreFarm entity);
        Task<UnicoreFarm> Update(UnicoreFarm entity);
        Task Delete(int id);
    }
}
