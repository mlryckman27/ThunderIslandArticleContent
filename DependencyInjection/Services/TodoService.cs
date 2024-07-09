using System.Net.Http.Json;

namespace DependencyInjection.Services
{
	public class TodoService
	{
		private readonly HttpClient _httpClient;

		public TodoService(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}

		public async Task<TodoItem[]> GetTodosAsync()
		{
			return await _httpClient.GetFromJsonAsync<TodoItem[]>("sample-data/todos.json");
		}
	}

	public class TodoItem
	{
		public string? Title { get; set; }
		public string? Description { get; set; }
		public bool IsDone { get; set; }
	}
}
