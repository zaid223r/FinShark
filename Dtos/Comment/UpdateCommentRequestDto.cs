using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Comment
{
    public class UpdateCommentRequestDto
    {
        [Required]
        [MinLength(5, ErrorMessage ="Title Must be more than 5 chars")]
        [MaxLength(280, ErrorMessage ="Title Must be less than 280 chars")]
        public string Title { get; set; } = string.Empty;

        [Required]
        [MinLength(5, ErrorMessage ="Content Must be more that 5 chars")]
        [MaxLength(280, ErrorMessage ="Content Must be less than 280 chars")]
        public string Content { get; set; } = string.Empty;
    }
}