using Lab12WPF.model;
using Lab12WPF.network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12WPF.db
{
    public class UserRepository
    {
        Dictionary<IClientConnection, UserContainer> Users = new Dictionary<IClientConnection, UserContainer>();

        internal UserContainer Get(uint number)
        {
            return Users.SingleOrDefault(u=>u.Value.Number == number).Value;
        }


        internal UserContainer Get(IClientConnection connection)
        {
            Users.TryGetValue(connection, out var user);
            return user;
        }

        internal void Remove(IClientConnection connection)
        {
            Users.Remove(connection);
        }

        internal UserContainer Insert(IClientConnection source)
        {
            return Users[source] = new UserContainer() { Connection = source};
        }
    }
}
