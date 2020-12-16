using System.Text.RegularExpressions; 
using System.Windows;
using System.Windows.Controls; 
using System.Windows.Input; 

namespace timesheet.wpf.Views.TimeSheet.Controls
{ 
    public partial class TimeSheetListItem : UserControl
    {
        public event RoutedEventHandler OnItemValueChanged;
        public TimeSheetListItem()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            if (this.OnItemValueChanged != null)
            {
                this.OnItemValueChanged(true, e);
            }
        }

        /// <summary>
        /// Text Changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(this.OnItemValueChanged!= null)
            {
                this.OnItemValueChanged(true, e);
            }
        }

        /// <summary>
        /// Text Box for Numeric Values Only
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (e.Text == ".")
            {
                if ((sender as TextBox).Text.Contains("."))
                    e.Handled = true;
            }
            else
            {
                Regex _regex = new Regex("[^0-9.]");
                e.Handled = _regex.IsMatch(e.Text);
            }
        }
    }
}
