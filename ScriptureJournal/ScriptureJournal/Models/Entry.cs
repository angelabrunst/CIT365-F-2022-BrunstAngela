using System.ComponentModel.DataAnnotations;

namespace ScriptureJournal.Models
{
    public class Entry
    {
        public int ID { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateAdded { get; set; }

        [StringLength(12, MinimumLength = 5)]
        [Required]
        public string Book { get; set; }
        public int Chapter { get; set; }
        public int Verse { get; set; }

        public string Notes { get; set; }
    }
}
