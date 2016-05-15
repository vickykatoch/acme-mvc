(function(){
    'use strict';
    window.acmeApp.controller('CustomerListController', ['CustomerService', function (CustomerService) {
        var vm = this;
        vm.customers = [];
        CustomerService.all().then(function (data) {
            vm.customers = data;
        });
    }]);
})();



