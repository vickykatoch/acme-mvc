﻿
angularFormsApp.factory('DataService',
    ["$http",
    function ($http) {

        var getEmployees = function () {

            return $http.get("api/EmployeeWebApi/Get");
        };

        var getEmployee = function (id) {
            if (id == 123) {
                return {
                    id: 123,
                    fullName: "Milton Waddams",
                    notes: "The ideal employee.  Just don't touch his red stapler.",
                    department: "Administration",
                    dateHired: "July 11 2014",
                    breakTime: "July 11 2014 3:00 PM",
                    perkCar: true,
                    perkStock: false,
                    perkSixWeeks: true,
                    payrollType: "none"
                };
            }
            return undefined;
        };

        var insertEmployee = function (newEmployee) {

            return $http.post("api/EmployeeWebApi/Post", newEmployee);
        };

        var updateEmployee = function (employee) {
            return $http.post("Employee/Update", employee);
        };

        return {
            insertEmployee: insertEmployee,
            updateEmployee: updateEmployee,
            getEmployee: getEmployee,
            getEmployees: getEmployees
        };
    }]);