using System.Collections.Generic;
using Lessons12.models;

namespace Lessons12.services
{
    public class ServiceListEmployee
    {
        public List<Employee> Employees { get; set; }

        public ServiceListEmployee(List<Employee> employees)
        {
            Employees = employees;
        }

        public void AddEmployee(Employee employee)
        {
            if (!Employees.Contains(employee))
            {
                Employees.Add(employee);
            }
        }

        public void RemoveEmployee(Employee employee)
        {
            Employees.Remove(employee);
        }
    }
}