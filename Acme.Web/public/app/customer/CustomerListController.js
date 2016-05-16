(function(){
    'use strict';
    window.acmeApp.controller('CustomerListController', ['CustomerService', '$uibModal','CustomerModel', function (CustomerService, $modal, CustomerModel) {
        var vm = this;
        vm.customers = CustomerModel;
        //CustomerService.all().then(function (data) {
        //    vm.customers = data;
        //});
        vm.add = function() {
            $modal.open({
                backdrop: 'static',
                template: '<add-customer />',
                keyboard:false
            });
        }
    }]);
})();



