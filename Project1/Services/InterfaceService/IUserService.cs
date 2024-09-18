using Project1.Comman;
using Project1.Entity.Model.Application;


namespace Project1.Services.InterfaceService
{
    public interface IUserService
    {
        Task<IApiResultModel> GetallAsync();
        Task<IApiResultModel> GetById(Guid Id);
        Task<bool> Insert(ApplicationUser user);
        Task<bool> Update(ApplicationUser user);    
        Task<bool> Delete(Guid Id);
    }
}
