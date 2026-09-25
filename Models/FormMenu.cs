using System.ComponentModel.DataAnnotations;

namespace DNX.Models
{
    public class FormMenu
    {
        [Key] public Guid MenuID { get; set; }
        public string? MenuName { get; set; }
        public string? Title { get; set; }
    }
}
