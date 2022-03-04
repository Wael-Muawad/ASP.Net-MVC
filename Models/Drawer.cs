using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_201810088.Models
{
    public class Drawer
    {
        [Key]
        public int DrawerId { get; set; }

        [StringLength(50, MinimumLength = 3)]
        [Column(TypeName = "nvarchar(50)")]
        public String Name { get; set; }

        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Invalid Email Address!")]
        public String EmailAddress { get; set; }

        [Display(Name = "Phone Number", Prompt = "Ex: 962 77 978 3269")]
        [Phone(ErrorMessage = "Invalid Phone Number!")]
        public String PhoneNumber { get; set; }

        [Range(35, 150,ErrorMessage = "Range between 35 and 150")]
        [Display(Name = "Cost Per Manga")]
        [DataType(DataType.Currency)]
        public double CostPerManga { get; set; }

        [Display(Name = "Profile Picture")]
        public String ProfilePicture { get; set; } = "/Images/Drawer.jpg";


        //Navigation
        public ICollection<Work> Works { get; set; }
    }
}
