using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TopshelfExample.Web.ViewModels.Home
{
    public class DownloadViewModel
    {
        [Required]
        public string Url { get; set; }
    }
}