using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace proiect
{

    public class UserManager
    {
        public static string currentPath = Directory.GetCurrentDirectory(); // path pentru a citi baza de date
        public static string newPath = currentPath.Substring(0, currentPath.IndexOf("bin")); //path radacina proiect
        
        //sir conectare
        SqlConnection conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=" + newPath + "restaurants.mdf;" + "Integrated Security = True");
        private List<User> _users = new List<User>();
        private User? _currUser = null;

        public UserManager()
        {
            loadUsersFromDataBase();
        }
        public User CurrentUser
        {
            get { return _currUser!; }
            set { _currUser = value;
                _users.Add(_currUser);
            }
        }

        public User getUser(string username, string password)
        {
            if(userExists(username,password) == true)
            {
                for (int i = 0; i < _users.Count; i++)
                {
                    if (_users[i].Name.Trim().Equals(username) && _users[i].Password.Trim().Equals(password))
                    {
                        return _users[i];
                    }
                }
            }
            return null!;
        }
        //verificare existenta userului pentru autentificare
        public bool userExists(string username, string password)
        {
            for (int i = 0; i < _users.Count; i++)
            {
                if (_users[i].Name.Trim().Equals(username) && _users[i].Password.Trim().Equals(password))
                {
                    return true;
                }
            }
            return false;

        }
        //Ia tot ce se afla in administrator si adauga in lista _users
        private void loadUsersFromDataBase()
        {
            
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from Administrator";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                try
                {
                    int id;
                    string nume, parola;
                    int.TryParse(dt.Rows[i][0].ToString(), out id);

                    nume = dt.Rows[i][1].ToString()!;
                    parola = dt.Rows[i][1].ToString()!;
                    _users.Add(new User(id, nume, parola));

                }
                catch (Exception) { }
            }
        }

        public void resetUserList()
        {
            _users.Clear();
            loadUsersFromDataBase();
        }
    }
}
