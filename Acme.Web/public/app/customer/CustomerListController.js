(function(){
    'use strict';
    window.acmeApp.controller('CustomerListController', ['CustomerService', '$uibModal', function (CustomerService, $modal) {
        var vm = this;
        vm.customers = [];
        CustomerService.all().then(function (data) {
            vm.customers = data;
        });
        vm.add = function() {
            $modal.open({
                template: '<add-customer />'
            });
        }
    }]);
})();



