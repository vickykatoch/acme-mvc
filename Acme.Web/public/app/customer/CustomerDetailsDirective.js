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

    CustDetailsController.$inject = ['$scope', '$uibModal'];
    function CustDetailsController($scope, $model) {
        var vm = this;
        vm.customer = $scope.customer;
        vm.selectedView = 'details';

        vm.edit= function() {
            $model.open({
				template: '<edit-customer customer="customer" />',
				scope: angular.extend($scope.$new(true), { customer: vm.customer })
			});
		}

        vm.addOpportunity = function () {
            $model.open({
                template: '<add-opportunity customer="customer" />',
                scope: angular.extend($scope.$new(true), { customer: vm.customer })
            });
        }
    }
})();



