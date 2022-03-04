using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_201810088.Models
{
    public class Manga
    {
        [Key]
        public int MangaId { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public String Name { get; set; }

        [Display(Name = "Number Of Episodes")]
        [Range(12, 160, ErrorMessage = "Range between 12 and 160")]
        public int NoOfEpisodes { get; set; }

        [DataType(DataType.MultilineText)]
        public String Description { get; set; }

        [Display(Name = "Cover Image")]
        public byte[] CoverImage { get; set; }

        //Navigation
        public ICollection<Work> Works { get; set; }
    }
}
