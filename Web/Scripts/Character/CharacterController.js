(function () {
    "use strict";
    angular
        .module("mainApp")
        .controller("characterController", CharacterController);

    // Inject services
    CharacterController.$inject = ["$scope", "$window", "service"];

    function CharacterController($scope, $window, service) {
        var vm = this;

        // View model
        vm.item = {};
        vm.items = [];
        vm.$scope = $scope;
        vm.service = service;
        vm.$onInit = _init;
        vm.id = 1;  // hard code, replace after home page (character list) completion

        // The Fold
        // Initialize
        function _init() {
            console.log("Initialized.");
            vm.service.getById('/api/character/', vm.id)
                .then(_getByIdSuccess, _error);
        }

        // Get By Id Success
        function _getByIdSuccess(res) {
            vm.item = res.data.item;
            console.log(vm.item);
        }

        // Error
        function _error(err) {
            console.log(err);
        }
    }
})();