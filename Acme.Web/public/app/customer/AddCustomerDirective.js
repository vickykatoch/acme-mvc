(function(){
    'use strict';
    window.acmeApp.directive('addCustomer',[function(){
        return {
            restrict : 'E',
            templateUrl: '/customer/template/addCustomer.tmpl.cshtml',
            controller: controller,
            controllerAs: 'vm'
        }
    }]);

    controller.$inject = ['$scope', 'CustomerService'];
    function controller($scope, CustomerService) {
        var vm = this;
        vm.customer = {};
        vm.saving = false;
        vm.errorMessage = null;

        vm.add = function () {
            vm.saving = true;
            CustomerService.add(vm.customer)
                .success(function () {
                    $scope.$close();
                })
                .error(function (err) {
                    vm.errorMessage = 'There was a problem adding the customer: ' + data;
                })
                .finally(function () {
                    vm.saving = false;
                });
        }
    }
})();