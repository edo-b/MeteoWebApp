using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeteoWebApp.Infrastructure.Warning
{
    public class Warning : IWarning
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string PublishedBy { get; set; }
        public DateTimeOffset PublishedOn { get; set; }
    }
}
