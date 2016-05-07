using MeteoWebApp.Infrastructure.Warning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeteoWebApp.Web.Models
{
    public partial class WarningViewModel
    {
        public int PageNumber { get; set; }
    }

    public partial class WarningViewModel
    {
        public IEnumerable<IWarning> Warnings
        {
            get
            {
                if(_warnings == null)
                {
                    _warnings = new Lazy<IEnumerable<IWarning>>(() => _warningQueries.GetWarningsByPage(PageNumber));
                }

                return _warnings.Value;
            }
        }
        private Lazy<IEnumerable<IWarning>> _warnings;

        public int NumberOfPages
        {
            get
            {
                return _warningQueries.GetNumberOfPages();
            }
        }
    }

    public partial class WarningViewModel
    {
        private IWarningQueries _warningQueries;
        public WarningViewModel()
        {
            _warningQueries = new WarningQueries();
        }
    }
}