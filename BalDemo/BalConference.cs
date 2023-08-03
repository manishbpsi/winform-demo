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
        private readonly IDalConfrence _dalConfrence;
        public BalConference()
        {
            _dalConfrence = new DalConference();
        }

        public async Task<List<Confrence>> Confrences()
        {
            return await _dalConfrence.Confrences(); 
        }

        public async Task AddConfrence(string name)
        {
            await _dalConfrence.AddConfrence(name);
        }

        public async Task<Confrence> Confrence(int id)
        {
            return (await Confrences()).FirstOrDefault(x => x.Id == id);
        }
    }
}
