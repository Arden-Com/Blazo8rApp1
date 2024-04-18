using System.ComponentModel.DataAnnotations;

namespace Blazor8App1.Models
{
    public class Mammal
    {
        public int Id { get; set; }
        
        [Display(Name = "English Name"), StringLength(30)]
        public string EnglishName { get; set; }
        
        [Display(Name = "Latin Name"), StringLength(50)]
        
        public string LatinName { get; set; }
        
        public string Species { get; set; }
        
        public string Description { get; set; }
    }
}
