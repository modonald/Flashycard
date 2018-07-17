using FlashCards.RemoteApi.Messages.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Flashycard.Clients
{
    public class RestClient : IRestClient
    {
        private const string UserAgent = "Card Presenter";
        private HttpClient _client;

        public RestClient()
        {
            _client = new HttpClient();
        }
        private void InitialiseHttpClientHeaders()
        {
            _client.DefaultRequestHeaders
            .Accept
            .Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _client.DefaultRequestHeaders.Add("User-Agent", UserAgent);
        }
        /* Create*/
        public async Task<string> Get(string url)
        {
            InitialiseHttpClientHeaders();
            var getContentTask = _client.GetStringAsync(url);
            return await getContentTask;
        }

        public Task<string> Post(string url, CreateNewCardRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<string> Post(string url, UpdateCardRequest request)
        {
            throw new NotImplementedException();
        }


        public Task<string> Delete(string url, DeleteCardRequest request)
        {
            throw new NotImplementedException();
        }

    }
}
