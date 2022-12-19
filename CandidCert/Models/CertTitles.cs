using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidCert.Models
{
    public class CertTitles
    {
        [Key]
        public string Title { get; set; }
        public CertTitles(string title)
        {
            Title = title;
        }

        public CertTitles()
        {

        }
        override public string ToString()
        {
            return Title;
        }

    }
}
