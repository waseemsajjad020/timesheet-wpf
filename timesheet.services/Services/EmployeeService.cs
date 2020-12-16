using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using timesheet.data.Contracts;
using timesheet.data.Models;

namespace timesheet.data.Services
{
    public class EmployeeService : IEmployeeService
    {
        private string _baseurl = "";
        public EmployeeService()
        {
            _baseurl = ConfigurationManager.AppSettings["baseUrl"].ToString();
        }
        /// <summary>
        /// Get All Employees from Database
        /// </summary>
        /// <returns></returns>
        public async Task<ObservableCollection<Employee>> GetEmployees()
        {
            ObservableCollection<Employee> Response = new ObservableCollection<Employee>();
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(delegate { return true; });
                    HttpResponseMessage response = await client.GetAsync(_baseurl + "/employees/all");
                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        List<Employee> employees = JsonConvert.DeserializeObject<List<Employee>>(json);
                        Response = new ObservableCollection<Employee>(employees);
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return Response;
        }

        /// <summary>
        /// Get Employee Weekly Tasks Detail with time Sheets
        /// </summary>
        /// <param name="EmployeeID"></param>
        /// <param name="From"></param>
        /// <param name="To"></param>
        /// <returns></returns>
        public async Task<ObservableCollection<EmployeeTask>> GetEmployeeWeeklyTasks(int EmployeeID, DateTime From, DateTime To)
        {
            ObservableCollection<EmployeeTask> Response = new ObservableCollection<EmployeeTask>();
            try
            {
                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(delegate { return true; });
                using (HttpClient client = new HttpClient())
                {

                    HttpResponseMessage response = await client.GetAsync(_baseurl + "/employees/get_tasks?employee_id=" + EmployeeID + "&from=" + From + "&to=" + To);
                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        List<EmployeeTask> Tasks = JsonConvert.DeserializeObject<List<EmployeeTask>>(json).ToList();
                        foreach (EmployeeTask task in Tasks)
                        {
                            foreach (TaskTimeSheet sheet in task.TimeSheets)
                            {
                                if (sheet.Date > DateTime.Now)
                                {
                                    sheet.IsEnable = false;
                                }
                                else
                                {
                                    sheet.IsEnable = true;
                                }
                            }
                        }
                        Response = new ObservableCollection<EmployeeTask>(Tasks);
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return Response;
        }

        /// <summary>
        /// Update Time Sheets of a Task for Employee
        /// </summary>
        /// <param name="TaskID"></param>
        /// <param name="TimeSheets"></param>
        /// <returns></returns>
        public async Task<bool> UpdateTimeSheets(ObservableCollection<EmployeeTask> Tasks)
        {
            bool Response = true;
            try
            {
                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(delegate { return true; });
                using (HttpClient client = new HttpClient())
                {
                    List<Employee> employees = new List<Employee>();
                    var myContent = JsonConvert.SerializeObject(Tasks.ToList());
                    var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
                    var byteContent = new ByteArrayContent(buffer);
                    byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json"); 
                    var response = await client.PostAsync(_baseurl + "/employees/update", byteContent);
                    if (response.IsSuccessStatusCode)
                    {
                        Response = true;
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return Response;
        }
    }
}
