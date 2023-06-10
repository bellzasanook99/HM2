using Core.Domain.Database;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class UserService: IUserService
    {
        private hospitalmeet_dbContext  _Hospitalmeet_DbContext { get; }

        public UserService(hospitalmeet_dbContext cloudStokyDBContext)
        {
            _Hospitalmeet_DbContext = cloudStokyDBContext;
        }
        public async Task<IEnumerable<TblAccount>> GetAccount()
        {
            return await _Hospitalmeet_DbContext.TblAccounts.ToListAsync();
        }
    }
}
