using DalDemo;
using ModelDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BalDemo
{
    public class BalConference
    {
        private readonly IDalConference _dalConference;

        public BalConference()
        {
            _dalConference = new DalConference();
        }

        public async Task<List<Conference>> ListConferences()
        {
            return await _dalConference.ListConferences();
        }

        public async Task AddConference(string name)
        {
            await _dalConference.AddConference(name);
        }

        public async Task UpdateConference(int id, string name)
        {
            await _dalConference.UpdateConference(id, name);
        }

        public async Task<Conference> Conference(int id)
        {
            return (await ListConferences()).FirstOrDefault(x => x.Id == id);
        }
    }
}
