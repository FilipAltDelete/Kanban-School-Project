namespace Frontend.API.Model
{
    public class BoardDTO : IEntity
    {
        public string Title { get; set; }
        public int UserId { get; set; }
    }
}