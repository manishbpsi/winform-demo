﻿using DalDemo;
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

        public List<Confrence> Confrences()
        {
            return _dalConfrence.Confrences(); 
        }

        public Confrence Confrence(int id)
        {
            return Confrences().FirstOrDefault(x=>x.Id==id);
        }
    }
}