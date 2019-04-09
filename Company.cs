using System;
using System.Collections.Generic;

namespace classes {
    class Company {
        private DateTime _founded  {get;set;}
        private string _name {get;set; }
        private List<Employee> Employees = new List<Employee>();

        public Company (string name) {
            _name = name;
        }
        public void setFoundedDate (DateTime dt ){
            _founded = dt;
        }
        public string getCompanyName () {
            return _name;
        }
        public DateTime getFoundedDate () {
            return _founded.Date;
        }
        public List<Employee> getEmployees () {
            return Employees;
        }
        public void addEmp ( Employee emp) {
            Employees.Add(emp);
        }
    }
}