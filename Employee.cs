
using System;

namespace classes{
    class Employee {
        private string _firstName {get;set;}
        private string _lastName {get;set;}
        public string Title {get;set;}
        private DateTime _startDate {get;set;}

        public Employee(string firstName, string lastName) {
            _firstName = firstName;
            _lastName = lastName;
        }
        public void setStartDate (DateTime dt) {
            _startDate = dt;
        }
        public string getEmpName () {
            return _firstName +" " + _lastName;
        }
        public DateTime getStartDate () {
            return _startDate;
        }
    }
}