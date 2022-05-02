using KennyB.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace KennyB.Controllers
{
    public class CommentController : Controller
    {
        private readonly ILogger<CommentController> _logger;
        private readonly MyDbContext _dbContext;

        public CommentController(ILogger<CommentController> logger, MyDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        [HttpPost("comment")]
        public async Task<IActionResult> PostComment([FromBody] CommentInputModel commentInputModel)
        {
            var newComment = await _dbContext.Comments.FindAsync(commentInputModel.id);

            if (commentInputModel == null || commentInputModel.commentContent.Equals(' '))
            {
                return BadRequest();
            }

            newComment = new Comment();
            newComment.CommentContent = commentInputModel.commentContent;
            newComment.Name = commentInputModel.name;   
            newComment.Email = commentInputModel.email;

            _dbContext.Comments.Add(newComment);
            await _dbContext.SaveChangesAsync();

            return Ok(newComment);
        }

        [HttpDelete("comment/{id}")]
        public async Task <IActionResult> DeleteComment(int id)
        {
            var comment = await _dbContext.Comments.FindAsync(id);
            if (comment == null)
            {
                return NotFound();
            }
            
            _dbContext.Remove(comment);
            await _dbContext.SaveChangesAsync();
           

            return Ok();
        }

        [HttpGet("comment")]
        public async Task <IActionResult> GetAllComments()
        {
            var comments =  _dbContext.Comments.ToList();
            return Ok(comments);
        }


    }
    public class CommentInputModel
    {
        public int id { get; set; }
        public string commentContent { get; set; }
        public string name { get; set; }
        public string email { get; set; }
    }
}