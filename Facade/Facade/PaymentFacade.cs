using System;
using System.Collections.Generic;
using Facade.Entity;
using MercadoPago.Client.Common;
using MercadoPago.Client.Payment;
using MercadoPago.Config;
using MercadoPago.Http;
using MercadoPago.Resource.Payment;

namespace Facade.Facade
{
    public class PaymentFacade
    {
        public string Pay(Buyer buyer, Product product)
        {
            Console.WriteLine("PaymentFacade has been started...");

            Console.WriteLine($"Start payment in Mercado Pago for {product.Name} by {buyer.FirstName}...");

            ConfigureMercadoPago();
            var request = GetPaymentCreateRequest(buyer, product);
            var status = MakePayment(request);
            
            Console.WriteLine("PaymentFacade has been completed.");
            return status;
        }

        private static void ConfigureMercadoPago()
        {
            Console.WriteLine("Configuring Mercado Pago Gateway...");
            MercadoPagoConfig.RetryStrategy = new DefaultRetryStrategy(5);
            MercadoPagoConfig.AccessToken = GetAccessToken();
            MercadoPagoConfig.CorporationId = GetCorporationId();
            MercadoPagoConfig.IntegratorId = GetIntegratorId();
            Console.WriteLine("Mercado Pago Gateway has been configured...");
        }

        private static PaymentCreateRequest GetPaymentCreateRequest(Buyer buyer, Product product)
        {
            Console.WriteLine("Instantiating PaymentCreateRequest Mercado Pago object...");

            return new PaymentCreateRequest
            {
                AdditionalInfo = new PaymentAdditionalInfoRequest
                {
                    Items = new List<PaymentItemRequest>
                    {
                        new PaymentItemRequest
                        {
                            Quantity = product.Quantity,
                            UnitPrice = product.UnitPrice,
                            Description = $"This is a {product.Name}"
                        }
                    },
                    Payer = new PaymentAdditionalInfoPayerRequest
                    {
                        Address = new AddressRequest
                        {
                            StreetName = buyer.Address.StreetName,
                            StreetNumber = buyer.Address.StreetNumber,
                            ZipCode = buyer.Address.ZipCode
                        },
                        FirstName = buyer.FirstName,
                        LastName = buyer.LastName,
                    },
                    Shipments = new PaymentShipmentsRequest
                    {
                        ReceiverAddress = new PaymentReceiverAddressRequest
                        {
                            StreetName = buyer.Address.StateName,
                            StreetNumber = buyer.Address.StreetNumber,
                            CityName = buyer.Address.CityName,
                            StateName = buyer.Address.StateName,
                            ZipCode = buyer.Address.ZipCode
                        }
                    }
                },
                TransactionAmount = 10,
                Token = GetBuyerCardToken(buyer.Id),
                Installments = 1,
                PaymentMethodId = "visa",
                Payer = new PaymentPayerRequest
                {
                    Email = buyer.Email,
                },
            };
        }

        private static string GetBuyerCardToken(Guid id)
        {
            var cardToken = "6KeiNLU7ZblUpQsq4iARv8JPIiEjSXjOvlX8WH3KHduWTNcLTAsey0S46meO7ltqxgnhNgRijc40N4zwuSyQ";
            Console.WriteLine($"The buyer {id} has the folloing card token {cardToken}");
            return cardToken;
        }

        private static string GetAccessToken()
        {
            var acessToken = "jFvJF8G88ayb7rLTeFzBEahKQGtG9da4wvp2tFYbF9XpaA7Z6gtmgAHJ7Z2SQ2LbmL3qgDczpZMprwe8CxjwH";
            Console.WriteLine($"The Access Token is {acessToken}");
            return acessToken;
        }

        private static string GetCorporationId()
        {
            var corporationId = "01176781987487579533077938275";
            Console.WriteLine($"The Corporation Id is {corporationId}");
            return corporationId;
        }

        private static string GetIntegratorId()
        {
            var integratorId = "QyLcRUUPHhCcHaIjAAzsicsmZvL4t";
            Console.WriteLine($"The Integrator Id is {integratorId}");
            return integratorId;
        }

        private static string MakePayment(PaymentCreateRequest request)
        {
            var client = new PaymentClient();
            //var payment = await client.CreateAsync(request);
            var fakePayment = new Payment { Status = "Successful" };
            Console.WriteLine($"The payment status is {fakePayment.Status}");
            return fakePayment.Status;
        }
    }
}
