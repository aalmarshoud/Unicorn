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
    public class OwnerService : IOwner
    {
        private readonly DBContext DB;
        public OwnerService(IServiceProvider serviceProvider)
        {
            DB = serviceProvider.GetRequiredService<DBContext>();
        }
        public async Task Create(Owner entity)
        {
            DB.Owners.Add(entity);
            await DB.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var cureent = await DB.Owners.FindAsync(id);
            DB.Owners.Remove(cureent);
            await DB.SaveChangesAsync();
        }

        public async Task<List<Owner>> Get()
        {
            return await DB.Owners.ToListAsync();
        }

        public async Task<Owner> Get(int id)
        {
            return await DB.Owners.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<Owner> Update(Owner entity)
        {
            var cureent = await DB.Owners.FindAsync(entity.Id);
            cureent.Name = entity.Name;
            cureent.Mobile = entity.Mobile;
            cureent.Email = entity.Email;
            cureent.Address = entity.Address;
            await DB.SaveChangesAsync();
            return cureent;
        }
    }
}
