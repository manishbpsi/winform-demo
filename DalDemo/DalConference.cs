using GraphQlClient;
using ModelDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalDemo
{
    public interface IDalConfrence
    {
        public Task<List<Confrence>> Confrences();
        public Task AddConfrence(string name);
    }

    public class DalConference : IDalConfrence
    {
        public async Task AddConfrence(string name)
        {
            string query = @"mutation AddConference($input: AddConferenceCommandInput!) {
                    addConference(input: $input) {
                        conference {
                            id
                            name
                        }
                    }
                }";

            await Query.ExceuteMutaionAsync<dynamic>(query, "AddConference", new { input = new { name } });
        }

        public async Task<List<Confrence>> Confrences()
        {
            string query = @"query {
                              conferences {
                                nodes {
                                  id
                                  name
                                }
                              }
                            }";

            var result = await Query.ExceuteQueryAsync<ConferencesDto>(query);

            return result.conferences.nodes;
        }

        // {{  "conferences": {    "nodes": [      {        "name": "Test Conf"      },      {        "name": "Test Conf 1"      }    ]  }}}

        public class ConferencesDto
        {
            public NodeDto conferences { get; set; }
        }

        public class NodeDto
        {
            public List<Confrence> nodes { get; set; }
        }
    }
}
