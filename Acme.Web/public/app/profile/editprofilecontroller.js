(function(){
    'use strict';
    window.acmeApp.controller('EditProfileController', EditProfileController);

    EditProfileController.$inject = ['model'];

    function EditProfileController(model) {
        var vm = this;
        vm.profile = model;

        vm.save = function () {
            alert('saved');
        }
    }

})();