using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConfig.Models
{

    [Table("CertTitle")]

    public class CertTitle
    {

        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public CertTitle(string title)
        {
            Title = title;
        }

        public CertTitle()
        {

        }
        override public string ToString()
        {
            return Title;
        }

    }
}