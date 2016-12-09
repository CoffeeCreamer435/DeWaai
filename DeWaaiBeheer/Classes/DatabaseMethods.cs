using System.Collections.ObjectModel;
using System.Data.Entity.Validation;
using System.Linq;

namespace DeWaaiBeheer
{
    public class DatabaseMethods
    {
        private EntityFramework ef = new EntityFramework();

        #region User Methods

        /// <summary>
        /// Method to get all users
        /// </summary>
        /// <returns></returns>
        public ObservableCollection<Users> getUsers()
        {
            return new ObservableCollection<Users>(ef.Users);
        }

        public ObservableCollection<Registrations> getUsersByCourse()
        {
            var query = from x in ef.Registrations                       
                        join xa in ef.Courses                       
                        on x.CourseID equals xa.ID
                        join xx in ef.Users                       
                        on x.UserID equals xx.ID                       
                        select x;

            return new ObservableCollection<Registrations>(query);
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
        /// <summary>
        /// Method who saves something into database
        /// </summary>
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

        public ObservableCollection<Courses> GetCoursesbyID(int courseID)
        {
            return new ObservableCollection<Courses>(ef.Courses.Where(x => x.ID == courseID));
        }

        public void AddCourse(Courses course)
        {
            ef.Courses.Add(course);
        }

        public void RemoveCourse(int courseid)
        {
            ef.Courses.Remove(getCourses().First(x => x.ID == courseid));
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

        #region Boats
        public ObservableCollection<Types> GetBoatTypes()
        {
            return new ObservableCollection<Types>(ef.Types);
        }

        public void AddBoatType(Types type)
        {
            ef.Types.Add(type);
        }
        #endregion
    }
}
