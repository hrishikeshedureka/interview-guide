using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{

    public class IDataStorageViolate
    {
        public void SaveData(string data)
        {
            // Implementation for saving data to a database
        }
        public void GetData(int id)
        {
            // Implementation for retrieving data from a database
        }
    }

    public class UserServiceViolate
    {
        private IDataStorageViolate Database;
        public UserServiceViolate(IDataStorageViolate database)
        {
            this.Database = database ?? throw new ArgumentNullException(nameof(database));
        }

        //UserServiceViolate methods that use the Database instance is tightly couples with the Database class to creating a direct dependency.
        //If we decide to alter the database implementation, we would need to modify the UserService class as well.
        //We will need to refactor the UserService class to follow the Dependency Inversion Principle (DIP).

        //By applying the DIP, we achieve a more flexible and maintainable design enabling us to evolve and adapt our system more easy over time.
    }






}
