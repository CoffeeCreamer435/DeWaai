using System.Collections.ObjectModel;
using System.Data.Entity.Validation;
using System.Linq;

namespace DeWaaiBeheer
{
    public class DatabaseMethods
    {
        private u480787545_dewaaEntities ef = new u480787545_dewaaEntities();

        #region User Methods
        public ObservableCollection<Users> getUsers()
        {
            return new ObservableCollection<Users>(ef.Users);
        }

        public ObservableCollection<Users> getUsersByCourse(int courseID)
        {
            return new ObservableCollection<Users>(ef.Users.Where(x => x.CoursesID == courseID));
        }


        public void AddUser(Users user)
        {
            ef.Users.Add(user);
        }
     

        public void RemoveUser(int userId)
        {
            ef.Users.Remove(getUsers().First(x => x.ID == userId));
        }
        #endregion

        #region Savechanges
        // Saves Changes
        public void SaveChanges()
        {
            try
            {
                ef.SaveChanges();
            }
            catch (DbEntityValidationException dbex)
            {
                throw dbex;
            }
          
        }
        #endregion

        #region Courses Methods
        public ObservableCollection<Courses> getCourses()
        {
            return new ObservableCollection<Courses>(ef.Courses);
        }
        #endregion

        #region Fleet Methods
        public ObservableCollection<Fleet> getFleet()
        {
            return new ObservableCollection<Fleet>(ef.Fleet);
        }
        #endregion

        #region Instructors Methods
        public ObservableCollection<Instructors> GetInstructors()
        {
            return new ObservableCollection<Instructors>(ef.Instructors);
        }
        #endregion

        #region
        public ObservableCollection<Types> GetBoatTypes()
        {
            return new ObservableCollection<Types>(ef.Types);
        }
        #endregion
    }
}
