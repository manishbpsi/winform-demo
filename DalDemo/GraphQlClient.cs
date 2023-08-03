using GraphQL.Client.Http;
using GraphQL;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphQL.Client.Serializer.Newtonsoft;
using ModelDemo;

namespace GraphQlClient
{
    public class Query
    {
        private static GraphQLHttpClient graphQLHttpClient;

        static Query()
        {
            var uri = new Uri("https://localhost:5001/graphql");
            var graphQLOptions = new GraphQLHttpClientOptions
            {
                EndPoint = uri
                //HttpMessageHandler = new NativeMessageHandler(),
            };

            graphQLHttpClient = new GraphQLHttpClient(graphQLOptions, new NewtonsoftJsonSerializer());
        }


        public static async Task<T> ExceuteQueryAsync<T>(string completeQueryString)
        {
            try
            {
                var request = new GraphQLRequest
                {
                    Query = completeQueryString
                };

                var response = await graphQLHttpClient.SendQueryAsync<T>(request);

                return response.Data;
                //var stringResult = response.Data.ToString();
                //stringResult = stringResult.Replace($"\"{graphQLQueryType}\":", string.Empty);
                //stringResult = stringResult.Remove(0, 1);
                //stringResult = stringResult.Remove(stringResult.Length - 1, 1);

                //var result = JsonConvert.DeserializeObject<List<T>>(stringResult);

                //return result;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static async Task<T> ExceuteMutaionAsync<T>(string query, string operationName, object variables)
        {
            try
            {
                var request = new GraphQLRequest
                {
                    Query = query,
                    OperationName = operationName,
                    Variables = variables
                };

                var response = await graphQLHttpClient.SendQueryAsync<T>(request);

                return response.Data;
                //var stringResult = response.Data.ToString();
                //stringResult = stringResult.Replace($"\"{graphQLQueryType}\":", string.Empty);
                //stringResult = stringResult.Remove(0, 1);
                //stringResult = stringResult.Remove(stringResult.Length - 1, 1);

                //var result = JsonConvert.DeserializeObject<List<T>>(stringResult);

                //return result;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static async Task<T> ExceuteQueryAsyn<T>(string graphQLQueryType, string completeQueryString)
        {
            try
            {
                var request = new GraphQLRequest
                {
                    Query = completeQueryString
                };

                var response = await graphQLHttpClient.SendQueryAsync<object>(request);

                var stringResult = response.Data.ToString();
                stringResult = stringResult.Replace($"\"{graphQLQueryType}\":", string.Empty);
                stringResult = stringResult.Remove(0, 1);
                stringResult = stringResult.Remove(stringResult.Length - 1, 1);

                var result = JsonConvert.DeserializeObject<T>(stringResult);

                return result;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }


}
