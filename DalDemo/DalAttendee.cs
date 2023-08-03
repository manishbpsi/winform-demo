using GraphQlClient;
using ModelDemo;

namespace DalDemo
{
    public interface IDalAttendee
    {
        public Task<List<Attendee>> ListAttendees();
        public Task AddAttendee(Attendee attendee);
        public Task UpdateAttendee(Attendee attendee);
    }

    public class DalAttendee : IDalAttendee
    {
        public async Task AddAttendee(Attendee attendee)
        {
            string query = @"
                mutation AddAttendee($input: RegisterAttendeeCommandInput!) {
                    registerAttendee(input: $input) {
                        attendee {
                            id
                        }
                    }
                }";

            await Query.ExecuteMutationAsync<dynamic>(query, "AddAttendee", new
            {
                input = new
                {
                    firstName = attendee.FirstName,
                    lastName = attendee.LastName,
                    emailAddress = attendee.EmailAddress,
                    userName = attendee.UserName
                }
            });
        }

        public async Task<List<Attendee>> ListAttendees()
        {
            string query = @"
                query {
                    attendees {
                        nodes {
                            id
                            firstName
                            lastName
                            userName
                            emailAddress
                        }
                    }
                }";

            var result = await Query.ExecuteQueryAsync<AttendeeListDto>(query);

            return result.attendees.nodes;
        }

        public async Task UpdateAttendee(Attendee attendee)
        {
            string query = @"
                mutation UpdateAttendee($input: UpdateAttendeeCommandInput!) {
                    updateAttendee(input: $input) {
                        conference {
                            id
                        }
                    }
                }";

            await Query.ExecuteMutationAsync<dynamic>(query, "UpdateAttendee", new
            {
                input = new
                {
                    id = attendee.Id,
                    firstName = attendee.FirstName,
                    lastName = attendee.LastName,
                    emailAddress = attendee.EmailAddress,
                    userName = attendee.UserName
                }
            });
        }

        public class AttendeeListDto
        {
            public NodeDto<Attendee> attendees { get; set; }
        }
    }
}
