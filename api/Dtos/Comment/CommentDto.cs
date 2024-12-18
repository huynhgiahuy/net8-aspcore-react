using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Comment
{
    public class CommentDto
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(200, ErrorMessage = "Title can not be over 200 characters")]
        [MinLength(1, ErrorMessage = "Title must be 1 character")]
        public string Title { get; set; } = string.Empty;
        [Required]
        [MaxLength(500, ErrorMessage = "Title can not be over 500 characters")]
        [MinLength(1, ErrorMessage = "Title must be 1 character")]
        public string Content { get; set; } = string.Empty;
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public int? StockId { get; set; }
    }
}