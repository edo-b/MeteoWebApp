using MeteoWebApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeteoWebApp.Infrastructure.Warning
{
    public class WarningCommands : IWarningCommands
    {
        public void DeleteWarning(int id)
        {
            using(var db = new DatabaseModelContainer())
            {
                var dbWarning = db.Warnings.SingleOrDefault(x => x.Id == id);

                if(dbWarning != null)
                {
                    db.Warnings.Remove(dbWarning);
                    db.SaveChanges();
                }
            }
        }

        public void CreateWarning(string title, string text, string createdBy, DateTimeOffset createdOn)
        {
            using(var db = new DatabaseModelContainer())
            {
                var newWarning = new MeteoWebApp.Data.Warning
                {
                    TItle = title,
                    Text = text,
                    PublishedBy = createdBy,
                    PublishedOn = createdOn
                };

                db.Warnings.Add(newWarning);
                db.SaveChanges();
            }
        }
    }
}
