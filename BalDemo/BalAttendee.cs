using DalDemo;
using ModelDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalDemo
{
    public class BalAttendee
    {
        private readonly IDalAttendee _dalAttendee;
        public BalAttendee()
        {
            _dalAttendee = new DalAttendee();
        }

        public async Task<List<Attendee>> ListAttendees()
        {
            return await _dalAttendee.ListAttendees();
        }

        public async Task AddAttendee(string name)
        {
            await _dalAttendee.AddAttendee(new Attendee {  });
        }

        public async Task UpdateAttendee(int id, string name)
        {
            await _dalAttendee.UpdateAttendee(new Attendee { });
        }

        public async Task<Attendee> Attendees(int id)
        {
            return (await ListAttendees()).FirstOrDefault(x => x.Id == id);
        }
    }
}
