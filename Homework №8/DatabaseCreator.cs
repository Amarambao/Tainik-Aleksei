using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework__8
{
    internal static class DatabaseCreator
    {
        public static IDatabase CreateDatabase()
        {
            IDatabase database = new InMemoryDatabase();
            return database;
        } 
    }
}
