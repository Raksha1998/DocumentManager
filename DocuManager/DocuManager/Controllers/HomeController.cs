using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DocuManager.Models;
using Microsoft.Extensions.FileSystemGlobbing.Internal;
using Microsoft.VisualBasic;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Threading;
using DocuManager.Models;

namespace DocuManager.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        
        DocuManager.Models.Document document = new DocuManager.Models.Document()
        {
            Name = "Document 1",
            Type = "PDF",
            TypeIcon = "pdf-icon.png",
            PreviewImage = null,
            UploadDateTime = DateTime.Now.AddDays(-2),
            DownloadCount = 10,
            Id = 1
        };

        return View("index", document);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

}

