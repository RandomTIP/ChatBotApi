using System.Security.Cryptography.X509Certificates;
using ChatBot.Data.BotEntityModels;
using ChatBot.Data.DTL;
using ChatBot.Data.QueryOptions;
using ChatBot.Data.Repositories;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace ChatBot.Service
{
    public class ChatBotQueryService
    {
        private readonly Repository _repository;

        public ChatBotQueryService(Repository repository)
        {
            this._repository = repository;
        }

        public int InsertProduct(Product product)
        {
            return _repository.Insert(product);
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

        public ServiceResponse RecognizeImage(ImageScore? score)
        {
            try
            {
                if (score == null)
                    return new ServiceResponse() { ResponseMessage = "სამწუხაროდ ფოტოს იდენტიფიცირება ვერ მოხერხდა" };

                var photos = score.GetNames();
                if (photos == null) return new ServiceResponse(){Products = null, ResponseMessage = "სამწუხაროდ მსგავსი პროდუქტი არ მოიძებნა"};

                var list = new List<Product?>();
                list.AddRange(photos.Select(photo => _repository.GetProductByPhoto(photo)).Where(mostSimilar => mostSimilar != null));
                if (list is null or { Count: 0})
                    return new ServiceResponse() { ResponseMessage = "სამწუხაროდ მსგავსი პროდუქტი ვერ მოიძებნა" };

                var others = _repository.GetProductList(new QueryOption() { ClothTypeId = list?.First()?.ClothTypeId });
                if (others == null)
                    return new ServiceResponse()
                        { Products = list, ResponseMessage = "ესენია ჩვენს მაღაზიაში არსებული მსგავსი პროდუქტები" };

                foreach (var product in others.Where(product => !list.Any(x => x.Id == product.Id)))
                {
                    list?.Add(product);
                }

                return new ServiceResponse()
                    { Products = list, ResponseMessage = "ესენია ჩვენს მაღაზიაში არსებული მსგავსი პროდუქტები" };
            }
            catch (Exception e)
            {
                e.GetType();
                throw;
            }
        }
    }
}