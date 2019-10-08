namespace DatingApp.API.Helpers
{
    public class MessageParams
    {
        private const int MaxSize = 50;
        public int PageNumber { get; set; } = 1;
        public int pageSize = 10;

        public int PageSize
        {
            get { return pageSize; }
            set { pageSize = (value>MaxSize)?MaxSize:(value); }
        }
        public int UserId { get; set; }
        public string MessageContainer { get; set; } = "Unread";
    }
}