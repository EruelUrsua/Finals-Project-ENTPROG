using System.ComponentModel.DataAnnotations;

namespace FinalProject.App.Models
{
    public class MedicalVM
    {
        public int Id { get; set; }

        
        public DateTime Date { get; set; }

        public String Vaccine { get; set; }

        public String Location { get; set; }

        public int Slots { get; set; }

        public DateTime Time { get; set; }
    }
}
