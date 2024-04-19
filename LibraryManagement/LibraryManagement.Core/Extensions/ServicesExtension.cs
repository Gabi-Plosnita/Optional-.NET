using LibraryManagement.Core.Services;
using LibraryManagement.Database.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace LibraryManagement.Core.Extensions
{
    public static class ServicesExtension
    {
        public static void AddBusinessServices(this IServiceCollection services)
        {
            services.AddScoped<IAuthorService, AuthorService>();
            services.AddScoped<IAuthorRepository, AuthorRepository>();

            services.AddScoped<IBookService, BookService>();
            services.AddScoped<IBookRepository, BookRepository>();
        }

    }
}
