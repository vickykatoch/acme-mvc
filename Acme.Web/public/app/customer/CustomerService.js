(function(){
    'use strict';
    window.acmeApp.factory('CustomerService', ['$http', '$q', function ($http, $q) {
        var customers = [];
        var svc = {
            add: add,
            update: update,
            all: all
        };
        return svc;

        function all() {
            return $q(function (resolve, reject) {
                $http.get('/Customer/All').then(function (response) { resolve(response.data); }, function (err) { reject(err); });
            });
        }
        function add(customer) {
            return $http.post('/Customer/Add', customer)
				.success(function (customer) {
				    customers.unshift(customer);
				});
        }
        function update(customer) {

        }

    }]);
})();



