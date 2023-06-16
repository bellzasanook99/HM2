using Core.Domain.Database;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class ViewService : IViewService
    {
        private hospitalmeet_dbContext _Hospitalmeet_DbContext { get; }

        public ViewService(hospitalmeet_dbContext cloudStokyDBContext)
        {
            _Hospitalmeet_DbContext = cloudStokyDBContext;
        }

        public async Task<IEnumerable<TblGroupBlog>> GetGroup()
        {
            return await _Hospitalmeet_DbContext.TblGroupBlogs.ToListAsync();
        }

        public async Task<IEnumerable<TblPromoteImg>> Getbanner()
        {
            return await _Hospitalmeet_DbContext.TblPromoteImgs.ToListAsync();
        }
        public async Task<IEnumerable<MtbLanguage>> GetLanguage()
        {
            return await _Hospitalmeet_DbContext.MtbLanguages.ToListAsync();
        }
        public async Task<IEnumerable<TblHeadManue>> GetHeaderMenus()
        {
            return await _Hospitalmeet_DbContext.TblHeadManues.ToListAsync();
        }
        

    }
}
