using SBeregovoy.SoftDevelop.Domain;
using SBeregovoy.SoftDevelop.Domain.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBeregovoy.SoftDevelop.Persistance
{
    public class MemoryRepository : IRepository

        //ЧТОБ ДОСТУЧАТЬСЯ, ЗАЧЕМ ДЕЛАТЬ ПРИВАТНЫМ, И КАК ОНО ВЛЯЕТ НА РАБОТОСПОСОБНОСТЬ????
    {
        #region Fake Data
        private List<TimeRecord> emploees = new List<TimeRecord>()
        {
                new TimeRecord(DateTime.Now.AddDays(-3), "Сотрудник первый", 6, "test message"),
                new TimeRecord(DateTime.Now.AddDays(-2), "Сотрудник второй", 10, "test message"),
                new TimeRecord(DateTime.Now.AddDays(-1), "Сотрудник первый", 9, "test message"),
                new TimeRecord(DateTime.Now.AddDays(-4), "Сотрудник второй", 8, "test message"),
        };


        private List<TimeRecord> freelancers = new List<TimeRecord>()
        {

            new TimeRecord(DateTime.Now.AddDays(-5), "Фрилансер2", 6, "test message"),
            new TimeRecord(DateTime.Now.AddDays(-3), "Фрилансер2", 10, "test message"),
            new TimeRecord(DateTime.Now.AddDays(-2), "Фрилансер1", 8, "test message"),
            new TimeRecord(DateTime.Now.AddDays(-1), "Фрилансер2", 5, "test message"),

        };

        private List<TimeRecord> managers = new List<TimeRecord>()
        {
            new TimeRecord(DateTime.Now.AddDays(-1), "Руководитель", 9, "test message"),
            new TimeRecord(DateTime.Now.AddDays(-1), "Руководитель", 5, "test message"),
        }; 
        #endregion

        public List<TimeRecord> Emploees()
        {
            return emploees;
        }

        public List<TimeRecord> Freelancers()
        {
            return freelancers;
        }

        public List<TimeRecord> Managers()
        {
            return managers;
        }


        public List<TimeRecord> ReportGet(UserRole userRole, DateTime? from = null, DateTime? to = null)
        {
            var records = new List<TimeRecord>();
            switch (userRole)
            {
                case UserRole.Manager:
                    records = Managers();
                    break;
                case UserRole.Emploee:
                    records = Emploees();
                    break;
                case UserRole.Freelancer:
                    records= Freelancers();
                    break;
                default:
                    throw new NotImplementedException("Добавлена новая роль");
            }

            if (from == null)
            {
                from = DateTime.Now.AddYears(-100);
            }
            if (to == null)
            {
                to = DateTime.Now;
            }


            return records.Where(x => from.Value >= x.Date && x.Date<= to).ToList();
        }

        public List<TimeRecord> ReportGetByUser(string userName, UserRole userRole, DateTime? from = null, DateTime? to = null)
        {
            return ReportGet(userRole, from, to).Where(x=> x.Name == userName).ToList();
        }

        public void TimeRecordAdd(UserRole userRole, TimeRecord timeRecord)
        {
            throw new NotImplementedException();
        }

        public bool UserCreate(string name, UserRole userRole)
        {
            //    var newUser = new User(name, userRole);
            //    users.Add(newUser);
            //    return newUser;

            var newUser = new User(name, userRole);
            User existedUser = UserGet(name);

            if (existedUser == null)
            {
                users.Add(newUser);
                return true;
            } else
            {
                return false;
            }


        }

        public User UserGet(string name)
        {
            return Users().FirstOrDefault(x => x.Name == name);
        }

        private List<User> users = new List<User>()
        {
            new User("Руководитель", UserRole.Manager),
            new User("Руководитель", UserRole.Manager),
            new User("Сотрудник первый", UserRole.Emploee),
            new User("Сотрудник первый", UserRole.Emploee),
            new User("Фрилансер2", UserRole.Freelancer),
            new User("Фрилансер2", UserRole.Freelancer),
        };


        public List<User> Users()
        {
            return users;
        }
    }
}
