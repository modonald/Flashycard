namespace FlashCards.RemoteApi.Messages.Requests
{
    public class DeleteCardRequest
    {
        public string Topic { get; set; }
        public string Key { get; set; }
    }
}