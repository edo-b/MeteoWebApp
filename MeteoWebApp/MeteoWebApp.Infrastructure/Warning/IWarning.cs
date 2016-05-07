using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeteoWebApp.Infrastructure.Warning
{
    public interface IWarning
    {
        int Id { get; set; }
        string Title { get; set; }
        string Text { get; set; }
        string PublishedBy { get; set; }
        DateTimeOffset PublishedOn { get; set; }
    }
}
