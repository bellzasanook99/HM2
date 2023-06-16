using Core.Domain.Database;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.IdentityModel.Tokens.Jwt;

namespace Core.Services
{
    public class UserService: IUserService
    {
        private hospitalmeet_dbContext _Hospitalmeet_DbContext { get; }

        public UserService(hospitalmeet_dbContext cloudStokyDBContext)
        {
            _Hospitalmeet_DbContext = cloudStokyDBContext;
        }
        public async Task<IEnumerable<TblAccount>> GetAccount()
        {
            return await _Hospitalmeet_DbContext.TblAccounts.ToListAsync();
        }



        public async Task<TblAccount> GetAccountByPhone(string AccountPhone)
        {
            return await _Hospitalmeet_DbContext.TblAccounts.Where(m=>m.AccountPhone == AccountPhone).FirstOrDefaultAsync();
        }
        public async Task<int> AddAccount(TblAccount tblAccount)
        {
            return await _Hospitalmeet_DbContext.TblAccounts.Add(tblAccount).Context.SaveChangesAsync() ;
        }


     

        public string Md5Convert(string pass)
        {
            string source = pass;
            using (MD5 md5Hash = MD5.Create())
            {
                var result =GetMd5Hash(md5Hash, source); 
                //    Console.WriteLine("The MD5 hash of " + source + " is: " + hash + ".");

                return result;
            }
        }

        private string GetMd5Hash(MD5 md5Hash, string input)
        {
            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
    }
}
