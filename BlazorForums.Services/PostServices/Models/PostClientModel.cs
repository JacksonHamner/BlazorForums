namespace BlazorForums.Services.PostServices.Models
{
    public class PostClientModel
    {
        public int Id { get; set; }
        public int ForumId { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }
    }
}
