using LibraryManagement.Core.Services;
using Microsoft.AspNetCore.Mvc;
using LibraryManagement.Core.Dtos.Response;
using LibraryManagement.Core.Dtos.Request;
using Microsoft.AspNetCore.Authorization;

namespace LibraryManagement.Api.Controllers
{
    [Route("api/Authors")]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorService _authorService;
        public AuthorsController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        [Authorize(Roles= "Admin")]
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public ActionResult<List<AuthorResponseDto>> GetAuthors()
        {
            return Ok(_authorService.GetAuthors());
        }

        [Authorize(Roles = "Author")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]

        public ActionResult<int> CreateAuthor([FromBody] AuthorRequestDto author)
        {
            int id = _authorService.CreateAuthor(author);
            return StatusCode(StatusCodes.Status201Created, id);
        }
    }
}
