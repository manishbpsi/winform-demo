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
        public List<Confrence> Confrences();
    }
    public class DalConfrence : IDalConfrence
    {
        public List<Confrence> Confrences()
        {
           List<Confrence> confrences = new List<Confrence>();
           confrences.Add(new Confrence{ Id=1, Name="London" });
           confrences.Add(new Confrence{ Id = 2, Name = "US" });
           confrences.Add(new Confrence{ Id = 3, Name = "Chicago" });
           confrences.Add(new Confrence{ Id = 4, Name = "Sydeny" });

            return confrences;
        }
    }
}
