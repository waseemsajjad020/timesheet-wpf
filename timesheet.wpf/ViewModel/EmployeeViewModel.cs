using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using timesheet.core.Base;
using timesheet.core.Singleton;
using timesheet.data.Models;
using timesheet.data.Services;

namespace timesheet.wpf.ViewModel
{
    public class EmployeeViewModel : BaseViewModel
    {
        /// <summary>
        /// Create Instance of Service and Run Task to Load Employees
        /// </summary>
        public EmployeeViewModel()
        {
            this.Service = (EmployeeService)SingletonInstances.GetEmployeeService(typeof(EmployeeService));
            Task.Run(new Action(async () =>
            {
                await LoadEmployees();
            }));
        }


        #region Properties
        /// <summary>
        /// Service Instance 
        /// </summary>
        private EmployeeService m_Service = null;
        public EmployeeService Service
        {
            set
            {
                if (this.m_Service != value)
                {
                    this.m_Service = value;
                    NotifyPropertyChanged("Service");
                }
            }
            get
            {
                return this.m_Service;
            }
        }

        /// <summary>
        /// Employees List
        /// </summary>
        private ObservableCollection<Employee> m_Employees = new ObservableCollection<Employee>();
        public ObservableCollection<Employee> Employees
        {
            set
            {
                if (this.m_Employees != value)
                {
                    this.m_Employees = value;
                    NotifyPropertyChanged("Employees");
                }
            }
            get
            {
                return this.m_Employees;
            }
        }

        /// <summary>
        /// Selected Employees
        /// </summary>
        private Employee m_SelectedEmployee = null;
        public Employee SelectedEmployee
        {
            set
            {
                if (this.m_SelectedEmployee != value)
                {
                    this.m_SelectedEmployee = value;
                    NotifyPropertyChanged("SelectedEmployee");
                    Task.Run(new Action(async () =>
                    {
                        DateTime dt = DateTime.Now;
                        int diff = (7 + (dt.DayOfWeek - DayOfWeek.Sunday)) % 7;
                        this.m_SelectedEmployee.LoadTaskFrom = dt.AddDays(-1 * diff).Date;
                        this.m_SelectedEmployee.LoadTaskTo = this.m_SelectedEmployee.LoadTaskFrom.AddDays(6);
                        await LoadEmployeeTasks();
                    }));
                }
            }
            get
            {
                return this.m_SelectedEmployee;
            }
        }

        private string m_TimeSheetDurationLabel = string.Empty;
        public string TimeSheetDurationLabel
        {
            set
            {
                if(this.m_TimeSheetDurationLabel!=value)
                {
                    this.m_TimeSheetDurationLabel = value;
                    NotifyPropertyChanged("TimeSheetDurationLabel");
                }
            }
            get
            {
                return this.m_TimeSheetDurationLabel;
            }
        }
        #endregion


        #region Functions 
        /// <summary>
        /// Load All Employees using Service
        /// </summary>
        /// <returns></returns>
        private async Task LoadEmployees()
        {
            if (this.Service != null)
                this.Employees = await this.Service.GetEmployees();
        }

        /// <summary>
        /// Load Taks of an Employee
        /// </summary>
        /// <param name="EmployeeID"></param>
        /// <param name="From"></param>
        /// <param name="To"></param>
        /// <returns></returns>
        private async Task LoadEmployeeTasks()
        {
            this.TimeSheetDurationLabel = (this.SelectedEmployee.LoadTaskFrom.ToString("MMM dd")) + "    to    " +
                (this.SelectedEmployee.LoadTaskTo.ToString("MMM dd")) + "  " + (this.SelectedEmployee.LoadTaskFrom.ToString("yyyy"));
            if (this.Service != null)
                this.SelectedEmployee.Tasks = await this.Service.GetEmployeeWeeklyTasks(this.SelectedEmployee.Id, this.SelectedEmployee.LoadTaskFrom, this.SelectedEmployee.LoadTaskTo);
        }

        /// <summary>
        /// Update Time Sheets of Employee
        /// </summary>
        /// <param name="TaskID"></param>
        /// <param name="TimeSheets"></param>
        /// <returns></returns>
        public async Task<bool> SaveTimeSheets(Action OnSuccessFunction)
        {
            bool Response = false;
            try
            {
                if (this.Service != null)
                {
                    Response = await this.Service.UpdateTimeSheets(this.SelectedEmployee.Tasks);
                    if(Response)
                    {
                        OnSuccessFunction.Invoke();
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return Response;
        }
        #endregion

        #region Commands 
        public void LoadNextWeekTasks()
        {
            this.SelectedEmployee.LoadTaskFrom = this.SelectedEmployee.LoadTaskTo.AddDays(1);
            this.SelectedEmployee.LoadTaskTo = this.SelectedEmployee.LoadTaskFrom.AddDays(6);
            Task.Run(new Action(async () =>
            {
                await this.LoadEmployeeTasks();
            }));
        }
        public void LoadPreviousWeekTasks()
        {
            this.SelectedEmployee.LoadTaskTo = this.SelectedEmployee.LoadTaskFrom.AddDays(-1);
            this.SelectedEmployee.LoadTaskFrom = this.SelectedEmployee.LoadTaskTo.AddDays(-6);
            Task.Run(new Action(async () =>
            {
                await this.LoadEmployeeTasks();
            }));
        }
        #endregion

    }
}
