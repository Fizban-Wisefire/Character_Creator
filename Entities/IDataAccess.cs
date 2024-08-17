using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public interface IDataAccess
    {
        Task<List<Race>> GetRaces();
        List<Class> GetClasses();
    }
}
