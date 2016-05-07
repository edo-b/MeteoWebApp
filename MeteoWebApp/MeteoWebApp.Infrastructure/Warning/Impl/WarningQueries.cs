using MeteoWebApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeteoWebApp.Infrastructure.Warning
{
    public class WarningQueries : IWarningQueries
    {
        public const int NumberOfWarningsByPage = 10;

        public IEnumerable<IWarning> GetWarningsByPage(int pageNumber)
        {
            using(var db = new DatabaseModelContainer())
            {
                var dbWarnings = db.Warnings
                                    .OrderByDescending(x => x.PublishedOn)
                                    .Skip((pageNumber - 1)*NumberOfWarningsByPage)
                                    .Take(NumberOfWarningsByPage)
                                    .Select(warning => new Warning()
                                    {
                                        Id = warning.Id,
                                        Title = warning.TItle,
                                        Text = warning.Text,
                                        PublishedBy = warning.PublishedBy,
                                        PublishedOn = warning.PublishedOn
                                    });

                return dbWarnings.ToList();
            }
        }

        public int GetNumberOfPages()
        {
            using(var db = new DatabaseModelContainer())
            {
                var numberOfWarnings = (double)db.Warnings.Count();

                return (int)Math.Ceiling(numberOfWarnings / NumberOfWarningsByPage);
            }
        }
    }
}
