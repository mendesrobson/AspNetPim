using ProjetoPIM.Context;
using ProjetoPIM.Models;
using System;
using System.Linq;

namespace ProjetoPIM.Confugurations
{
    public static class DbInitializer
    {
        public static void Initialize(SqlContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
