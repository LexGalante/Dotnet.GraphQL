using Dotnet.GraphQL.Api.Contexts;
using Dotnet.GraphQL.Api.Models;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dotnet.GraphQL.Api.GraphQL
{
    public class GraphQLContextQuery : ObjectGraphType
    {
        public GraphQLContextQuery(ApiDbContext dbContext)
        {
            Field<ListGraphType<Customer>>("Customers", resolve: context => dbContext.Customers);
        }
    }
}
