using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using timesheet.data.Models;
using timesheet.wpf.ViewModel;

namespace timesheet.wpf.Views.TimeSheet
{
    public partial class TimesheetView : UserControl
    {
        public event RoutedEventHandler OnBackButtonClick;
        public TimesheetView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load Next Week Data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            (this.DataContext as EmployeeViewModel).LoadNextWeekTasks();
        }

        /// <summary>
        /// Load Previous Week Data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            (this.DataContext as EmployeeViewModel).LoadPreviousWeekTasks();
        }

        /// <summary>
        /// Back to Employee List
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            if (this.OnBackButtonClick != null)
            {
                this.OnBackButtonClick(true, e);
            }
        }

        /// <summary>
        /// Save Changes to Database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            (this.DataContext as EmployeeViewModel).SaveTimeSheets(new Action(()=>{
                btnBack_Click(null,null);
            })); 
        }

        /// <summary>
        /// Calculate Total Hours of each day
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnTimeSheetValueChanged(object sender, RoutedEventArgs e)
        {
            try
            {
                if (lstTimeSheet != null && lstTimeSheet.ItemsSource != null)
                {
                    double Sunday = 0, Monday = 0, Tuesday = 0, Wednesday = 0, Thursday = 0, Firday = 0, Saturday = 0;
                     
                    foreach (EmployeeTask _task in lstTimeSheet.ItemsSource)
                    {
                        foreach (var timeSheet in _task.TimeSheets)
                        {
                            switch(timeSheet.Date.DayOfWeek.ToString())
                            {
                                case "Sunday":
                                    Sunday += timeSheet.Hours;
                                    break;
                                case "Monday":
                                    Monday += timeSheet.Hours;
                                    break;
                                case "Tuesday":
                                    Tuesday += timeSheet.Hours;
                                    break; 
                                case "Wednesday":
                                    Wednesday += timeSheet.Hours;
                                    break;
                                case "Thursday":
                                    Thursday += timeSheet.Hours;
                                    break;
                                case "Friday":
                                    Firday += timeSheet.Hours;
                                    break;
                                case "Saturday":
                                    Saturday += timeSheet.Hours;
                                    break; 
                            } 
                        }
                    }
                    lblTotalSunday.Text = Sunday.ToString();
                    lblTotalMonday.Text = Monday.ToString();
                    lblTotalTuesday.Text = Tuesday.ToString();
                    lblTotalWednesday.Text = Wednesday.ToString();
                    lblTotalThursday.Text = Thursday.ToString();
                    lblTotalFriday.Text = Firday.ToString();
                    lblTotalSaturday.Text = Saturday.ToString();
                }
            }
            catch (Exception ex)
            {

            }
        }  
    }
}
