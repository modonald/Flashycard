namespace FlashCards.RemoteApi.Messages.Requests
{
    public class UpdateCardRequest
    {
        public string RowKey { get; set; }
        public string PartitionKey { get; set; }
        public string Topic { get; set; }
        public string Question { get; set; }
        public string ImageUrl { get; set; }
        public string ReferenceUrl { get; set; }
        public string Explanation { get; set; }
    }
}
