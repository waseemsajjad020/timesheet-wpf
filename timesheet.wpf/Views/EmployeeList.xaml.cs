using System; 
using System.Windows;
using System.Windows.Controls; 
using System.Windows.Media; 
using timesheet.data.Models; 
using timesheet.wpf.ViewModel;

namespace timesheet.wpf.Views
{
    /// <summary>
    /// Interaction logic for EmployeeList.xaml
    /// </summary>
    public partial class EmployeeList : UserControl
    {
        public event RoutedEventHandler OnEmployeeSelected;
        public EmployeeList()
        {
            InitializeComponent();
        }
        void OpenTaskSheet(object sender, RoutedEventArgs e)
        {
            try
            {
                for (var vis = sender as Visual; vis != null; vis = VisualTreeHelper.GetParent(vis) as Visual)
                    if (vis is DataGridRow)
                    {
                        var row = (DataGridRow)vis;
                        Employee _SelectedEmployee = row.DataContext as Employee;
                        if (_SelectedEmployee != null)
                        {
                            (this.DataContext as EmployeeViewModel).SelectedEmployee = _SelectedEmployee; 
                            if(this.OnEmployeeSelected!=null)
                            {
                                this.OnEmployeeSelected(true, e);
                            }
                        }
                        break;
                    }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
