using FlashCards.RemoteApi.Messages.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flashycard.Clients
{
    public interface IRestClient
    {

        Task<string> Get(string url);
        Task<string> Post(string url, CreateNewCardRequest request);
        Task<string> Post(string url, UpdateCardRequest request);
        Task<string> Delete(string url, DeleteCardRequest request);

    }
}
