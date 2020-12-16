using System; 
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;



namespace timesheet.data.Models
{
    /// <summary>
    /// This Model I created for Employee Information
    /// This will contains the information regarding Employee like Code, Name, AverageWeeklyEffort,etc
    /// </summary>
    public class Employee : INotifyPropertyChanged
    {
        public Employee()
        {

        }

        #region Properties
        /// <summary>
        /// Identity Column
        /// </summary>
        private int m_Id = 0;
        public int Id
        {
            set
            {
                if (this.m_Id != value)
                {
                    this.m_Id = value;
                    NotifyPropertyChanged("Id");
                }
            }
            get
            {
                return this.m_Id;
            }
        }

        /// <summary>
        /// Code of the Employee
        /// </summary>
        private string m_Code = string.Empty;
        public string Code
        {
            set
            {
                if (this.m_Code != value)
                {
                    this.m_Code = value;
                    NotifyPropertyChanged("Code");
                }
            }
            get
            {
                return this.m_Code;
            }
        }

        /// <summary>
        /// Employee Name
        /// </summary>
        private string m_Name = string.Empty;
        public string Name
        {
            set
            {
                if (this.m_Name != value)
                {
                    this.m_Name = value;
                    NotifyPropertyChanged("Name");
                }
            }
            get
            {
                return this.m_Name;
            }
        }


        /// <summary>
        /// For Application Use Only To Save the Last Loaded Tasks Dates
        /// </summary>
        private DateTime m_LoadTaskFrom;
        public DateTime LoadTaskFrom
        {
            set
            {
                if (this.m_LoadTaskFrom != value)
                {
                    this.m_LoadTaskFrom = value;
                    NotifyPropertyChanged("LoadTaskFrom");
                }
            }
            get
            {
                return this.m_LoadTaskFrom;
            }
        }


        /// <summary>
        /// For Application Use Only To save Last Loaded Tasks Dates
        /// </summary>
        private DateTime m_LoadTaskTo;
        public DateTime LoadTaskTo
        {
            set
            {
                if (this.m_LoadTaskTo != value)
                {
                    this.m_LoadTaskTo = value;
                    NotifyPropertyChanged("LoadTaskTo");
                }
            }
            get
            {
                return this.m_LoadTaskTo;
            }
        }

        /// <summary>
        /// Collection of Employee Tasks with Time Sheeets
        /// </summary>
        private ObservableCollection<EmployeeTask> m_Tasks = new ObservableCollection<EmployeeTask>();
        public ObservableCollection<EmployeeTask> Tasks
        {
            set
            {
                if (this.m_Tasks != value)
                {
                    this.m_Tasks = value;
                    NotifyPropertyChanged("Tasks");
                }
            }
            get
            {
                return this.m_Tasks;
            }
        }


        /// <summary>
        /// Total Weekly Effort Calculated After Update
        /// </summary>
        private double m_TotalWeeklyEffort = 0;
        public double TotalWeeklyEffort
        {
            set
            {
                if (this.m_TotalWeeklyEffort != value)
                {
                    this.m_TotalWeeklyEffort = value;
                    NotifyPropertyChanged("TotalWeeklyEffort");
                }
            }
            get
            {
                return this.m_TotalWeeklyEffort;
            }
        }

        /// <summary>
        /// Average Weekly Efforts Get from Database
        /// </summary>
        private double m_AverageWeeklyEffort = 0;
        public double AverageWeeklyEffort
        {
            set
            {
                if (this.m_AverageWeeklyEffort != value)
                {
                    this.m_AverageWeeklyEffort = value;
                    NotifyPropertyChanged("AverageWeeklyEffort");
                }
            }
            get
            {
                return this.m_AverageWeeklyEffort;
            }
        }
        #endregion

        #region Property Changed Event 
        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }

    /// <summary>
    /// This Model I created for Employee Tasks
    /// It will Contain the Information regarding Task Like Task ID, Name and Time Sheets
    /// </summary>
    public class EmployeeTask : INotifyPropertyChanged
    {
        public EmployeeTask()
        {

        }

        #region Properties
        /// <summary>
        /// Identity Column
        /// </summary>
        private int m_Id = 0;
        public int Id
        {
            set
            {
                if (this.m_Id != value)
                {
                    this.m_Id = value;
                    NotifyPropertyChanged("Id");
                }
            }
            get
            {
                return this.m_Id;
            }
        }


        /// <summary>
        /// Name of the Tasks or Title of the Task
        /// </summary>
        private string m_Name = string.Empty;
        public string Name
        {
            set
            {
                if (this.m_Name != value)
                {
                    this.m_Name = value;
                    NotifyPropertyChanged("Name");
                }
            }
            get
            {
                return this.m_Name;
            }
        }


        /// <summary>
        /// Collection of the Time Sheets for the task
        /// </summary>
        private ObservableCollection<TaskTimeSheet> m_TimeSheets = new ObservableCollection<TaskTimeSheet>();
        public ObservableCollection<TaskTimeSheet> TimeSheets
        {
            set
            {
                if (this.m_TimeSheets != value)
                {
                    this.m_TimeSheets = value;
                    NotifyPropertyChanged("TimeSheets");
                }
            }
            get
            {
                return this.m_TimeSheets;
            }
        }
        #endregion

        #region Property Changed Event 
        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }

    /// <summary>
    /// This Model I created for Time Sheet
    /// It will contain Sunday, Monday, Tuesday, Wednesday, Thursady, Friday and Saturday Hours
    /// </summary>
    public class TaskTimeSheet : INotifyPropertyChanged
    {
        public TaskTimeSheet()
        {

        }

        #region Properties
        /// <summary>
        /// Identity Column or Day 
        /// </summary>
        private DateTime m_Date;
        public DateTime Date
        {
            set
            {
                if (this.m_Date != value)
                {
                    this.m_Date = value;
                    NotifyPropertyChanged("Date");
                }
            }
            get
            {
                return this.m_Date;
            }
        }

        /// <summary>
        /// Hours Spent in the day for specific task
        /// </summary>
        private double m_Hours = 0;
        public double Hours
        {
            set
            {
                if (this.m_Hours != value)
                {
                    this.m_Hours = value;
                    NotifyPropertyChanged("Hours");
                }
            }
            get
            {
                return this.m_Hours;
            }
        }

        /// <summary>
        /// If the date is > Today User can't modify that record
        /// </summary>
        private bool m_IsEnable = false;
        public bool IsEnable
        {
            set
            {
                if (this.m_IsEnable != value)
                {
                    this.m_IsEnable = value;
                    NotifyPropertyChanged("IsEnable");
                }
            }
            get
            {
                return this.m_IsEnable;
            }
        }
        #endregion

        #region Property Changed Event 
        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
