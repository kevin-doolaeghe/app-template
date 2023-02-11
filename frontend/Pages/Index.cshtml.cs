using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Net;

namespace frontend.Pages {

    public class IndexModel : PageModel {

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger) {
            _logger = logger;
        }

        public async Task OnGetAsync() {
            await FetchUsers();
        }

        public List<User> Users { get; set; } = new();

        public async Task FetchUsers() {
            using var httpClient = new HttpClient();
            using HttpResponseMessage response = await httpClient.GetAsync("http://backend/api/users");
            string json = await response.Content.ReadAsStringAsync();
            Users = JsonConvert.DeserializeObject<List<User>>(json) ?? new();
        }
    }

    public class User {

        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Email { get; set; }

        public string? Password { get; set; }
    }
}
