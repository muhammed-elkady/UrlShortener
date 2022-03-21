using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UrlShortener.Models
{
    [Table("Urls")]
    public class Url
    {
        [Key]
        [DisplayName("Shortened Url")]
        public string UrlId { get; set; }

        [DisplayName("Url")]
        public string OriginalUrl { get; set; }
        public string Description { get; set; }

        [DisplayName("Date Saved")]
        public DateTime DateSaved { get; set; }
    }
}