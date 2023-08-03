using GraphQL.Client.Http;
using GraphQL;
using GraphQL.Client.Serializer.Newtonsoft;

namespace GraphQlClient
{
    public class Query
    {
        private static readonly GraphQLHttpClient graphQLHttpClient;

        static Query()
        {
            var uri = new Uri("https://localhost:44341/graphql");
            var graphQLOptions = new GraphQLHttpClientOptions
            {
                EndPoint = uri
                //HttpMessageHandler = new NativeMessageHandler(),
            };

            graphQLHttpClient = new GraphQLHttpClient(graphQLOptions, new NewtonsoftJsonSerializer());
        }


        public static async Task<T> ExecuteQueryAsync<T>(string completeQueryString)
        {
            try
            {
                var request = new GraphQLRequest
                {
                    Query = completeQueryString
                };

                var response = await graphQLHttpClient.SendQueryAsync<T>(request);

                return response.Data;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static async Task<T?> ExecuteMutationAsync<T>(string query, string operationName, object variables)
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

                if (response?.Errors?.Length > 0)
                {
                    throw new Exception(response.Errors[0].ToString());
                }

                return response.Data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }

}
