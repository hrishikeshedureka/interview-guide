using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.service
{
    public class UserService
    {
        private readonly IDataStorage _dataStorage;
        public UserService(IDataStorage dataStorage)
        {
            _dataStorage = dataStorage ?? throw new ArgumentNullException(nameof(dataStorage));
        }
        public void SaveUserData(string data)
        {
            _dataStorage.Save(data);
        }

        public void GetUserData(string data)
        {
            _dataStorage.GetData(data);
        }
    }
}
