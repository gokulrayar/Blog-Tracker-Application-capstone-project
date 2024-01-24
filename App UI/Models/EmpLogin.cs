using System.ComponentModel.DataAnnotations;

namespace AppUI.Models
{
    public class EmpLogin
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public int PassCode { get; set; }

    }
}