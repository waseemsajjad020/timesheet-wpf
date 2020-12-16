using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using timesheet.data.Models;

namespace timesheet.data.Contracts
{
    public interface IEmployeeService
    {
        /// <summary>
        /// Get All Employees in the database
        /// </summary>
        /// <returns></returns>
        Task<ObservableCollection<Employee>> GetEmployees();


        /// <summary>
        /// Get Employee Tasks With Weekly TimeSheets
        /// </summary>
        /// <param name="EmployeeID"></param>
        /// <param name="From"></param>
        /// <param name="To"></param>
        /// <returns></returns>
        Task<ObservableCollection<EmployeeTask>> GetEmployeeWeeklyTasks(int EmployeeID, DateTime From, DateTime To);

        /// <summary>
        /// This Method With Update the Time Sheets with respect to Employee
        /// </summary>
        /// <param name="TaskID"></param>
        /// <param name="TimeSheets"></param>
        /// <returns></returns>
        Task<bool> UpdateTimeSheets(ObservableCollection<EmployeeTask> Tasks);

    }
}
