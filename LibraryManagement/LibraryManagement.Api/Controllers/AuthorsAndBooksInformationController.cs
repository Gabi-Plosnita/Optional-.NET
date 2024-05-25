using LibraryManagement.Core.Dtos.Request;
using LibraryManagement.Core.Dtos.Response;
using LibraryManagement.Core.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.Api.Controllers
{
    [Authorize]
    [Route("api/AuthorsAndBooksInformation")]
    public class AuthorsAndBooksInformationController : ControllerBase
    {
        private readonly IAuthorService _authorService;
        private readonly IBookService _bookService;

        public AuthorsAndBooksInformationController(IAuthorService authorService, IBookService bookService)
        {
            _authorService = authorService;
            _bookService = bookService;
        }

        [HttpGet("/Authors")]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public ActionResult<List<AuthorResponseDto>> GetAuthors()
        {
            return Ok(_authorService.GetAuthors());
        }

        [HttpGet("/Books")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        
        public ActionResult<List<BookResponseDto>> GetBooks()
        {
            return Ok(_bookService.GetBooks());
        }
    }
}
