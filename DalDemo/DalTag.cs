using GraphQlClient;
using ModelDemo;

namespace DalDemo
{
    public interface IDalTag
    {
        public Task<List<Tag>> ListTags();
        public Task AddTag(string name);
        public Task UpdateTag(int id, string name);
    }

    public class DalTag : IDalTag
    {
        public async Task AddTag(string name)
        {
            string query = @"
                mutation AddTag($input: AddTagCommandInput!) {
                    addTag(input: $input) {
                        tag {
                            id
                            name
                        }
                    }
                }";

            await Query.ExecuteMutationAsync<dynamic>(query, "AddTag", new { input = new { name } });
        }

        public async Task<List<Tag>> ListTags()
        {
            string query = @"
                query {
                    tags {
                        nodes {
                            id
                            name
                        }
                    }
                }";

            var result = await Query.ExecuteQueryAsync<TagListDto>(query);

            return result.tags.nodes;
        }

        public async Task UpdateTag(int id, string name)
        {
            string query = @"
                mutation UpdateTag($input: UpdateTagCommandInput!) {
                    updateTag(input: $input) {
                        tag {
                            id
                        }
                    }
                }";

            await Query.ExecuteMutationAsync<dynamic>(query, "UpdateTag", new { input = new { id, name } });
        }

        public class TagListDto
        {
            public NodeDto<Tag> tags { get; set; }
        }
    }
}
