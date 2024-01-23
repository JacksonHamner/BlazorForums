namespace BlazorForums.Data.Entities
{
    public class Forum
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public int Order { get; set; }

        public virtual IEnumerable<Post> Posts { get; set; }

    }
}
