using Core.Domain.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<TblAccount>> GetAccount();
        Task<int> AddAccount(TblAccount tblAccount);

        Task<TblAccount> GetAccountByPhone(string AccountPhone);

        string Md5Convert(string pass);
    }
}
