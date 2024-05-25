using LibraryManagement.Core.Dtos.Request;
using LibraryManagement.Core.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.Api.Controllers
{
    [Route("api/Books")]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [Authorize(Roles = "Author")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public ActionResult<int> CreateBook([FromBody] BookRequestDto book)
        {
            int id = _bookService.CreateBook(book);
            return StatusCode(StatusCodes.Status201Created, id);
        }
    }
}
