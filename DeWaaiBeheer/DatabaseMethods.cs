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

        public ObservableCollection<Courses> getCourses()
        {
            return new ObservableCollection<Courses>(ef.Courses);
        }

        public void addCursussen(string Description, int Price, string Title, string IMG)
        {
            var Courses = new Courses()
            {
                Description = Description,
                Price = Price,
                Title = Title,
                IMG = IMG,
            };
            if (Courses != null)
            {
                ef.Courses.Add(Courses);
            }
        }
        public ObservableCollection<Courses> getCursussen()
        {
            return new ObservableCollection<Courses>(ef.Courses);
                
            }
        }
    }
}
