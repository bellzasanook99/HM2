using Core.Domain.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IViewService
    {
        Task<IEnumerable<TblGroupBlog>> GetGroup();
        Task<IEnumerable<TblPromoteImg>> Getbanner();

        Task<IEnumerable<MtbLanguage>> GetLanguage();

        Task<IEnumerable<TblHeadManue>> GetHeaderMenus();
    }
}
