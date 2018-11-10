using System;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebService.Repository;

namespace WebService.Pages
{
    public class IndexModel : PageModel
    {
        private IRepository _repository;

        public string Hostname { get; set; }
        public string CurrentTime { get; set; }
        public int Counter { get; set; }
        public string Message { get; set; }

        public IndexModel(IRepository repository)
        {
            _repository = repository;
        }

        public void OnGet()
        {
            Hostname = Environment.GetEnvironmentVariable("HOSTNAME");
            CurrentTime = DateTime.Now.ToString("dd-mm-yyyy hh:mm:ss");
            
            Counter = _repository.GetCounter();
            Message = _repository.GetMessage();
        }
    }
}
