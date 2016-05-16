﻿
angularFormsApp.controller('efController',
    ["$scope", "$window", "$routeParams", "DataService",
    function efController($scope, $window, $routeParams, DataService) {

        if ($routeParams.id)
            $scope.employee = DataService.getEmployee($routeParams.id);
        else
            $scope.employee = { id: 0 };

        $scope.editableEmployee = angular.copy($scope.employee);

        $scope.departments = [
            "Engineering",
            "Marketing",
            "Finance",
            "Administration"
        ];

        $scope.shouldShowFullName = function () {
            return true;
        };

        $scope.submitForm = function () {

            $scope.$broadcast('show-errors-event');

            if ($scope.employeeForm.$invalid)
                return;


            if ($scope.editableEmployee.id == 0) {
                // insert new employee
                DataService.insertEmployee($scope.editableEmployee).then(
                    function (results) {
                        // on success
                        $scope.employee = angular.copy($scope.editableEmployee);
                        $scope.employee.id = results.data;
                        $window.history.back();
                    },
                    function (results) {
                        // on error
                        $scope.hasFormError = true;
                        $scope.formErrors = results.statusText;
                    });
            }
            else {
                // update the employee
                DataService.updateEmployee($scope.editableEmployee).then(
                    function (results) {
                        // on success
                        $scope.employee = angular.copy($scope.editableEmployee);
                        $window.history.back();
                    },
                    function (results) {
                        // on error
                        $scope.hasFormError = true;
                        $scope.formErrors = results.statusText;
                    });
            }

            
        };

        $scope.cancelForm = function () {
            $window.history.back();
        };

        $scope.resetForm = function () {
            $scope.$broadcast('hide-errors-event');
        }

    }]);