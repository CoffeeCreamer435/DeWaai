using System.Collections.ObjectModel;
using System.Linq;

namespace DeWaaiBeheer
{
    
    public class DatabaseMethods
    {
        private EntityFramework ef = new EntityFramework();

        /// <summary>
        /// Gets all users of database
        /// </summary>
        /// <returns>Returns a list of all users</returns>
        public ObservableCollection<User> getUsers()
        {
            return new ObservableCollection<User>(ef.Users);
        }

        public ObservableCollection<Cours> getCursussen()
        {
            return new ObservableCollection<Cours>(ef.Courses);
        }
    }
}
