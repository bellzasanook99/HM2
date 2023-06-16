using Core.Domain.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class ViewModels
    {
       public IEnumerable<TblPromoteImg> tblPromoteImgs { get; set; }
    }
}
