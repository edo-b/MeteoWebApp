using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeteoWebApp.Infrastructure.Warning
{
    public interface IWarningQueries
    {
        IEnumerable<IWarning> GetWarningsByPage(int pageNumber);
        int GetNumberOfPages();
    }
}
