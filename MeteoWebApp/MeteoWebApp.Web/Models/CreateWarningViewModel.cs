using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeteoWebApp.Web.Models
{
    public partial class CreateWarningViewModel
    {
        public string Title { get; set; }
        public string Text { get; set; }
    }

    public partial class CreateWarningViewModel
    {
        public bool ValidateInputValues()
        {
            return !String.IsNullOrEmpty(this.Title) && !String.IsNullOrEmpty(this.Text);
        }
    }
}