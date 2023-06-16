using Core.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IToolsService
    {
        object RestApiController(RestApiType restApiType, string url, object input, string JWT = null);
    }
}
