using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocabularySprintLibrary.Infrastructure
{
    class InMemoryUserRepository : IUserRepository
    {
        public IEnumerable<User> LoadAllUsers()
        {
            throw new NotImplementedException();
        }

        public User LoadUser(Guid userId)
        {
            throw new NotImplementedException();
        }

        public void SaveUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
