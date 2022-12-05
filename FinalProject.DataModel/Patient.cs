using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DataModel
{
    public class Patient
    {
        public int PatientID { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public DateTime Birthday { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public string Brand { get; set; }
    }
}
