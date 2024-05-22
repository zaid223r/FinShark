using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Mappers;
using api.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    
    [Route("api/comment")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly CommentRepository _commentRepo;
        public CommentController(CommentRepository commentRepo)
        {
            _commentRepo = commentRepo;            
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var commentModel = await _commentRepo.GetAllAsync();
            var comments = commentModel.Select(s => s.ToCommentDto());
            return Ok(comments);
        }

    }
}