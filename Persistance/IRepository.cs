using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBeregovoy.SoftDevelop.Domain;
using SBeregovoy.SoftDevelop.Domain.Persons;

namespace SBeregovoy.SoftDevelop.Persistance
{
    public interface IRepository
    {
        List<User> Users();
        List<TimeRecord> Emploees();
        List<TimeRecord> Managers();
        List<TimeRecord> Freelancers();

        bool UserCreate(string name, UserRole userRole);
        User UserGet(string name);

        void TimeRecordAdd(UserRole userRole, TimeRecord timeRecord);
        List<TimeRecord> ReportGet(UserRole userRole, DateTime? from=null, 
            DateTime? to=null);
        List<TimeRecord> ReportGetByUser(string userName, UserRole userRole, DateTime? from = null,
          DateTime? to = null);


    }
}
