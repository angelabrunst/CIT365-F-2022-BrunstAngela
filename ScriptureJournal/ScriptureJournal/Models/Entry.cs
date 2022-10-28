using System.ComponentModel.DataAnnotations;

namespace ScriptureJournal.Models
{
    public class Entry
    {
        public int ID { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateAdded { get; set; }

        [Display(Name = "Book")]
        [Required]
        public string Book { get; set; }

        [Display(Name = "Chapter")]
        [Required]
        public int Chapter { get; set; }

        [Display(Name = "Verse")]
        [Required]
        public int Verse { get; set; }

        [Display(Name = "Notes")]
        [Required]
        public string Notes { get; set; }
    }
}
