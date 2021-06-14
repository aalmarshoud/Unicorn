using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unicore.Services.DBContexts;
using Unicore.Services.Entities;

namespace Unicore.Services.Services
{
    public class UnicoreFarmService : IUnicoreFarm
    {
        private readonly DBContext DB;
        public UnicoreFarmService(IServiceProvider serviceProvider)
        {
            DB = serviceProvider.GetRequiredService<DBContext>();
        }
        public async Task Create(UnicoreFarm entity)
        {
            DB.UnicoreFarm.Add(entity);
            await DB.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var cureent = await DB.UnicoreFarm.FindAsync(id);
            DB.UnicoreFarm.Remove(cureent);
            await DB.SaveChangesAsync();
        }

        public async Task<List<UnicoreFarm>> Get()
        {
            return await DB.UnicoreFarm.Include(x => x.Owner).ToListAsync();
        }

        public async Task<UnicoreFarm> Get(int id)
        {
            return await DB.UnicoreFarm
                           .Include(x => x.Owner)
                           .Where(x => x.Id == id)
                           .FirstOrDefaultAsync();
        }

        public async Task<UnicoreFarm> Update(UnicoreFarm entity)
        {
            var cureent = await DB.UnicoreFarm.FindAsync(entity.Id);
            cureent.UnicoreName = entity.UnicoreName;
            cureent.Description = entity.Description;
            cureent.OwnerId = entity.OwnerId;
            await DB.SaveChangesAsync();
            return cureent;
        }
    }
}
