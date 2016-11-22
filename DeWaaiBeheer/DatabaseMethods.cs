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

        /// <summary>
        /// Method to add user to database
        /// </summary>
        /// <param name="user">Variable that contains the user table</param>
        public void AddUser(Users user)
        {
            ef.Users.Add(user);
        }

        public void RemoveUser(int userId)
        {
            ef.Users.Remove(getUsers().First(x => x.ID == userId));
        }

        /// <summary>
        /// Method to save changes in database
        /// </summary>
        public void SaveChanges()
        {
            ef.SaveChanges();
        }
    }
}
