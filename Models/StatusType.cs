using System.ComponentModel.DataAnnotations;

namespace FinalProject_201810088
{
    public enum StatusType
    {
        [Display(Name = "On Progress")]
        OnProgress,
        [Display(Name = "Not Started")]
        NotStarted,
        Finished
    }
}