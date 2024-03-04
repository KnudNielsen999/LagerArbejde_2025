namespace Winston_ERP_SystemVersion1.LagerRepository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using global::Winston_ERP_SystemVersion1.DB_Entity;
    using global::Winston_ERP_SystemVersion1.Lager_Repos;

    namespace Winston_ERP_SystemVersion1.Lager_Repos
    {
        public class LagerRepository : ILagerRepository
        {
            private readonly LagerDatabase _context;

            public LagerRepository(LagerDatabase context)
            {
                _context = context;
            }

            // Opret et nyt varenummer
            public async Task CreateItemAsync(Lager_Data item)
            {
                _context.Add(item);
                await _context.SaveChangesAsync();
            }

            // Hent alle varenumre
            public async Task<List<Lager_Data>> GetAllItemsAsync()
            {
                return await _context.LagerData.ToListAsync();
            }

            // Hent et varenummer efter ID
            public async Task<Lager_Data> GetItemByIdAsync(int id)
            {
                return await _context.LagerData.FindAsync(id);
            }

            // Opdater et varenummer
            public async Task UpdateItemAsync(Lager_Data item)
            {
                _context.Entry(item).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }

            // Slet et varenummer
            public async Task DeleteItemAsync(int id)
            {
                var item = await _context.LagerData.FindAsync(id);
                _context.LagerData.Remove(item);
                await _context.SaveChangesAsync();
            }
        }
    }

}
