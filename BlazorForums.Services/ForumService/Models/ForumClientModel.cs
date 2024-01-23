namespace BlazorForums.Services.ForumService.Models
{
    public class ForumClientModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public int Order { get; set; }
    }
}
