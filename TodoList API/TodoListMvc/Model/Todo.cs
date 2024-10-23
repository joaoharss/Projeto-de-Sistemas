namespace TodoListMvc.Model
{
    public class Todo
    {
        public int Id { get; private set; }
        public string? Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
