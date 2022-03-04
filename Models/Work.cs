using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_201810088.Models
{
    public class Work
    {
        [Key]
        public int WorkId { get; set; }

        [Required]
        public int MangaId { get; set; }

        [Required]
        public int DrawerId { get; set; }

        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Display(Name = "End Date")]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        [Display(Name = "Air Time")]
        [DataType(DataType.Time)]
        public DateTime AirsAt { get; set; }

        public StatusType Status { get; set; } = StatusType.NotStarted;

        //Navigation
        public Manga Manga { get; set; }
        public Drawer Drawer { get; set; }
    }
}
