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

        //public ObservableCollection<Users> getUsersByCourse(int courseID)
        //{
        //    return new ObservableCollection<Users>(ef.Users.Where(x => x.CoursesID == courseID));
        //}


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

        public void AddFleet(Fleet fleet)
        {
            ef.Fleet.Add(fleet);
        }

        public void RemoveFleet(int fleetid)
        {
            ef.Fleet.Remove(getFleet().First(x => x.ID == fleetid));
        }
        #endregion

        #region BoatTypes
        public ObservableCollection<Types> GetBoatTypes()
        {
            return new ObservableCollection<Types>(ef.Types);
        }

        public void AddBoatType(Types types)
        {
            ef.Types.Add(types);
        }

        public void RemoveBoatType(int typeid)
        {
            ef.Types.Remove(GetBoatTypes().First(x => x.ID == typeid));
        }
        #endregion
        #region Instructors Methods
        public ObservableCollection<Instructors> GetInstructors()
        {
            return new ObservableCollection<Instructors>(ef.Instructors);
        }
        #endregion
    }
}
