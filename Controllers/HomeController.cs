using Microsoft.AspNetCore.Mvc;
using AmazonProject.Models;
using AmazonProject.Models.ViewModels;

namespace AmazonProject.Controllers;

public class HomeController : Controller
{
    private IBookRepository _bookRepository;

    public HomeController(IBookRepository temp)
    {
        _bookRepository = temp;
    }
    public IActionResult Index(int pageNum)
    {
        int pageSize = 10;

        var data = new BooksListViewModel
        {
            Books = _bookRepository.Books
                .OrderBy(x => x.Title)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),
            PaginationInfo = new PaginationInfo
            {
                CurrentPage = pageNum,
                ItemsPerPage = pageSize,
                TotalItems = _bookRepository.Books.Count()
            }
        };
        
        return View(data);
    }
}
