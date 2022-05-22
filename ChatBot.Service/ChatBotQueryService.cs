using ChatBot.Data.BotEntityModels;
using ChatBot.Data.Repositories;

namespace ChatBot.Service
{
    public class ChatBotQueryService
    {
        private readonly Repository _repository;

        public ChatBotQueryService(Repository repository)
        {
            this._repository = repository;
        }

        public ServiceResponse GetList(BotResponse? response)
        {
            if (response is null)
                return new ServiceResponse()
                    {Products = null, ResponseMessage = $"დაფიქსირდა შეცდომა: {response} არის ცარიელი!"};

            if(response.Intent is null)
                throw new ArgumentNullException(nameof(response.Intent));

            var res = _repository.GetProductList(response.Entities.InitializeQuery());

            return response.Intent.Name switch
            {
                ChatBotIntent.IfHave => res?.Count > 0
                    ? new ServiceResponse() {Products = res, ResponseMessage = "დიახ, გვაქვს"}
                    : new ServiceResponse() {Products = res, ResponseMessage = "სამწუხაროდ, არ გვაქვს :/"},

                ChatBotIntent.AskRange => res?.Count > 0
                    ? new ServiceResponse()
                    {
                        Products = res,
                        ResponseMessage = $"ეს პროდუქტი გვაქვს " +
                                          $"{res.OrderBy(x => x.Price).Select(x => x.Price).Last()}-დან" +
                                          $" {res.OrderBy(x => x.Price).Select(x => x.Price).First()}-მდე ფასებში"
                    }
                    : new ServiceResponse()
                    {
                        Products = res, ResponseMessage = "სამწუხაროდ მსგავსი დასახელების პროდუქტი არ გვაქვს :/"
                    },

                ChatBotIntent.HowMany => res?.Count > 0
                    ? new ServiceResponse()
                    {
                        Products = res, ResponseMessage = $"ასეთი პროდუქტი გვაქვს {res.Count} ცალი"
                    }
                    : new ServiceResponse()
                    {
                        Products = res, ResponseMessage = "სამწუხაროდ მსგავსი დასახელების პროდუქტი არ გვაქვს :/"
                    },
                _ => throw new ArgumentOutOfRangeException(nameof(response.Intent))
            };
        }
    }
}