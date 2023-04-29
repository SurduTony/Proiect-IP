using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect
{
    public class User
    {

        private int _id; //nr. de ordine al admin. (acesta poate introduce restaurante,sali etc.)
        private string _name; //numele (user)
        private string _password;//parola de logare

        public User(int id, string name, string password)
        {
            _id = id;
            _name = name;
            _password = password;
        }

        // gettere si settere pentru variabilele private
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
    }
}
