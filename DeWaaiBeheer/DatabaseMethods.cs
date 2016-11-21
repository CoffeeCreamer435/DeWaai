using System.Collections.ObjectModel;
using System.Linq;

namespace DeWaaiBeheer
{
    
    public class DatabaseMethods
    {
        private u480787545_dewaaEntities ef = new u480787545_dewaaEntities();

        /// <summary>
        /// Gets all users of database
        /// </summary>
        /// <returns>Returns a list of all users</returns>
        public ObservableCollection<Users> getUsers()
        {
            return new ObservableCollection<Users>(ef.Users);
        }
    }
}
