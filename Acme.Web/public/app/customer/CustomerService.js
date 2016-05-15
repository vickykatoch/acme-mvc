(function(){
    'use strict';
    window.acmeApp.factory('CustomerService', ['$http','$q', function ($http,$q) {
        var svc = {
            add: add,
            update: update,
            all: all
        };
        return svc;

        function all() {
            return $q(function (resolve, reject) {
                $http.post('/Customer/All').then(function (response) { resolve(response.data); }, function (err) { reject(err); });
            });
        }
        function add(customer) {

        }
        function update(customer) {

        }

    }]);
})();



