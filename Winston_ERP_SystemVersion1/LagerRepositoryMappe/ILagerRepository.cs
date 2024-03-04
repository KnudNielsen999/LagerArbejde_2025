using Winston_ERP_SystemVersion1.Lager_Repos;

namespace Winston_ERP_SystemVersion1.LagerRepository.Winston_ERP_SystemVersion1.Lager_Repos
{
    public interface ILagerRepository
    {
        Task CreateItemAsync(Lager_Data item);
        Task DeleteItemAsync(int id);
        Task<List<Lager_Data>> GetAllItemsAsync();
        Task<Lager_Data> GetItemByIdAsync(int id);
        Task UpdateItemAsync(Lager_Data item);
    }
}