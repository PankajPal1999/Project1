using Project1.Comman;
using Project1.Context;
using Project1.Entity.Model.Comman;
using Project1.Entity.Model.Application;
using Project1.Services.InterfaceService;

namespace Project1.Services
{
    public class UserService : IUserService
    {
      public  readonly IUserService _userService;
      public  readonly AppDbContext _appDbContext;
        public UserService(IUserService userservice, AppDbContext appDbContext)
        {
            _userService = userservice;
            _appDbContext = appDbContext;
        }

        public Task<bool> Delete(Guid Id)
        {
            throw new NotImplementedException();
        }

        public async Task<IApiResultModel> GetallAsync()
        {
            IApiResultModel apiResultModel = null;
            ListModel<ApplicationUser> user = new ListModel<ApplicationUser>();
            user.List = _appDbContext.applicationUsers.ToList();
            apiResultModel = user;
            return apiResultModel;
        }

        public Task<IApiResultModel> GetById(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Insert(ApplicationUser user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(ApplicationUser user)
        {
            throw new NotImplementedException();
        }
    }
}
