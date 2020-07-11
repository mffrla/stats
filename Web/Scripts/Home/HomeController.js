(function () {
    "use strict";
    angular
        .module("mainApp")
        .controller("homeController", HomeController);

    // Inject services
    HomeController.$inject = ["$scope", "$window", "service"];

    function HomeController($scope, $window, service) {
        var vm = this;

        // View model
        vm.item = {};
        vm.items = [];
        vm.$scope = $scope;
        vm.service = service;
        vm.$onInit = _init;

        // The Fold
        // Initialize
        function _init() {
            console.log("Initialized.");
            vm.service.get('/api/character/')
                .then(_getSuccess, _error);
        }

        // Get By Id Success
        function _getSuccess(res) {
            console.log(res);
            vm.items = res.data.items;
            console.log(vm.items);
        }

        // Error
        function _error(err) {
            console.log(err);
        }
    }
})();