using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FrugalFigure.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string expenseType { get; set; } = "";

        [Column(TypeName = "nvarchar(10)")]
        public string Type { get; set; } = "Expense";

        [Column(TypeName = "nvarchar(25)")]
        public string EmailFK { get; set; } = "test123@gmail.com";
    }
}
