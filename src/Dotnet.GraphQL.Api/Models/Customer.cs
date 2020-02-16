using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dotnet.GraphQL.Api.Models
{
    public class Customer : ObjectGraphType<Customer>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Status { get; set; }

        public Customer()
        {
            Name = "Customer";

            Field(x => x.Id).Description("Customer unique code");
            Field(x => x.FirstName).Description("Customer first name");
            Field(x => x.LastName).Description("Customer last name");
            Field(x => x.Status).Description("Customer status active or inactive");
        }
    }
}
