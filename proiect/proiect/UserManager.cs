using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect
{
    public class UserManager
    {
        private List<User> _users = new List<User>();
        private User _currUser = null;

        public UserManager()
        {
            // adaugare admin
            User user = new User(1, "admin", "admin");
            _users.Add(user);

            //loadUsersFromDataBase();
        }

        public bool userExists(string username, string password)
        {
            for (int i = 0; i < _users.Count; i++)
            {
                if (_users[i].Name == username && _users[i].Password == password)
                {
                    return true;
                }
            }
            return false;

        }

        private void loadUsersFromDataBase()
        {
            throw new NotImplementedException();
        }
    }
}
