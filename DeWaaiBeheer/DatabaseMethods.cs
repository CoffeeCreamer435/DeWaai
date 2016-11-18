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

        public ObservableCollection<Cursussen> getCursussen()
        {
            return new ObservableCollection<Cursussen>(ef.Cursussens);
        }

        public void addCursussen(string Text, int Price, string Title, string IMG)
        {
            var Cursussen = new Cursussen()
            {
                text = Text,
                Price = Price,
                Title = Title,
                IMG = IMG,
           };
            if(Cursussen != null)
            {
                ef.Cursussens.Add(Cursussen);
            }
        }
    }
}
