(function(){
    'use strict';
    window.acmeApp.directive('customerDetails',[function(){
        return {
            restrict : 'E',
            scope : {
                customer : '='
            },
            templateUrl: '/customer/template/customerDetails.tmpl.cshtml',
            controller: CustDetailsController,
            controllerAs: 'vm'
        }
    }]);

    CustDetailsController.$inject = ['$scope']
    function CustDetailsController($scope) {
        var vm = this;
        vm.customer = $scope.customer;
        vm.selectedView = 'details';
    }
})();



