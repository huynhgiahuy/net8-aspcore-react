using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Comment;

namespace api.Dtos.Stock
{
    public class StockDto
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(200, ErrorMessage = "Symbol can not be over 200 characters")]
        [MinLength(1, ErrorMessage = "Symbol must be 1 character")]
        public string Symbol { get; set; } = string.Empty;
        [Required]
        [MaxLength(200, ErrorMessage = "Company Name can not be over 200 characters")]
        [MinLength(1, ErrorMessage = "Company Name must be 1 character")]
        public string CompanyName { get; set; } = string.Empty;
        [Required]
        [Range(1, 1000000)]
        public decimal Purchase { get; set; }
        [Required]
        [Range(0.001, 100)]
        public decimal LastDiv { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "Industry can not be over 100 characters")]
        public string Industry { get; set; } = string.Empty;
        [Range(1, 5000000000)]
        public long MarketCap { get; set; }
        public List<CommentDto> Comments { get; set; }
    }
}