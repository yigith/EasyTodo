using System.ComponentModel.DataAnnotations;

namespace EasyTodoApi.Data
{
    public class TodoItem
    {
        public int Id { get; set; }

        [MaxLength(400)]
        public string Title { get; set; } = null!;

        public bool Done { get; set; }
    }
}
