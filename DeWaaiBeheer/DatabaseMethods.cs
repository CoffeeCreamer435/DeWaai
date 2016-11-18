using System.Collections.ObjectModel;
using System.Linq;

namespace DeWaaiBeheer
{
    
    public class DatabaseMethods
    {
        private EntityFramewok ef = new EntityFramewok();

        /// <summary>
        /// Gets all users of database
        /// </summary>
        /// <returns>Returns a list of all users</returns>
        public ObservableCollection<Users> getUsers()
        {
            return new ObservableCollection<Users>(ef.Users);
        }

        public ObservableCollection<Courses> getCursussen()
        {
            return new ObservableCollection<Courses>(ef.Courses);
        }
    }
}
