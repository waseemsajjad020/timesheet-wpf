using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using timesheet.wpf.Views;
using timesheet.wpf.Views.TimeSheet;

namespace timesheet.wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        #region Events
        /// <summary>
        /// On Application Loaded Show Employees List Screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ShowEmployeesScreen();
        }

        /// <summary>
        /// Move Window from Title Bar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void titleBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        /// <summary>
        /// Close Application Button Pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        /// <summary>
        /// On Back Button Press Go back to Employees List Screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            ShowEmployeesScreen();
        }
        #endregion

        #region Functions
        /// <summary>
        /// Show Employees User Control to View and Change the Title 
        /// </summary>
        public void ShowEmployeesScreen()
        {
            try
            {
                EmployeeList employeesView = new EmployeeList();
                employeesView.OnEmployeeSelected += (Sender, eve) =>
                { ShowTimeSheetScreen(); };
                layout.Content = employeesView;
                btnBack.Visibility = Visibility.Collapsed;
                lblTitle.Text = "EMPLOYEES LIST";
            }
            catch (Exception ex)
            {

            }
        }

        /// <summary>
        /// Show Time Sheeet View and Change Title and Back Button
        /// </summary>
        public void ShowTimeSheetScreen()
        {
            try
            {
                TimesheetView timeSheet = new TimesheetView();
                timeSheet.OnBackButtonClick += (Sender, eve) =>
                { ShowEmployeesScreen(); };
                layout.Content = timeSheet;
                btnBack.Visibility = Visibility.Visible;
                lblTitle.Text = "EMPLOYEE TIME SHEET";
            }
            catch (Exception ex)
            {

            }
        }
        #endregion 
    }
}
