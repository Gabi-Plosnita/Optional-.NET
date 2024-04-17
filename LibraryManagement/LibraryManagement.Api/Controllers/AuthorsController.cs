using LibraryManagement.Core.Services;
using Microsoft.AspNetCore.Mvc;
using LibraryManagement.Core.Dtos.Response;

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

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public ActionResult<List<AuthorResponseDto>> GetAuthors()
        {
            return Ok(_authorService.GetAuthors());
        }
    }
}
