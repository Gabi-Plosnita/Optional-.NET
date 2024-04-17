using LibraryManagement.Core.Dtos.Response;
using LibraryManagement.Database.Entities;

namespace LibraryManagement.Core.Mapping
{
    public static class BookMappingExtensions
    {
        public static BookResponseDto ToBookResponseDto(this Book book)
        {
            var result = new BookResponseDto
            {
                Id = book.Id,
                Title = book.Title,
            };

            return result;
        }
    }
}
