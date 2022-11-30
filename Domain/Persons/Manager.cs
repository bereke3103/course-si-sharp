 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBeregovoy.SoftDevelop.Domain
{
    public class Manager : Staff
    {

        public decimal MonthBonus => 20000;
        public decimal TotalPay { get; }

        public Manager(string name, List<TimeRecord> timeRecords) : base(name, 200000, timeRecords)
        {

            decimal payPerHour = MonthSalary / Settings.WorkHoursInMonth; //1250
            decimal bonusPerDay = (MonthBonus / Settings.WorkHoursInMonth) * Settings.WorkHourInDay; //1000
            decimal totalPay = 0;

            foreach (var timeRecord in timeRecords)
            {
                if (timeRecord.Hours <= Settings.WorkHourInDay)
                {
                    totalPay += timeRecord.Hours * payPerHour;
                } 
                else //переработка
                {
                    totalPay += Settings.WorkHourInDay * payPerHour + bonusPerDay;
                }
            }

            TotalPay = totalPay;
        }
    }
}
