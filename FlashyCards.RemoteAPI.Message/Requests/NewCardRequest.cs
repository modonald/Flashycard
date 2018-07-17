namespace FlashCards.RemoteApi.Messages.Requests
{
    public class CreateNewCardRequest
    {
        public string Topic { get; set; }
        public string Question { get; set; }
        public string ImageUrl { get; set; }
        public string ReferenceUrl { get; set; }
        public string Explanation { get; set; }
    }
}