using GraphQlClient;
using ModelDemo;

namespace DalDemo
{
    public interface IDalConference
    {
        public Task<List<Conference>> ListConferences();
        public Task AddConference(string name);
        public Task UpdateConference(int id, string name);
    }

    public class DalConference : IDalConference
    {
        public async Task AddConference(string name)
        {
            string query = @"
                mutation AddConference($input: AddConferenceCommandInput!) {
                    addConference(input: $input) {
                        conference {
                            id
                            name
                        }
                    }
                }";

            await Query.ExecuteMutationAsync<dynamic>(query, "AddConference", new { input = new { name } });
        }

        public async Task<List<Conference>> ListConferences()
        {
            string query = @"
                query {
                    conferences {
                        nodes {
                            id
                            name
                        }
                    }
                }";

            var result = await Query.ExecuteQueryAsync<ConferencesDto>(query);

            return result.conferences.nodes;
        }

        public async Task UpdateConference(int id, string name)
        {
            string query = @"
                mutation UpdateConference($input: UpdateConferenceCommandInput!) {
                    updateConference(input: $input) {
                        conference {
                            id
                        }
                    }
                }";

            await Query.ExecuteMutationAsync<dynamic>(query, "UpdateConference", new { input = new { id, name } });
        }

        public class ConferencesDto
        {
            public NodeDto<Conference> conferences { get; set; }
        }
    }
}
